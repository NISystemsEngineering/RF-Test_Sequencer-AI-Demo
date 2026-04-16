using System;
using System.IO;
using NationalInstruments.TestStand.Interop.API;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Sequencer
{
    public static partial class TestStandSequenceFileFactory
    {
        /// <summary>Writes a bundle using template paths (requires a valid catalog at the template path, or use the overload with a snapshot).</summary>
        public static void CreateWlanInstrumentBundle(string outputPath, string instrumentAssemblyPath)
        {
            var snap = TestStandSequenceGenerationSnapshot.CreateTemplateDefaults();
            if (!snap.TryComputeTotalPointCount(out int n, out string err))
                throw new InvalidOperationException(
                    "Cannot build a default bundle without a valid waveform catalog. Use the Sequencer UI (paths and sweep options from the main window) or pass a " + nameof(TestStandSequenceGenerationSnapshot) + " with an existing catalog path. " + err);
            snap.TotalPointCount = n;
            CreateWlanInstrumentBundle(outputPath, instrumentAssemblyPath, snap);
        }

        /// <summary>
        /// Writes a sequence file structured like NI examples: <c>MainSequence</c> uses Setup / Main / Cleanup step groups;
        /// optional <c>WLAN_FullMatrix</c> subsequence for one-shot execution; <c>Demo_FlowControlSteps</c> for flow examples.
        /// </summary>
        public static void CreateWlanInstrumentBundle(string outputPath, string instrumentAssemblyPath, TestStandSequenceGenerationSnapshot snapshot)
        {
            if (string.IsNullOrWhiteSpace(outputPath))
                throw new ArgumentException("Output path is required.", nameof(outputPath));
            if (string.IsNullOrWhiteSpace(instrumentAssemblyPath))
                throw new ArgumentException("Path to WlanRfAmpTest.Instrument.dll is required.", nameof(instrumentAssemblyPath));
            if (snapshot == null)
                throw new ArgumentNullException(nameof(snapshot));
            if (snapshot.TotalPointCount <= 0)
                throw new ArgumentException("TotalPointCount must be positive. Call TryComputeTotalPointCount on the snapshot first.", nameof(snapshot));
            if (snapshot.NestedBandCount < 1 || snapshot.NestedStdCount < 1 || snapshot.NestedBwCount < 1
                || snapshot.NestedFreqCountBand0 < 1)
                throw new ArgumentException(
                    "Nested loop parameters are invalid. Call TryComputeTotalPointCount on the snapshot so Band/Std/Bw/Freq counts are populated.",
                    nameof(snapshot));

            using (var sta = new StaExecutionQueue())
            {
                sta.Invoke(() => CreateWlanInstrumentBundleOnStaThread(outputPath, Path.GetFullPath(instrumentAssemblyPath), snapshot));
            }
        }

        static void CreateWlanInstrumentBundleOnStaThread(string outputPath, string instrumentDllFullPath, TestStandSequenceGenerationSnapshot snapshot)
        {
            if (!File.Exists(instrumentDllFullPath))
                throw new FileNotFoundException("Instrument assembly not found. Build WlanRfAmpTest.Instrument and pass the DLL path.", instrumentDllFullPath);

            Engine engine = new Engine();
            engine.CurrentUser = engine.GetUser("Administrator");
            engine.LoadTypePaletteFilesEx(TypeConflictHandlerTypes.ConflictHandler_Error, 0);

            SequenceFile sequenceFile = null;
            try
            {
                sequenceFile = engine.NewSequenceFile();
                while (sequenceFile.NumSequences > 0)
                    sequenceFile.DeleteSequence(0);

                Sequence seqMain = BuildMainSequence(engine, instrumentDllFullPath, snapshot);
                Sequence seqFullMatrix = BuildWlanFullMatrixSubsequence(engine, instrumentDllFullPath, snapshot);
                Sequence seqDemo = BuildFlowControlDemoSequence(engine);

                sequenceFile.InsertSequenceEx(0, seqMain);
                sequenceFile.InsertSequenceEx(1, seqFullMatrix);
                sequenceFile.InsertSequenceEx(2, seqDemo);

                string full = Path.GetFullPath(outputPath);
                string dir = Path.GetDirectoryName(full);
                if (!string.IsNullOrEmpty(dir))
                    Directory.CreateDirectory(dir);

                sequenceFile.Save(full);
            }
            finally
            {
                if (sequenceFile != null)
                    engine.ReleaseSequenceFileEx(sequenceFile);
            }
        }

        /// <summary>Primary entry sequence: Setup (init), Main (tests), Cleanup (shutdown) per NI TestStand conventions.</summary>
        static Sequence BuildMainSequence(Engine engine, string instrumentDll, TestStandSequenceGenerationSnapshot snapshot)
        {
            Sequence sequence = engine.NewSequence();
            sequence.Name = "MainSequence";
            sequence.Type = SequenceTypes.SeqType_Normal;

            ApplySnapshotParameters(sequence.Parameters, snapshot);
            AddNestedSweepLocals(sequence.Locals);

            const StepGroups setup = StepGroups.StepGroup_Setup;
            const StepGroups main = StepGroups.StepGroup_Main;
            const StepGroups cleanup = StepGroups.StepGroup_Cleanup;

            int s = 0;
            sequence.InsertStep(NewLabelStep(engine, "Initialize — load catalog and open results file"), s++, setup);

            Step prepare = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_Action);
            prepare.Name = "Prepare WLAN sweep (.NET)";
            TestStandInteropHelpers.ConfigureDotNetAction(
                prepare,
                instrumentDll,
                "WlanRfAmpTest.Instrument.WlanTestStandSequencer",
                "PrepareNestedSweep",
                new[]
                {
                    "Parameters." + TestStandWlanSequenceParameterNames.CatalogPath,
                    "Parameters." + TestStandWlanSequenceParameterNames.CsvPath,
                    "Parameters." + TestStandWlanSequenceParameterNames.ResourceName,
                    "Parameters." + TestStandWlanSequenceParameterNames.OptionsString,
                    "Parameters." + TestStandWlanSequenceParameterNames.IncludeBand24,
                    "Parameters." + TestStandWlanSequenceParameterNames.IncludeBand5,
                    "Parameters." + TestStandWlanSequenceParameterNames.Bw20,
                    "Parameters." + TestStandWlanSequenceParameterNames.Bw40,
                    "Parameters." + TestStandWlanSequenceParameterNames.Bw80,
                    "Parameters." + TestStandWlanSequenceParameterNames.StdAc,
                    "Parameters." + TestStandWlanSequenceParameterNames.StdAx,
                    "Parameters." + TestStandWlanSequenceParameterNames.RunCompositeEvmTxp,
                    "Parameters." + TestStandWlanSequenceParameterNames.RunSem,
                    "Parameters." + TestStandWlanSequenceParameterNames.SweepOrdering
                });
            sequence.InsertStep(prepare, s++, setup);

            int m = 0;
            string orderingNote = snapshot.SweepOrdering == TestSweepOrdering.FrequencyBandwidthStandard
                ? "frequency → bandwidth → standard"
                : "frequency → standard → bandwidth";
            sequence.InsertStep(NewLabelStep(engine, "Main — nested loops (" + orderingNote + ", matches Sequencer UI)"), m++, main);

            bool fbs = snapshot.SweepOrdering == TestSweepOrdering.FrequencyBandwidthStandard;

            Step forBand = engine.NewStep("", "NI_Flow_For");
            forBand.Name = "For each band";
            SetForExpressions(forBand, "Locals.BandIdx = 0", "Locals.BandIdx = Locals.BandIdx + 1",
                "Locals.BandIdx < Parameters." + TestStandWlanSequenceParameterNames.BandCount);
            sequence.InsertStep(forBand, m++, main);

            Step forFreq = engine.NewStep("", "NI_Flow_For");
            forFreq.Name = "For each center frequency";
            SetForExpressions(forFreq, "Locals.FreqIdx = 0", "Locals.FreqIdx = Locals.FreqIdx + 1",
                "Locals.FreqIdx < (Locals.BandIdx == 0 ? Parameters." + TestStandWlanSequenceParameterNames.FreqCountBand0 + " : Parameters." + TestStandWlanSequenceParameterNames.FreqCountBand1 + ")");
            sequence.InsertStep(forFreq, m++, main);

            if (fbs)
            {
                Step forBw = engine.NewStep("", "NI_Flow_For");
                forBw.Name = "For each channel bandwidth";
                SetForExpressions(forBw, "Locals.BwIdx = 0", "Locals.BwIdx = Locals.BwIdx + 1",
                    "Locals.BwIdx < Parameters." + TestStandWlanSequenceParameterNames.BwCount);
                sequence.InsertStep(forBw, m++, main);

                Step forStd = engine.NewStep("", "NI_Flow_For");
                forStd.Name = "For each WLAN standard";
                SetForExpressions(forStd, "Locals.StdIdx = 0", "Locals.StdIdx = Locals.StdIdx + 1",
                    "Locals.StdIdx < Parameters." + TestStandWlanSequenceParameterNames.StdCount);
                sequence.InsertStep(forStd, m++, main);

                m = InsertNestedPointSteps(engine, sequence, instrumentDll, main, m, "Locals.BwIdx", "Locals.StdIdx");

                sequence.InsertStep(engine.NewStep("", "NI_Flow_End"), m++, main);
                sequence.InsertStep(engine.NewStep("", "NI_Flow_End"), m++, main);
            }
            else
            {
                Step forStd = engine.NewStep("", "NI_Flow_For");
                forStd.Name = "For each WLAN standard";
                SetForExpressions(forStd, "Locals.StdIdx = 0", "Locals.StdIdx = Locals.StdIdx + 1",
                    "Locals.StdIdx < Parameters." + TestStandWlanSequenceParameterNames.StdCount);
                sequence.InsertStep(forStd, m++, main);

                Step forBw = engine.NewStep("", "NI_Flow_For");
                forBw.Name = "For each channel bandwidth";
                SetForExpressions(forBw, "Locals.BwIdx = 0", "Locals.BwIdx = Locals.BwIdx + 1",
                    "Locals.BwIdx < Parameters." + TestStandWlanSequenceParameterNames.BwCount);
                sequence.InsertStep(forBw, m++, main);

                m = InsertNestedPointSteps(engine, sequence, instrumentDll, main, m, "Locals.StdIdx", "Locals.BwIdx");

                sequence.InsertStep(engine.NewStep("", "NI_Flow_End"), m++, main);
                sequence.InsertStep(engine.NewStep("", "NI_Flow_End"), m++, main);
            }

            sequence.InsertStep(engine.NewStep("", "NI_Flow_End"), m++, main);
            sequence.InsertStep(engine.NewStep("", "NI_Flow_End"), m++, main);

            int c = 0;
            sequence.InsertStep(NewLabelStep(engine, "Cleanup — close results log (runs on pass, fail, or abort)"), c++, cleanup);

            Step finish = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_Action);
            finish.Name = "Finish WLAN sweep (.NET)";
            TestStandInteropHelpers.ConfigureDotNetAction(
                finish,
                instrumentDll,
                "WlanRfAmpTest.Instrument.WlanTestStandSequencer",
                "FinishNestedSweep",
                Array.Empty<string>());
            sequence.InsertStep(finish, c++, cleanup);

            return sequence;
        }

        /// <summary>Alternate subsequence: single .NET call for the full matrix (same parameters as MainSequence).</summary>
        static Sequence BuildWlanFullMatrixSubsequence(Engine engine, string instrumentDll, TestStandSequenceGenerationSnapshot snapshot)
        {
            Sequence sequence = engine.NewSequence();
            sequence.Name = "WLAN_FullMatrix";
            sequence.Type = SequenceTypes.SeqType_Normal;
            ApplySnapshotParameters(sequence.Parameters, snapshot);

            const StepGroups setup = StepGroups.StepGroup_Setup;
            const StepGroups main = StepGroups.StepGroup_Main;
            const StepGroups cleanup = StepGroups.StepGroup_Cleanup;

            sequence.InsertStep(NewLabelStep(engine, "Initialize — full matrix uses sequence Parameters below"), 0, setup);

            Step step = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_Action);
            step.Name = "Run complete WLAN matrix (.NET)";
            TestStandInteropHelpers.ConfigureDotNetAction(
                step,
                instrumentDll,
                "WlanRfAmpTest.Instrument.WlanTestStandSequencer",
                "RunFullMatrix",
                new[]
                {
                    "Parameters." + TestStandWlanSequenceParameterNames.CatalogPath,
                    "Parameters." + TestStandWlanSequenceParameterNames.CsvPath,
                    "Parameters." + TestStandWlanSequenceParameterNames.ResourceName,
                    "Parameters." + TestStandWlanSequenceParameterNames.OptionsString,
                    "Parameters." + TestStandWlanSequenceParameterNames.IncludeBand24,
                    "Parameters." + TestStandWlanSequenceParameterNames.IncludeBand5,
                    "Parameters." + TestStandWlanSequenceParameterNames.Bw20,
                    "Parameters." + TestStandWlanSequenceParameterNames.Bw40,
                    "Parameters." + TestStandWlanSequenceParameterNames.Bw80,
                    "Parameters." + TestStandWlanSequenceParameterNames.StdAc,
                    "Parameters." + TestStandWlanSequenceParameterNames.StdAx,
                    "Parameters." + TestStandWlanSequenceParameterNames.RunCompositeEvmTxp,
                    "Parameters." + TestStandWlanSequenceParameterNames.RunSem,
                    "Parameters." + TestStandWlanSequenceParameterNames.SweepOrdering
                });
            sequence.InsertStep(step, 0, main);

            sequence.InsertStep(NewLabelStep(engine, "Cleanup — no sequence-level teardown (module completes run)"), 0, cleanup);

            return sequence;
        }

        static Step NewLabelStep(Engine engine, string stepName)
        {
            Step label = engine.NewStep(AdapterKeyNames.NoneAdapterKeyName, StepTypes.StepType_Label);
            label.Name = stepName;
            return label;
        }

        static void ApplySnapshotParameters(PropertyObject parameters, TestStandSequenceGenerationSnapshot snapshot)
        {
            AddString(parameters, TestStandWlanSequenceParameterNames.CatalogPath, snapshot.CatalogPath ?? "");
            AddString(parameters, TestStandWlanSequenceParameterNames.CsvPath, snapshot.CsvPath ?? "");
            AddString(parameters, TestStandWlanSequenceParameterNames.ResourceName, snapshot.ResourceName ?? "");
            AddString(parameters, TestStandWlanSequenceParameterNames.OptionsString, snapshot.OptionsString ?? "");
            AddNumber(parameters, TestStandWlanSequenceParameterNames.IncludeBand24, snapshot.IncludeBand24 ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.IncludeBand5, snapshot.IncludeBand5 ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.Bw20, snapshot.Bw20 ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.Bw40, snapshot.Bw40 ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.Bw80, snapshot.Bw80 ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.StdAc, snapshot.StdAc ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.StdAx, snapshot.StdAx ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.RunCompositeEvmTxp, snapshot.RunCompositeEvmTxp ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.RunSem, snapshot.RunSem ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.SweepOrdering,
                snapshot.SweepOrdering == TestSweepOrdering.FrequencyBandwidthStandard ? 1 : 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.TotalPoints, snapshot.TotalPointCount);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.BandCount, snapshot.NestedBandCount);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.FreqCountBand0, snapshot.NestedFreqCountBand0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.FreqCountBand1, snapshot.NestedFreqCountBand1);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.StdCount, snapshot.NestedStdCount);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.BwCount, snapshot.NestedBwCount);

            AddNumber(parameters, TestStandWlanSequenceParameterNames.PointIndex, 0);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.CenterFrequencyHz, 2.412e9);
            AddNumber(parameters, TestStandWlanSequenceParameterNames.BandwidthMHz, 20);
            AddString(parameters, TestStandWlanSequenceParameterNames.StandardLabel, "802.11ac");
            AddString(parameters, TestStandWlanSequenceParameterNames.BandLabel, "2.4GHz");
            AddString(parameters, TestStandWlanSequenceParameterNames.WaveformPath, "");
        }

        static void AddNestedSweepLocals(PropertyObject locals)
        {
            AddNumber(locals, "BandIdx", 0);
            AddNumber(locals, "FreqIdx", 0);
            AddNumber(locals, "StdIdx", 0);
            AddNumber(locals, "BwIdx", 0);
        }

        /// <summary>Sync + EVM + TxP + SEM + CSV row inside innermost nested loops.</summary>
        static int InsertNestedPointSteps(
            Engine engine,
            Sequence sequence,
            string instrumentDll,
            StepGroups main,
            int m,
            string idxAExpr,
            string idxBExpr)
        {
            Step sync = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_Action);
            sync.Name = "Sync point from loop indices (.NET)";
            TestStandInteropHelpers.ConfigureDotNetAction(
                sync,
                instrumentDll,
                "WlanRfAmpTest.Instrument.WlanTestStandSequencer",
                "SyncPointFromNestedLoops",
                new[] { "Locals.BandIdx", "Locals.FreqIdx", idxAExpr, idxBExpr });
            sequence.InsertStep(sync, m++, main);

            const string wlanSeqClass = "WlanRfAmpTest.Instrument.WlanTestStandSequencer";

            Step evm = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_NumericMeasurement);
            evm.Name = "Measure EVM (.NET)";
            evm.Precondition = "Parameters." + TestStandWlanSequenceParameterNames.RunCompositeEvmTxp + " != 0";
            TestStandInteropHelpers.ConfigureDotNetNumericLimitTest(
                evm,
                instrumentDll,
                wlanSeqClass,
                "MeasureEvm",
                Array.Empty<string>(),
                limitLow: -200,
                limitHigh: 100,
                comparisonComp: "GELE",
                measurementUnits: "dB");
            sequence.InsertStep(evm, m++, main);

            Step txp = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_NumericMeasurement);
            txp.Name = "Measure TxP (.NET)";
            txp.Precondition = "Parameters." + TestStandWlanSequenceParameterNames.RunCompositeEvmTxp + " != 0";
            TestStandInteropHelpers.ConfigureDotNetNumericLimitTest(
                txp,
                instrumentDll,
                wlanSeqClass,
                "MeasureTxp",
                Array.Empty<string>(),
                limitLow: -150,
                limitHigh: 80,
                comparisonComp: "GELE",
                measurementUnits: "dBm");
            sequence.InsertStep(txp, m++, main);

            Step sem = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_NumericMeasurement);
            sem.Name = "Measure SEM (.NET)";
            sem.Precondition = "Parameters." + TestStandWlanSequenceParameterNames.RunSem + " != 0";
            TestStandInteropHelpers.ConfigureDotNetNumericLimitTest(
                sem,
                instrumentDll,
                wlanSeqClass,
                "MeasureSem",
                Array.Empty<string>(),
                limitLow: -500,
                limitHigh: 500,
                comparisonComp: "GELE",
                measurementUnits: "dB");
            sequence.InsertStep(sem, m++, main);

            Step log = engine.NewStep(AdapterKeyNames.DotNetAdapterKeyname, StepTypes.StepType_NumericMeasurement);
            log.Name = "Log point to CSV — aggregate pass (.NET)";
            TestStandInteropHelpers.ConfigureDotNetNumericLimitTest(
                log,
                instrumentDll,
                wlanSeqClass,
                "LogCurrentPointToCsv",
                Array.Empty<string>(),
                limitLow: 0.5,
                limitHigh: 1.5,
                comparisonComp: "GELE");
            sequence.InsertStep(log, m++, main);

            return m;
        }

        static Sequence BuildFlowControlDemoSequence(Engine engine)
        {
            Sequence sequence = engine.NewSequence();
            sequence.Name = "Demo_FlowControlSteps";
            sequence.Type = SequenceTypes.SeqType_Normal;
            AddNestedLocalsForDemo(sequence.Locals);

            const StepGroups setup = StepGroups.StepGroup_Setup;
            const StepGroups main = StepGroups.StepGroup_Main;
            const StepGroups cleanup = StepGroups.StepGroup_Cleanup;

            sequence.InsertStep(NewLabelStep(engine, "Reference — sample flow steps (conditions prevent real work)"), 0, setup);

            int ix = 0;

            Step whileStep = engine.NewStep("", "NI_Flow_While");
            whileStep.Name = "While (never enters)";
            TestStandInteropHelpers.TrySetStringPropertyRecursive(whileStep.AsPropertyObject(), "ConditionExpr", "0");
            sequence.InsertStep(whileStep, ix++, main);

            Step whileStmt = engine.NewStep("", StepTypes.StepType_Statement);
            whileStmt.Name = "While body (skipped)";
            TrySetStatementExpression(whileStmt);
            sequence.InsertStep(whileStmt, ix++, main);

            Step whileEnd = engine.NewStep("", "NI_Flow_End");
            whileEnd.Name = "End While";
            sequence.InsertStep(whileEnd, ix++, main);

            Step doWhile = engine.NewStep("", "NI_Flow_DoWhile");
            doWhile.Name = "Do While (runs once; condition false)";
            TestStandInteropHelpers.TrySetStringPropertyRecursive(doWhile.AsPropertyObject(), "ConditionExpr", "0");
            sequence.InsertStep(doWhile, ix++, main);

            Step doStmt = engine.NewStep("", StepTypes.StepType_Statement);
            doStmt.Name = "Do While body";
            TrySetStatementExpression(doStmt);
            sequence.InsertStep(doStmt, ix++, main);

            Step doEnd = engine.NewStep("", "NI_Flow_End");
            doEnd.Name = "End Do While";
            sequence.InsertStep(doEnd, ix++, main);

            Step forDemo = engine.NewStep("", "NI_Flow_For");
            forDemo.Name = "For (zero iterations)";
            SetForExpressions(forDemo, "Locals.BandIdx = 0", "Locals.BandIdx = Locals.BandIdx + 1", "Locals.BandIdx < 0");
            sequence.InsertStep(forDemo, ix++, main);

            Step forStmt = engine.NewStep("", StepTypes.StepType_Statement);
            forStmt.Name = "For body (skipped)";
            TrySetStatementExpression(forStmt);
            sequence.InsertStep(forStmt, ix++, main);

            Step forEnd = engine.NewStep("", "NI_Flow_End");
            forEnd.Name = "End For";
            sequence.InsertStep(forEnd, ix++, main);

            sequence.InsertStep(NewLabelStep(engine, "End of flow examples"), 0, cleanup);

            return sequence;
        }

        static void AddNestedLocalsForDemo(PropertyObject locals)
        {
            AddNumber(locals, "BandIdx", 0);
        }

        static void TrySetStatementExpression(Step statementStep)
        {
            foreach (string key in new[] { "Expression", "Expr", "StatementExpr" })
            {
                if (TestStandInteropHelpers.TrySetStringPropertyRecursive(statementStep.AsPropertyObject(), key, ""))
                    return;
            }
        }

        static void SetForExpressions(Step forStep, string init, string inc, string cond)
        {
            TestStandInteropHelpers.TrySetStringPropertyRecursive(forStep.AsPropertyObject(), "InitializationExpr", init);
            TestStandInteropHelpers.TrySetStringPropertyRecursive(forStep.AsPropertyObject(), "IncrementExpr", inc);
            TestStandInteropHelpers.TrySetStringPropertyRecursive(forStep.AsPropertyObject(), "ConditionExpr", cond);
        }
    }
}
