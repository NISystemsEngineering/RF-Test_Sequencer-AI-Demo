using System;
using System.Collections.Generic;
using System.Globalization;

namespace WlanRfAmpTest.Core
{
    /// <summary>Controls nested-loop order for the measurement matrix (test-time tradeoffs).</summary>
    public enum TestSweepOrdering
    {
        /// <summary>Per band: center frequency, then 802.11ac / 802.11ax, then 20 / 40 / 80 MHz (matches nested loop in <see cref="TestPlanBuilder"/>).</summary>
        Default,
        /// <summary>Per band: center frequency, then channel bandwidth, then standard — keeps LO on one frequency while stepping bandwidth (often fewer RFmx standard switches between adjacent rows).</summary>
        FrequencyBandwidthStandard
    }

    public static class TestPlanBuilder
    {
        public const double StepHz = 20e6;

        public static IReadOnlyList<double> FrequenciesForBand(RfBand band)
        {
            double start = band == RfBand.Band2_4GHz ? 2.4e9 : 5.0e9;
            double stop = band == RfBand.Band2_4GHz ? 2.6e9 : 5.2e9;
            var list = new List<double>();
            for (double f = start; f <= stop + 1; f += StepHz)
            {
                if (f > stop + 0.5 * StepHz)
                    break;
                list.Add(f);
            }
            return list;
        }

        public static IReadOnlyList<int> DefaultBandwidthsMHz { get; } = new[] { 20, 40, 80 };

        public static IReadOnlyList<WlanStandardKind> DefaultStandards { get; } = new[]
        {
            WlanStandardKind.IEEE802_11ac,
            WlanStandardKind.IEEE802_11ax
        };

        public static IReadOnlyList<TestPoint> Build(WaveformCatalog catalog, bool includeBand2_4 = true, bool includeBand5 = true)
        {
            return Build(catalog, includeBand2_4, includeBand5, DefaultBandwidthsMHz, DefaultStandards);
        }

        public static IReadOnlyList<TestPoint> Build(
            WaveformCatalog catalog,
            bool includeBand2_4,
            bool includeBand5,
            IReadOnlyList<int> bandwidthsMHz,
            IReadOnlyList<WlanStandardKind> standards)
        {
            bandwidthsMHz ??= DefaultBandwidthsMHz;
            standards ??= DefaultStandards;
            var points = new List<TestPoint>();
            int idx = 0;
            if (includeBand2_4)
                idx = AppendBand(points, idx, RfBand.Band2_4GHz, catalog, bandwidthsMHz, standards);
            if (includeBand5)
                idx = AppendBand(points, idx, RfBand.Band5GHz, catalog, bandwidthsMHz, standards);
            return points;
        }

        static int AppendBand(
            List<TestPoint> points,
            int startIndex,
            RfBand band,
            WaveformCatalog catalog,
            IReadOnlyList<int> bandwidthsMHz,
            IReadOnlyList<WlanStandardKind> standards)
        {
            int idx = startIndex;
            foreach (double fc in FrequenciesForBand(band))
            {
                foreach (var std in standards)
                {
                    foreach (int bw in bandwidthsMHz)
                    {
                        string key = WaveformCatalog.KeyFor(band, std, bw);
                        if (!catalog.TryGetPath(key, out var path) || string.IsNullOrWhiteSpace(path))
                            throw new InvalidOperationException(
                                string.Format(CultureInfo.InvariantCulture,
                                    "Waveform catalog has no entry for matrix key '{0}'. Add it to waveforms.json.", key));
                        points.Add(new TestPoint(idx, band, fc, std, bw, path.Trim()));
                        idx++;
                    }
                }
            }
            return idx;
        }

        /// <summary>Reorders and reindexes points for a chosen sweep strategy (same matrix, different visit order).</summary>
        public static IReadOnlyList<TestPoint> ApplyOrdering(IReadOnlyList<TestPoint> plan, TestSweepOrdering ordering)
        {
            if (plan.Count == 0 || ordering == TestSweepOrdering.Default)
                return plan;
            var list = new List<TestPoint>(plan);
            list.Sort(CompareFrequencyBandwidthStandard);
            for (int i = 0; i < list.Count; i++)
            {
                TestPoint p = list[i];
                list[i] = new TestPoint(i, p.Band, p.CenterFrequencyHz, p.Standard, p.BandwidthMHz, p.WaveformFilePath);
            }
            return list;
        }

        static int CompareFrequencyBandwidthStandard(TestPoint a, TestPoint b)
        {
            int c = a.Band.CompareTo(b.Band);
            if (c != 0)
                return c;
            c = a.CenterFrequencyHz.CompareTo(b.CenterFrequencyHz);
            if (c != 0)
                return c;
            c = a.BandwidthMHz.CompareTo(b.BandwidthMHz);
            if (c != 0)
                return c;
            return a.Standard.CompareTo(b.Standard);
        }

        /// <summary>Ordered bands for nested loops (2.4 GHz first when enabled), matching <see cref="Build"/>.</summary>
        public static IReadOnlyList<RfBand> BandsInSweepOrder(bool includeBand2_4, bool includeBand5)
        {
            var bands = new List<RfBand>(2);
            if (includeBand2_4)
                bands.Add(RfBand.Band2_4GHz);
            if (includeBand5)
                bands.Add(RfBand.Band5GHz);
            return bands;
        }

        /// <summary>
        /// Builds the <see cref="TestPoint"/> for nested loop indices in the same order as
        /// <c>foreach frequency → foreach standard → foreach bandwidth</c> per band in <see cref="BandsInSweepOrder"/>.
        /// </summary>
        public static bool TryBuildPointFromNestedIndices(
            WaveformCatalog catalog,
            bool includeBand2_4,
            bool includeBand5,
            IReadOnlyList<int> bandwidthsMHz,
            IReadOnlyList<WlanStandardKind> standards,
            int bandOrdinal,
            int freqIdx,
            int stdIdx,
            int bwIdx,
            out int flatIndex,
            out TestPoint point)
        {
            var bands = BandsInSweepOrder(includeBand2_4, includeBand5);
            bandwidthsMHz ??= DefaultBandwidthsMHz;
            standards ??= DefaultStandards;
            flatIndex = 0;
            point = null;

            if (bands.Count == 0 || catalog == null)
                return false;
            if (bandOrdinal < 0 || bandOrdinal >= bands.Count)
                return false;
            if (stdIdx < 0 || stdIdx >= standards.Count || bwIdx < 0 || bwIdx >= bandwidthsMHz.Count)
                return false;

            RfBand band = bands[bandOrdinal];
            IReadOnlyList<double> freqs = FrequenciesForBand(band);
            if (freqIdx < 0 || freqIdx >= freqs.Count)
                return false;

            int stdCount = standards.Count;
            int bwCount = bandwidthsMHz.Count;

            int idx = 0;
            for (int b = 0; b < bandOrdinal; b++)
            {
                idx += FrequenciesForBand(bands[b]).Count * stdCount * bwCount;
            }

            idx += freqIdx * (stdCount * bwCount) + stdIdx * bwCount + bwIdx;
            flatIndex = idx;

            double fc = freqs[freqIdx];
            var std = standards[stdIdx];
            int bw = bandwidthsMHz[bwIdx];
            string key = WaveformCatalog.KeyFor(band, std, bw);
            if (!catalog.TryGetPath(key, out var path) || string.IsNullOrWhiteSpace(path))
            {
                throw new InvalidOperationException(
                    string.Format(CultureInfo.InvariantCulture,
                        "Waveform catalog has no entry for matrix key '{0}'. Add it to waveforms.json.", key));
            }

            point = new TestPoint(idx, band, fc, std, bw, path.Trim());
            return true;
        }

        public static int FrequencyCountForBandOrdinal(bool includeBand2_4, bool includeBand5, int bandOrdinal)
        {
            var bands = BandsInSweepOrder(includeBand2_4, includeBand5);
            if (bandOrdinal < 0 || bandOrdinal >= bands.Count)
                return 0;
            return FrequenciesForBand(bands[bandOrdinal]).Count;
        }

        /// <summary>
        /// Nested-loop order: per band, center frequency → bandwidth → standard (matches <see cref="ApplyOrdering"/> with
        /// <see cref="TestSweepOrdering.FrequencyBandwidthStandard"/>).
        /// </summary>
        public static bool TryBuildPointFromNestedIndicesFbs(
            WaveformCatalog catalog,
            bool includeBand2_4,
            bool includeBand5,
            IReadOnlyList<int> bandwidthsMHz,
            IReadOnlyList<WlanStandardKind> standards,
            int bandOrdinal,
            int freqIdx,
            int bwIdx,
            int stdIdx,
            out int flatIndex,
            out TestPoint point)
        {
            var bands = BandsInSweepOrder(includeBand2_4, includeBand5);
            bandwidthsMHz ??= DefaultBandwidthsMHz;
            standards ??= DefaultStandards;
            flatIndex = 0;
            point = null;

            if (bands.Count == 0 || catalog == null)
                return false;
            if (bandOrdinal < 0 || bandOrdinal >= bands.Count)
                return false;
            if (stdIdx < 0 || stdIdx >= standards.Count || bwIdx < 0 || bwIdx >= bandwidthsMHz.Count)
                return false;

            RfBand band = bands[bandOrdinal];
            IReadOnlyList<double> freqs = FrequenciesForBand(band);
            if (freqIdx < 0 || freqIdx >= freqs.Count)
                return false;

            int stdCount = standards.Count;
            int bwCount = bandwidthsMHz.Count;

            int idx = 0;
            for (int b = 0; b < bandOrdinal; b++)
            {
                idx += FrequenciesForBand(bands[b]).Count * bwCount * stdCount;
            }

            idx += freqIdx * (bwCount * stdCount) + bwIdx * stdCount + stdIdx;
            flatIndex = idx;

            double fc = freqs[freqIdx];
            int bw = bandwidthsMHz[bwIdx];
            var std = standards[stdIdx];
            string key = WaveformCatalog.KeyFor(band, std, bw);
            if (!catalog.TryGetPath(key, out var path) || string.IsNullOrWhiteSpace(path))
            {
                throw new InvalidOperationException(
                    string.Format(CultureInfo.InvariantCulture,
                        "Waveform catalog has no entry for matrix key '{0}'. Add it to waveforms.json.", key));
            }

            point = new TestPoint(idx, band, fc, std, bw, path.Trim());
            return true;
        }
    }
}
