using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>RFmx WLAN OFDM ModAcc + TxP composite (single acquisition).</summary>
    public static class EvmTxpCompositeModule
    {
        public static void Configure(
            RFmxInstrMX instr,
            RFmxWlanMX wlan,
            TestPoint point,
            WlanRfInstrumentConfig cfg)
        {
            double channelBandwidthHz = point.BandwidthMHz * 1e6;
            RFmxWlanMXStandard std = WlanStandardMap.ToRfmx(point.Standard);

            instr.ConfigureFrequencyReference("", cfg.FrequencyReferenceSource, cfg.FrequencyReferenceHz);
            wlan.ConfigureFrequency("", point.CenterFrequencyHz);
            wlan.ConfigureExternalAttenuation("", cfg.ExternalAttenuationDb);
            wlan.ConfigureIQPowerEdgeTrigger("", "0", RFmxWlanMXIQPowerEdgeTriggerSlope.Rising, cfg.IqPowerEdgeLevelDb,
                cfg.TriggerDelaySec, cfg.MinimumQuietTimeMode, cfg.MinimumQuietTimeSec,
                RFmxWlanMXIQPowerEdgeTriggerLevelType.Relative, cfg.IqPowerEdgeTriggerEnabled);
            wlan.ConfigureStandard("", std);
            wlan.ConfigureChannelBandwidth("", channelBandwidthHz);

            if (cfg.TxpAutoLevel)
            {
                wlan.AutoLevel("", cfg.TxpAutoLevelIntervalSec);
            }
            else
            {
                wlan.ConfigureReferenceLevel("", cfg.ReferenceLevelDbm);
            }

            wlan.SelectMeasurements("", RFmxWlanMXMeasurementTypes.Txp | RFmxWlanMXMeasurementTypes.OfdmModAcc, true);

            wlan.OfdmModAcc.Configuration.ConfigureMeasurementLength("",
                cfg.OfdmModAccMeasurementOffsetSymbols, cfg.OfdmModAccMaxMeasurementLengthSymbols);
            wlan.OfdmModAcc.Configuration.ConfigureFrequencyErrorEstimationMethod("", cfg.FrequencyErrorEstimationMethod);
            wlan.OfdmModAcc.Configuration.ConfigureAmplitudeTrackingEnabled("", cfg.AmplitudeTracking);
            wlan.OfdmModAcc.Configuration.ConfigurePhaseTrackingEnabled("", cfg.PhaseTracking);
            wlan.OfdmModAcc.Configuration.ConfigureSymbolClockErrorCorrectionEnabled("", cfg.SymbolClockCorrection);
            wlan.OfdmModAcc.Configuration.ConfigureChannelEstimationType("", cfg.ChannelEstimationType);
            wlan.OfdmModAcc.Configuration.ConfigureAveraging("", cfg.OfdmModAccAveragingEnabled, cfg.OfdmModAccAveragingCount);

            wlan.Txp.Configuration.ConfigureAveraging("", cfg.TxpAveragingEnabled, cfg.TxpAveragingCount);
            wlan.Txp.Configuration.ConfigureMaximumMeasurementInterval("", cfg.TxpMaximumMeasurementIntervalSec);
        }

        public static void Initiate(RFmxWlanMX wlan)
        {
            wlan.Initiate("", "");
        }

        public static void Fetch(
            RFmxWlanMX wlan,
            WlanRfInstrumentConfig cfg,
            out double compositeRmsEvmDb,
            out double compositeDataRmsEvmDb,
            out double compositePilotRmsEvmDb,
            out double averagePowerDbm,
            out double peakPowerDbm)
        {
            double t = cfg.MeasurementTimeoutSec;
            wlan.OfdmModAcc.Results.FetchCompositeRmsEvm("", t, out compositeRmsEvmDb, out compositeDataRmsEvmDb, out compositePilotRmsEvmDb);
            wlan.Txp.Results.FetchMeasurement("", t, out averagePowerDbm, out peakPowerDbm);
        }
    }
}
