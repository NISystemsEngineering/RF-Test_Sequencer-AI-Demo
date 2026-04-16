using NationalInstruments.ModularInstruments.NIRfsg;
using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.WlanMX;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>Shared acquisition and generation settings for VST loopback (RFmx WLAN + NI-RFSG playback).</summary>
    public sealed class WlanRfInstrumentConfig
    {
        public string ResourceName { get; set; } = "5841";
        public string OptionsString { get; set; } = "";
        public double FrequencyReferenceHz { get; set; } = 10e6;
        public string FrequencyReferenceSource { get; set; } = RFmxInstrMXConstants.OnboardClock;
        public RfsgFrequencyReferenceSource RfsgFrequencyReferenceSource { get; set; } = RfsgFrequencyReferenceSource.OnboardClock;

        public double RfsgPowerDbm { get; set; } = -10.0;
        public double ExternalAttenuationDb { get; set; } = 0.0;
        public double ReferenceLevelDbm { get; set; } = 0.0;

        public bool IqPowerEdgeTriggerEnabled { get; set; } = true;
        public double IqPowerEdgeLevelDb { get; set; } = -20.0;
        public double TriggerDelaySec { get; set; } = 0.0;
        public RFmxWlanMXTriggerMinimumQuietTimeMode MinimumQuietTimeMode { get; set; } =
            RFmxWlanMXTriggerMinimumQuietTimeMode.Auto;
        public double MinimumQuietTimeSec { get; set; } = 5e-6;

        public bool TxpAutoLevel { get; set; } = false;
        public double TxpAutoLevelIntervalSec { get; set; } = 10e-3;

        public int OfdmModAccMeasurementOffsetSymbols { get; set; } = 0;
        public int OfdmModAccMaxMeasurementLengthSymbols { get; set; } = 16;

        public RFmxWlanMXOfdmModAccFrequencyErrorEstimationMethod FrequencyErrorEstimationMethod { get; set; } =
            RFmxWlanMXOfdmModAccFrequencyErrorEstimationMethod.PreambleAndPilots;
        public RFmxWlanMXOfdmModAccChannelEstimationType ChannelEstimationType { get; set; } =
            RFmxWlanMXOfdmModAccChannelEstimationType.Reference;
        public RFmxWlanMXOfdmModAccPhaseTrackingEnabled PhaseTracking { get; set; } =
            RFmxWlanMXOfdmModAccPhaseTrackingEnabled.True;
        public RFmxWlanMXOfdmModAccAmplitudeTrackingEnabled AmplitudeTracking { get; set; } =
            RFmxWlanMXOfdmModAccAmplitudeTrackingEnabled.False;
        public RFmxWlanMXOfdmModAccSymbolClockErrorCorrectionEnabled SymbolClockCorrection { get; set; } =
            RFmxWlanMXOfdmModAccSymbolClockErrorCorrectionEnabled.True;

        public RFmxWlanMXOfdmModAccAveragingEnabled OfdmModAccAveragingEnabled { get; set; } =
            RFmxWlanMXOfdmModAccAveragingEnabled.False;
        public int OfdmModAccAveragingCount { get; set; } = 10;

        public RFmxWlanMXTxpAveragingEnabled TxpAveragingEnabled { get; set; } =
            RFmxWlanMXTxpAveragingEnabled.False;
        public int TxpAveragingCount { get; set; } = 10;
        public double TxpMaximumMeasurementIntervalSec { get; set; } = 1e-3;

        public RFmxWlanMXSemAveragingEnabled SemAveragingEnabled { get; set; } =
            RFmxWlanMXSemAveragingEnabled.False;
        public int SemAveragingCount { get; set; } = 10;
        public RFmxWlanMXSemAveragingType SemAveragingType { get; set; } =
            RFmxWlanMXSemAveragingType.Rms;
        public RFmxWlanMXSemSpanAuto SemSpanAuto { get; set; } =
            RFmxWlanMXSemSpanAuto.True;
        public double SemSpanHz { get; set; } = 66e6;
        public RFmxWlanMXSemSweepTimeAuto SemSweepTimeAuto { get; set; } =
            RFmxWlanMXSemSweepTimeAuto.True;
        public double SemSweepTimeSec { get; set; } = 1e-3;
        public RFmxWlanMXSemMaskType SemMaskType { get; set; } =
            RFmxWlanMXSemMaskType.Standard;

        public double MeasurementTimeoutSec { get; set; } = 10.0;
    }
}