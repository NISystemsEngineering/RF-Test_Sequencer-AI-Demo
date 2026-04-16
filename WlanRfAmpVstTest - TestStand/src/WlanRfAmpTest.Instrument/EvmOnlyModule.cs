using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    public static class EvmOnlyModule
    {
        public static void Configure(RFmxInstrMX instr, RFmxWlanMX wlan, TestPoint point, WlanRfInstrumentConfig cfg)
        {
            double channelBandwidthHz = point.BandwidthMHz * 1e6;
            RFmxWlanMXStandard std = WlanStandardMap.ToRfmx(point.Standard);

            instr.ConfigureFrequencyReference("", cfg.FrequencyReferenceSource, cfg.FrequencyReferenceHz);
            wlan.ConfigureFrequency("", point.CenterFrequencyHz);
            wlan.ConfigureReferenceLevel("", cfg.ReferenceLevelDbm);
            wlan.ConfigureExternalAttenuation("", cfg.ExternalAttenuationDb);
            wlan.ConfigureIQPowerEdgeTrigger("", "0", RFmxWlanMXIQPowerEdgeTriggerSlope.Rising, cfg.IqPowerEdgeLevelDb,
                cfg.TriggerDelaySec, cfg.MinimumQuietTimeMode, cfg.MinimumQuietTimeSec,
                RFmxWlanMXIQPowerEdgeTriggerLevelType.Relative, cfg.IqPowerEdgeTriggerEnabled);
            wlan.ConfigureStandard("", std);
            wlan.ConfigureChannelBandwidth("", channelBandwidthHz);
            wlan.SelectMeasurements("", RFmxWlanMXMeasurementTypes.OfdmModAcc, true);
            wlan.OfdmModAcc.Configuration.ConfigureMeasurementLength("",
                cfg.OfdmModAccMeasurementOffsetSymbols, cfg.OfdmModAccMaxMeasurementLengthSymbols);
            wlan.OfdmModAcc.Configuration.ConfigureFrequencyErrorEstimationMethod("", cfg.FrequencyErrorEstimationMethod);
            wlan.OfdmModAcc.Configuration.ConfigureAmplitudeTrackingEnabled("", cfg.AmplitudeTracking);
            wlan.OfdmModAcc.Configuration.ConfigurePhaseTrackingEnabled("", cfg.PhaseTracking);
            wlan.OfdmModAcc.Configuration.ConfigureSymbolClockErrorCorrectionEnabled("", cfg.SymbolClockCorrection);
            wlan.OfdmModAcc.Configuration.ConfigureChannelEstimationType("", cfg.ChannelEstimationType);
            wlan.OfdmModAcc.Configuration.ConfigureAveraging("", cfg.OfdmModAccAveragingEnabled, cfg.OfdmModAccAveragingCount);
        }

        public static void Initiate(RFmxWlanMX wlan)
        {
            wlan.Initiate("", "");
        }

        public static void FetchCompositeEvm(RFmxWlanMX wlan, WlanRfInstrumentConfig cfg, out double rms, out double data, out double pilot)
        {
            wlan.OfdmModAcc.Results.FetchCompositeRmsEvm("", cfg.MeasurementTimeoutSec, out rms, out data, out pilot);
        }
    }
}
