using System;
using System.Collections.Generic;
using System.IO;

namespace WlanRfAmpTest.Core
{
    /// <summary>Paths and sweep options used when generating a TestStand <c>.seq</c> from the sequencer UI (or CLI).</summary>
    public sealed class TestStandSequenceGenerationSnapshot
    {
        public string CatalogPath { get; set; } = "";

        public string CsvPath { get; set; } = "";

        public string ResourceName { get; set; } = "5841";

        public string OptionsString { get; set; } = "";

        public bool IncludeBand24 { get; set; } = true;

        public bool IncludeBand5 { get; set; } = true;

        public bool Bw20 { get; set; } = true;

        public bool Bw40 { get; set; } = true;

        public bool Bw80 { get; set; } = true;

        public bool StdAc { get; set; } = true;

        public bool StdAx { get; set; } = true;

        public bool RunCompositeEvmTxp { get; set; } = true;

        public bool RunSem { get; set; } = true;

        public TestSweepOrdering SweepOrdering { get; set; } = TestSweepOrdering.Default;

        /// <summary>Point count for the flat TestStand loop; set by <see cref="TryComputeTotalPointCount"/>.</summary>
        public int TotalPointCount { get; set; }

        /// <summary>Nested loop bounds for TestStand sequences (set with <see cref="TryComputeTotalPointCount"/>).</summary>
        public int NestedBandCount { get; set; }

        public int NestedFreqCountBand0 { get; set; }

        public int NestedFreqCountBand1 { get; set; }

        public int NestedStdCount { get; set; }

        public int NestedBwCount { get; set; }

        public static TestStandSequenceGenerationSnapshot CreateTemplateDefaults()
        {
            return new TestStandSequenceGenerationSnapshot
            {
                CatalogPath = @"C:\path\to\waveforms.json",
                CsvPath = @"C:\path\to\results.csv",
                ResourceName = "5841",
                OptionsString = "",
                IncludeBand24 = true,
                IncludeBand5 = true,
                Bw20 = true,
                Bw40 = true,
                Bw80 = true,
                StdAc = true,
                StdAx = true,
                RunCompositeEvmTxp = true,
                RunSem = true,
                SweepOrdering = TestSweepOrdering.Default,
                TotalPointCount = 0
            };
        }

        public bool TryComputeTotalPointCount(out int count, out string errorMessage)
        {
            count = 0;
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(CatalogPath) || !File.Exists(CatalogPath))
            {
                errorMessage = "Waveform catalog file not found.";
                return false;
            }

            if (!IncludeBand24 && !IncludeBand5)
            {
                errorMessage = "Select at least one RF band (2.4 GHz and/or 5 GHz).";
                return false;
            }

            if (!Bw20 && !Bw40 && !Bw80)
            {
                errorMessage = "Select at least one channel bandwidth (20 / 40 / 80 MHz).";
                return false;
            }

            if (!StdAc && !StdAx)
            {
                errorMessage = "Select at least one WLAN standard (802.11ac and/or 802.11ax).";
                return false;
            }

            if (!RunCompositeEvmTxp && !RunSem)
            {
                errorMessage = "Select at least one measurement (EVM + TxP and/or SEM).";
                return false;
            }

            try
            {
                var cat = WaveformCatalog.FromJsonFile(CatalogPath);
                IReadOnlyList<int> bws = CollectBandwidths(Bw20, Bw40, Bw80);
                IReadOnlyList<WlanStandardKind> stds = CollectStandards(StdAc, StdAx);
                IReadOnlyList<TestPoint> plan = TestPlanBuilder.Build(cat, IncludeBand24, IncludeBand5, bws, stds);
                if (SweepOrdering == TestSweepOrdering.FrequencyBandwidthStandard)
                    plan = TestPlanBuilder.ApplyOrdering(plan, TestSweepOrdering.FrequencyBandwidthStandard);
                count = plan.Count;
                if (count == 0)
                {
                    errorMessage = "No test points match the current sweep selection.";
                    return false;
                }

                var bands = TestPlanBuilder.BandsInSweepOrder(IncludeBand24, IncludeBand5);
                NestedBandCount = bands.Count;
                NestedFreqCountBand0 = bands.Count > 0
                    ? TestPlanBuilder.FrequencyCountForBandOrdinal(IncludeBand24, IncludeBand5, 0)
                    : 0;
                NestedFreqCountBand1 = bands.Count > 1
                    ? TestPlanBuilder.FrequencyCountForBandOrdinal(IncludeBand24, IncludeBand5, 1)
                    : 0;
                NestedStdCount = CollectStandards(StdAc, StdAx).Count;
                NestedBwCount = CollectBandwidths(Bw20, Bw40, Bw80).Count;

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        static List<int> CollectBandwidths(bool bw20, bool bw40, bool bw80)
        {
            var list = new List<int>();
            if (bw20)
                list.Add(20);
            if (bw40)
                list.Add(40);
            if (bw80)
                list.Add(80);
            return list;
        }

        static List<WlanStandardKind> CollectStandards(bool ac, bool ax)
        {
            var list = new List<WlanStandardKind>();
            if (ac)
                list.Add(WlanStandardKind.IEEE802_11ac);
            if (ax)
                list.Add(WlanStandardKind.IEEE802_11ax);
            return list;
        }
    }
}
