namespace WlanRfAmpTest.Core
{
    /// <summary>Uniform-frequency trace (e.g. SEM spectrum, mask) in Hz vs dB-like units from RFmx.</summary>
    public sealed class RfmxSpectrumTrace
    {
        public double StartFrequencyHz { get; set; }
        public double FrequencyStepHz { get; set; }
        public double[] Amplitudes { get; set; } = System.Array.Empty<double>();
    }

    /// <summary>Uniform-time trace (e.g. TxP power vs time).</summary>
    public sealed class RfmxTimeTrace
    {
        public double StartTimeSec { get; set; }
        public double SampleSpacingSec { get; set; }
        public double[] Values { get; set; } = System.Array.Empty<double>();
    }

    /// <summary>I/Q scatter (e.g. OFDM ModAcc constellation).</summary>
    public sealed class RfmxConstellationTrace
    {
        public double[] I { get; set; } = System.Array.Empty<double>();
        public double[] Q { get; set; } = System.Array.Empty<double>();
    }

    /// <summary>Trace data copied from RFmx after a standalone measurement (no NI types).</summary>
    public sealed class WlanRfmxTraceSnapshot
    {
        public RfmxTimeTrace? EvmPerSubcarrierDb { get; set; }
        public RfmxConstellationTrace? PilotConstellation { get; set; }
        public RfmxConstellationTrace? DataConstellation { get; set; }
        public RfmxSpectrumTrace? SemSpectrum { get; set; }
        public RfmxSpectrumTrace? SemCompositeMask { get; set; }
        public RfmxTimeTrace? TxpPowerDbm { get; set; }

        /// <summary>Non-fatal trace fetch issues (measurement scalar results may still be valid).</summary>
        public string? TraceFetchNote { get; set; }
    }
}
