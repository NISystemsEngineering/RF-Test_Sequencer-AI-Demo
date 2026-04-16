using System;
using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>Spectrum Emission Mask measurement (separate acquisition from ModAcc/TxP).</summary>
    public static class SemMeasurementModule
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
            wlan.ConfigureReferenceLevel("", cfg.ReferenceLevelDbm);
            wlan.ConfigureExternalAttenuation("", cfg.ExternalAttenuationDb);
            wlan.ConfigureIQPowerEdgeTrigger("", "0", RFmxWlanMXIQPowerEdgeTriggerSlope.Rising, cfg.IqPowerEdgeLevelDb,
                cfg.TriggerDelaySec, cfg.MinimumQuietTimeMode, cfg.MinimumQuietTimeSec,
                RFmxWlanMXIQPowerEdgeTriggerLevelType.Relative, cfg.IqPowerEdgeTriggerEnabled);
            wlan.ConfigureStandard("", std);
            wlan.ConfigureChannelBandwidth("", channelBandwidthHz);

            wlan.SelectMeasurements("", RFmxWlanMXMeasurementTypes.Sem, true);
            wlan.Sem.Configuration.ConfigureAveraging("", cfg.SemAveragingEnabled, cfg.SemAveragingCount, cfg.SemAveragingType);
            wlan.Sem.Configuration.ConfigureMaskType("", cfg.SemMaskType);
            wlan.Sem.Configuration.ConfigureSweepTime("", cfg.SemSweepTimeAuto, cfg.SemSweepTimeSec);
            wlan.Sem.Configuration.ConfigureSpan("", cfg.SemSpanAuto, cfg.SemSpanHz);
        }

        public static void Initiate(RFmxWlanMX wlan)
        {
            wlan.Initiate("", "");
        }

        public static void FetchMargins(
            RFmxWlanMX wlan,
            WlanRfInstrumentConfig cfg,
            out RFmxWlanMXSemMeasurementStatus status,
            out double minMarginDb)
        {
            double t = cfg.MeasurementTimeoutSec;
            wlan.Sem.Results.FetchMeasurementStatus("", t, out status);

            RFmxWlanMXSemLowerOffsetMeasurementStatus[]? lowerStat = null;
            double[]? lowerMargin = null;
            double[]? lowerMarginFreq = null;
            double[]? lowerAbs = null;
            double[]? lowerRel = null;
            RFmxWlanMXSemUpperOffsetMeasurementStatus[]? upperStat = null;
            double[]? upperMargin = null;
            double[]? upperMarginFreq = null;
            double[]? upperAbs = null;
            double[]? upperRel = null;

            wlan.Sem.Results.FetchLowerOffsetMarginArray("", t, ref lowerStat, ref lowerMargin, ref lowerMarginFreq, ref lowerAbs, ref lowerRel);
            wlan.Sem.Results.FetchUpperOffsetMarginArray("", t, ref upperStat, ref upperMargin, ref upperMarginFreq, ref upperAbs, ref upperRel);

            minMarginDb = double.NaN;
            if (lowerMargin != null)
            {
                foreach (double m in lowerMargin)
                {
                    if (!double.IsNaN(m) && !double.IsInfinity(m))
                        minMarginDb = double.IsNaN(minMarginDb) ? m : Math.Min(minMarginDb, m);
                }
            }
            if (upperMargin != null)
            {
                foreach (double m in upperMargin)
                {
                    if (!double.IsNaN(m) && !double.IsInfinity(m))
                        minMarginDb = double.IsNaN(minMarginDb) ? m : Math.Min(minMarginDb, m);
                }
            }
        }
    }
}
