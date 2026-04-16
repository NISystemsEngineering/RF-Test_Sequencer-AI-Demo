namespace WlanRfAmpTest.Mds
{
    /// <summary>JSON payload for Measurement Data Services (matches CSV row semantics).</summary>
    public sealed class MeasurementRowPayload
    {
        public DateTime TimestampUtc { get; set; }
        public int TestIndex { get; set; }
        public string Band { get; set; } = "";
        public double CenterFrequencyHz { get; set; }
        public string Standard { get; set; } = "";
        public int BandwidthMHz { get; set; }
        public string WaveformPath { get; set; } = "";
        public double? EvmRmsDb { get; set; }
        public double? DataEvmRmsDb { get; set; }
        public double? PilotEvmRmsDb { get; set; }
        public double? TxpAverageDbm { get; set; }
        public double? TxpPeakDbm { get; set; }
        public string? SemMeasurementStatus { get; set; }
        public double? SemMinMarginDb { get; set; }
        public bool Pass { get; set; }
        public string? Error { get; set; }
    }
}
