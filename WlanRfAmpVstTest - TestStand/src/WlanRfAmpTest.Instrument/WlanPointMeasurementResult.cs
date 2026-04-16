using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    public sealed class WlanPointMeasurementResult
    {
        public double CompositeRmsEvmDb { get; set; }
        public double CompositeDataRmsEvmDb { get; set; }
        public double CompositePilotRmsEvmDb { get; set; }
        public double AveragePowerDbm { get; set; }
        public double PeakPowerDbm { get; set; }
        public RFmxWlanMXSemMeasurementStatus SemStatus { get; set; }
        public double SemMinMarginDb { get; set; }

        /// <summary>For UI / logging without referencing RFmx from the host app.</summary>
        public string SemStatusText => SemStatus.ToString();

        /// <summary>RFmx traces copied after measurement (optional).</summary>
        public WlanRfmxTraceSnapshot? Traces { get; set; }
    }
}
