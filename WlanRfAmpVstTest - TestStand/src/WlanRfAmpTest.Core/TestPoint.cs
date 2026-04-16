using System;

namespace WlanRfAmpTest.Core
{
    /// <summary>One row in the sweep: frequency, standard, bandwidth, and resolved TDMS path.</summary>
    public sealed class TestPoint
    {
        public TestPoint(int index, RfBand band, double centerFrequencyHz, WlanStandardKind standard, int bandwidthMHz, string waveformFilePath)
        {
            Index = index;
            Band = band;
            CenterFrequencyHz = centerFrequencyHz;
            Standard = standard;
            BandwidthMHz = bandwidthMHz;
            WaveformFilePath = waveformFilePath ?? throw new ArgumentNullException(nameof(waveformFilePath));
        }

        public int Index { get; }
        public RfBand Band { get; }
        public double CenterFrequencyHz { get; }
        public WlanStandardKind Standard { get; }
        public int BandwidthMHz { get; }
        public string WaveformFilePath { get; }

        public string StandardLabel => Standard == WlanStandardKind.IEEE802_11ac ? "802.11ac" : "802.11ax";

        public string BandLabel => Band == RfBand.Band2_4GHz ? "2.4GHz" : "5GHz";

        public string MatrixKey => $"{BandLabel}_{StandardLabel}_{BandwidthMHz}MHz";
    }
}
