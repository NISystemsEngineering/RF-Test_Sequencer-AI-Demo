using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    public static class TxpOnlyModule
    {
        public static void Configure(RFmxInstrMX instr, RFmxWlanMX wlan, TestPoint point, WlanRfInstrumentConfig cfg)
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
                wlan.AutoLevel("", cfg.TxpAutoLevelIntervalSec);
            else
                wlan.ConfigureReferenceLevel("", cfg.ReferenceLevelDbm);
            wlan.SelectMeasurements("", RFmxWlanMXMeasurementTypes.Txp, true);
            wlan.Txp.Configuration.ConfigureMaximumMeasurementInterval("", cfg.TxpMaximumMeasurementIntervalSec);
            wlan.Txp.Configuration.ConfigureAveraging("", cfg.TxpAveragingEnabled, cfg.TxpAveragingCount);
        }

        public static void Initiate(RFmxWlanMX wlan)
        {
            wlan.Initiate("", "");
        }

        public static void FetchPower(RFmxWlanMX wlan, WlanRfInstrumentConfig cfg, out double averageDbm, out double peakDbm)
        {
            wlan.Txp.Results.FetchMeasurement("", cfg.MeasurementTimeoutSec, out averageDbm, out peakDbm);
        }
    }
}
