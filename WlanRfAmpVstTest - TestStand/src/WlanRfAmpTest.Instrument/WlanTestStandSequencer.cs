using System;
using System.Collections.Generic;
using System.Threading;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>Entry points for TestStand .NET Adapter steps (sweep in the sequence file; measurements as separate modules).</summary>
    public static class WlanTestStandSequencer
    {
        static readonly object NestedLock = new object();
        static WaveformCatalog _catalog;
        static List<int> _bws;
        static List<WlanStandardKind> _stds;
        static bool _include24;
        static bool _include5;
        static bool _orderingFbs;
        static CsvResultLogger _nestedLogger;
        static WlanRfInstrumentConfig _nestedCfg;
        static bool _runEvm;
        static bool _runTxp;
        static bool _runSem;
        static TestPoint _currentPoint;
        static WlanPointMeasurementResult _acc;
        static readonly WlanStandaloneMeasurement Standalone = new WlanStandaloneMeasurement();

        /// <summary>Runs the full matrix in one call (matches WinForms / headless sequencer without TestStand hooks).</summary>
        public static void RunFullMatrix(
            string catalogPath,
            string csvPath,
            string resourceName,
            string optionsString,
            double band24,
            double band5,
            double bw20,
            double bw40,
            double bw80,
            double stdAc,
            double stdAx,
            double runEvmTxp,
            double runSem,
            double sweepOrdering)
        {
            var wave = WaveformCatalog.FromJsonFile(catalogPath);
            List<TestPoint> plan = BuildPlan(wave, band24, band5, bw20, bw40, bw80, stdAc, stdAx, sweepOrdering);
            var cfg = new WlanRfInstrumentConfig
            {
                ResourceName = resourceName ?? "",
                OptionsString = optionsString ?? ""
            };
            var opts = new SequencerMeasurementOptions
            {
                RunCompositeEvmTxp = runEvmTxp != 0,
                RunSem = runSem != 0
            };
            if (!opts.IsValid)
                throw new InvalidOperationException("Select at least one measurement (EVM+TxP and/or SEM).");

            WlanMeasurementSweepRunner.Run(
                plan,
                cfg,
                opts,
                csvPath,
                CancellationToken.None);
        }

        /// <summary>Loads the waveform catalog, opens the CSV, and stores sweep axes (loops live in the TestStand sequence).</summary>
        public static void PrepareNestedSweep(
            string catalogPath,
            string csvPath,
            string resourceName,
            string optionsString,
            double band24,
            double band5,
            double bw20,
            double bw40,
            double bw80,
            double stdAc,
            double stdAx,
            double runEvmTxp,
            double runSem,
            double sweepOrdering)
        {
            lock (NestedLock)
            {
                _catalog = WaveformCatalog.FromJsonFile(catalogPath);
                _bws = CollectBws(bw20, bw40, bw80);
                _stds = CollectStds(stdAc, stdAx);
                _include24 = band24 != 0;
                _include5 = band5 != 0;
                _orderingFbs = sweepOrdering != 0;

                if (!_include24 && !_include5)
                    throw new InvalidOperationException("Select at least one RF band (2.4 GHz and/or 5 GHz).");
                if (_bws.Count == 0)
                    throw new InvalidOperationException("Select at least one channel bandwidth (20 / 40 / 80 MHz).");
                if (_stds.Count == 0)
                    throw new InvalidOperationException("Select at least one WLAN standard (802.11ac and/or 802.11ax).");

                _runEvm = runEvmTxp != 0;
                _runTxp = runEvmTxp != 0;
                _runSem = runSem != 0;
                if (!_runEvm && !_runTxp && !_runSem)
                    throw new InvalidOperationException("Select at least one measurement (EVM, TxP, and/or SEM).");

                _nestedCfg = new WlanRfInstrumentConfig
                {
                    ResourceName = resourceName ?? "",
                    OptionsString = optionsString ?? ""
                };

                _nestedLogger?.Dispose();
                _nestedLogger = new CsvResultLogger(csvPath, append: false);
                _currentPoint = null;
                _acc = new WlanPointMeasurementResult();
            }
        }

        /// <summary>
        /// Resolves the current matrix point from nested loop indices. Default ordering: <paramref name="idxA"/> = standard index,
        /// <paramref name="idxB"/> = bandwidth index. FBS ordering: <paramref name="idxA"/> = bandwidth index,
        /// <paramref name="idxB"/> = standard index (must match <see cref="PrepareNestedSweep"/> sweep ordering).
        /// </summary>
        public static void SyncPointFromNestedLoops(double bandIdx, double freqIdx, double idxA, double idxB)
        {
            lock (NestedLock)
            {
                EnsurePrepared();
                int b = (int)bandIdx;
                int f = (int)freqIdx;
                int a = (int)idxA;
                int c = (int)idxB;

                TestPoint pt;
                bool ok;
                if (_orderingFbs)
                    ok = TestPlanBuilder.TryBuildPointFromNestedIndicesFbs(
                        _catalog, _include24, _include5, _bws, _stds, b, f, a, c, out _, out pt);
                else
                    ok = TestPlanBuilder.TryBuildPointFromNestedIndices(
                        _catalog, _include24, _include5, _bws, _stds, b, f, a, c, out _, out pt);

                if (!ok)
                    throw new InvalidOperationException("Nested loop indices are out of range for the current sweep.");

                _currentPoint = pt;
                _acc = new WlanPointMeasurementResult();
            }
        }

        /// <summary>EVM-only measurement (OFDM ModAcc) for the point set by <see cref="SyncPointFromNestedLoops"/>.</summary>
        /// <returns>Composite RMS EVM (dB) for TestStand Numeric Limit Test / reports.</returns>
        public static double MeasureEvm()
        {
            lock (NestedLock)
            {
                EnsurePrepared();
                EnsurePoint();
                if (!_runEvm)
                    return double.NaN;

                WlanPointMeasurementResult r = Standalone.Run(_currentPoint, _nestedCfg, StandaloneMeasurementKind.Evm, CancellationToken.None);
                _acc.CompositeRmsEvmDb = r.CompositeRmsEvmDb;
                _acc.CompositeDataRmsEvmDb = r.CompositeDataRmsEvmDb;
                _acc.CompositePilotRmsEvmDb = r.CompositePilotRmsEvmDb;
                _acc.Traces = r.Traces;
                return r.CompositeRmsEvmDb;
            }
        }

        /// <summary>Tx power measurement for the point set by <see cref="SyncPointFromNestedLoops"/>.</summary>
        /// <returns>Average power (dBm) for TestStand Numeric Limit Test / reports.</returns>
        public static double MeasureTxp()
        {
            lock (NestedLock)
            {
                EnsurePrepared();
                EnsurePoint();
                if (!_runTxp)
                    return double.NaN;

                WlanPointMeasurementResult r = Standalone.Run(_currentPoint, _nestedCfg, StandaloneMeasurementKind.Txp, CancellationToken.None);
                _acc.AveragePowerDbm = r.AveragePowerDbm;
                _acc.PeakPowerDbm = r.PeakPowerDbm;
                if (_acc.Traces == null)
                    _acc.Traces = r.Traces;
                return r.AveragePowerDbm;
            }
        }

        /// <summary>SEM measurement for the point set by <see cref="SyncPointFromNestedLoops"/>.</summary>
        /// <returns>Minimum SEM margin (dB) for TestStand Numeric Limit Test / reports.</returns>
        public static double MeasureSem()
        {
            lock (NestedLock)
            {
                EnsurePrepared();
                EnsurePoint();
                if (!_runSem)
                    return double.NaN;

                WlanPointMeasurementResult r = Standalone.Run(_currentPoint, _nestedCfg, StandaloneMeasurementKind.Sem, CancellationToken.None);
                _acc.SemStatus = r.SemStatus;
                _acc.SemMinMarginDb = r.SemMinMarginDb;
                if (_acc.Traces == null)
                    _acc.Traces = r.Traces;
                return r.SemMinMarginDb;
            }
        }

        /// <summary>Writes one CSV row for the current point using accumulated EVM / TxP / SEM results.</summary>
        /// <returns>1.0 if the point passes aggregate checks, 0.0 otherwise (Numeric Limit Test expects 1.0 in [0.5, 1.5]).</returns>
        public static double LogCurrentPointToCsv()
        {
            lock (NestedLock)
            {
                EnsurePrepared();
                EnsurePoint();

                var row = new MeasurementRow
                {
                    TimestampUtc = DateTime.UtcNow,
                    TestIndex = _currentPoint.Index,
                    Band = _currentPoint.BandLabel,
                    CenterFrequencyHz = _currentPoint.CenterFrequencyHz,
                    Standard = _currentPoint.StandardLabel,
                    BandwidthMHz = _currentPoint.BandwidthMHz,
                    WaveformPath = _currentPoint.WaveformFilePath,
                    Pass = false
                };

                try
                {
                    if (_runEvm)
                    {
                        row.EvmRmsDb = _acc.CompositeRmsEvmDb;
                    }
                    else
                    {
                        row.EvmRmsDb = null;
                    }

                    if (_runTxp)
                    {
                        row.TxpAverageDbm = _acc.AveragePowerDbm;
                        row.TxpPeakDbm = _acc.PeakPowerDbm;
                    }
                    else
                    {
                        row.TxpAverageDbm = null;
                        row.TxpPeakDbm = null;
                    }

                    if (_runSem)
                    {
                        row.SemMeasurementStatus = _acc.SemStatus.ToString();
                        row.SemMinMarginDb = _acc.SemMinMarginDb;
                    }
                    else
                    {
                        row.SemMeasurementStatus = "NotRun";
                        row.SemMinMarginDb = null;
                    }

                    row.Pass = EvaluateAccumulatedPass(_acc, _runEvm, _runTxp, _runSem);
                    row.Error = null;
                    _nestedLogger.WriteRow(row,
                        _runEvm ? _acc.CompositeDataRmsEvmDb : null,
                        _runEvm ? _acc.CompositePilotRmsEvmDb : null);
                    return row.Pass ? 1.0 : 0.0;
                }
                catch (Exception ex)
                {
                    row.Error = ex.Message;
                    row.Pass = false;
                    _nestedLogger.WriteRow(row, null, null);
                    return 0.0;
                }
            }
        }

        /// <summary>Closes the CSV opened in <see cref="PrepareNestedSweep"/>.</summary>
        public static void FinishNestedSweep()
        {
            lock (NestedLock)
            {
                _nestedLogger?.Dispose();
                _nestedLogger = null;
                _catalog = null;
                _bws = null;
                _stds = null;
                _currentPoint = null;
                _acc = null;
            }
        }

        static void EnsurePrepared()
        {
            if (_nestedLogger == null || _catalog == null)
                throw new InvalidOperationException("Call PrepareNestedSweep before other WLAN TestStand steps.");
        }

        static void EnsurePoint()
        {
            if (_currentPoint == null)
                throw new InvalidOperationException("Call SyncPointFromNestedLoops before measurement steps.");
        }

        static List<TestPoint> BuildPlan(
            WaveformCatalog wave,
            double band24,
            double band5,
            double bw20,
            double bw40,
            double bw80,
            double stdAc,
            double stdAx,
            double sweepOrdering)
        {
            var bws = CollectBws(bw20, bw40, bw80);
            var stds = CollectStds(stdAc, stdAx);

            IReadOnlyList<TestPoint> plan = TestPlanBuilder.Build(wave, band24 != 0, band5 != 0, bws, stds);
            if (sweepOrdering != 0)
                plan = TestPlanBuilder.ApplyOrdering(plan, TestSweepOrdering.FrequencyBandwidthStandard);
            return new List<TestPoint>(plan);
        }

        static List<int> CollectBws(double bw20, double bw40, double bw80)
        {
            var bws = new List<int>();
            if (bw20 != 0)
                bws.Add(20);
            if (bw40 != 0)
                bws.Add(40);
            if (bw80 != 0)
                bws.Add(80);
            return bws;
        }

        static List<WlanStandardKind> CollectStds(double stdAc, double stdAx)
        {
            var stds = new List<WlanStandardKind>();
            if (stdAc != 0)
                stds.Add(WlanStandardKind.IEEE802_11ac);
            if (stdAx != 0)
                stds.Add(WlanStandardKind.IEEE802_11ax);
            return stds;
        }

        static bool EvaluateAccumulatedPass(WlanPointMeasurementResult r, bool runEvm, bool runTxp, bool runSem)
        {
            if (runEvm)
            {
                if (double.IsNaN(r.CompositeRmsEvmDb) || double.IsInfinity(r.CompositeRmsEvmDb))
                    return false;
            }

            if (runTxp)
            {
                if (double.IsNaN(r.AveragePowerDbm) || double.IsInfinity(r.AveragePowerDbm))
                    return false;
            }

            if (runSem)
            {
                string sem = r.SemStatus.ToString();
                if (sem.IndexOf("Fail", StringComparison.OrdinalIgnoreCase) >= 0)
                    return false;
                if (double.IsNaN(r.SemMinMarginDb) || double.IsInfinity(r.SemMinMarginDb))
                    return false;
            }

            return true;
        }
    }
}
