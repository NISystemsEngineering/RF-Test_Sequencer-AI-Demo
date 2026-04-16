using System;
using System.Globalization;
using NationalInstruments.RFmx.WlanMX;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>String-friendly snapshot for UIs that cannot reference RFmx assemblies (e.g. WinForms runner).</summary>
    public sealed class WlanRfInstrumentUiModel
    {
        public string ResourceName { get; set; } = "";
        public string ReferenceLevelDbm { get; set; } = "0";
        public string ExternalAttenuationDb { get; set; } = "0";
        public string RfsgPowerDbm { get; set; } = "-10";
        public string MeasurementTimeoutSec { get; set; } = "10";
        public bool IqPowerEdgeTriggerEnabled { get; set; } = true;
        public string IqPowerEdgeLevelDb { get; set; } = "-20";
        public string TriggerDelaySec { get; set; } = "0";
        public string MinimumQuietTimeSec { get; set; } = "5e-6";
        public string MinimumQuietTimeMode { get; set; } = nameof(RFmxWlanMXTriggerMinimumQuietTimeMode.Auto);

        public string OfdmModAccMeasurementOffsetSymbols { get; set; } = "0";
        public string OfdmModAccMaxMeasurementLengthSymbols { get; set; } = "16";
        public string FrequencyErrorEstimationMethod { get; set; } =
            nameof(RFmxWlanMXOfdmModAccFrequencyErrorEstimationMethod.PreambleAndPilots);
        public string ChannelEstimationType { get; set; } = nameof(RFmxWlanMXOfdmModAccChannelEstimationType.Reference);
        public string PhaseTracking { get; set; } = nameof(RFmxWlanMXOfdmModAccPhaseTrackingEnabled.True);
        public string AmplitudeTracking { get; set; } = nameof(RFmxWlanMXOfdmModAccAmplitudeTrackingEnabled.False);
        public string SymbolClockCorrection { get; set; } = nameof(RFmxWlanMXOfdmModAccSymbolClockErrorCorrectionEnabled.True);
        public string OfdmModAccAveragingEnabled { get; set; } = nameof(RFmxWlanMXOfdmModAccAveragingEnabled.False);
        public string OfdmModAccAveragingCount { get; set; } = "10";

        public bool TxpAutoLevel { get; set; }
        public string TxpAutoLevelIntervalSec { get; set; } = "0.01";
        public string TxpAveragingEnabled { get; set; } = nameof(RFmxWlanMXTxpAveragingEnabled.False);
        public string TxpAveragingCount { get; set; } = "10";
        public string TxpMaximumMeasurementIntervalSec { get; set; } = "0.001";

        public string SemAveragingEnabled { get; set; } = nameof(RFmxWlanMXSemAveragingEnabled.False);
        public string SemAveragingCount { get; set; } = "10";
        public string SemAveragingType { get; set; } = nameof(RFmxWlanMXSemAveragingType.Rms);
        public string SemSpanAuto { get; set; } = nameof(RFmxWlanMXSemSpanAuto.True);
        public string SemSpanHz { get; set; } = "66000000";
        public string SemSweepTimeAuto { get; set; } = nameof(RFmxWlanMXSemSweepTimeAuto.True);
        public string SemSweepTimeSec { get; set; } = "0.001";
        public string SemMaskType { get; set; } = nameof(RFmxWlanMXSemMaskType.Standard);

        public static WlanRfInstrumentUiModel FromDefaults() => FromConfig(new WlanRfInstrumentConfig());

        public static WlanRfInstrumentUiModel FromConfig(WlanRfInstrumentConfig c)
        {
            var inv = CultureInfo.InvariantCulture;
            return new WlanRfInstrumentUiModel
            {
                ResourceName = c.ResourceName ?? "",
                ReferenceLevelDbm = c.ReferenceLevelDbm.ToString(inv),
                ExternalAttenuationDb = c.ExternalAttenuationDb.ToString(inv),
                RfsgPowerDbm = c.RfsgPowerDbm.ToString(inv),
                MeasurementTimeoutSec = c.MeasurementTimeoutSec.ToString(inv),
                IqPowerEdgeTriggerEnabled = c.IqPowerEdgeTriggerEnabled,
                IqPowerEdgeLevelDb = c.IqPowerEdgeLevelDb.ToString(inv),
                TriggerDelaySec = c.TriggerDelaySec.ToString(inv),
                MinimumQuietTimeSec = c.MinimumQuietTimeSec.ToString(inv),
                MinimumQuietTimeMode = c.MinimumQuietTimeMode.ToString(),
                OfdmModAccMeasurementOffsetSymbols = c.OfdmModAccMeasurementOffsetSymbols.ToString(inv),
                OfdmModAccMaxMeasurementLengthSymbols = c.OfdmModAccMaxMeasurementLengthSymbols.ToString(inv),
                FrequencyErrorEstimationMethod = c.FrequencyErrorEstimationMethod.ToString(),
                ChannelEstimationType = c.ChannelEstimationType.ToString(),
                PhaseTracking = c.PhaseTracking.ToString(),
                AmplitudeTracking = c.AmplitudeTracking.ToString(),
                SymbolClockCorrection = c.SymbolClockCorrection.ToString(),
                OfdmModAccAveragingEnabled = c.OfdmModAccAveragingEnabled.ToString(),
                OfdmModAccAveragingCount = c.OfdmModAccAveragingCount.ToString(inv),
                TxpAutoLevel = c.TxpAutoLevel,
                TxpAutoLevelIntervalSec = c.TxpAutoLevelIntervalSec.ToString(inv),
                TxpAveragingEnabled = c.TxpAveragingEnabled.ToString(),
                TxpAveragingCount = c.TxpAveragingCount.ToString(inv),
                TxpMaximumMeasurementIntervalSec = c.TxpMaximumMeasurementIntervalSec.ToString(inv),
                SemAveragingEnabled = c.SemAveragingEnabled.ToString(),
                SemAveragingCount = c.SemAveragingCount.ToString(inv),
                SemAveragingType = c.SemAveragingType.ToString(),
                SemSpanAuto = c.SemSpanAuto.ToString(),
                SemSpanHz = c.SemSpanHz.ToString(inv),
                SemSweepTimeAuto = c.SemSweepTimeAuto.ToString(),
                SemSweepTimeSec = c.SemSweepTimeSec.ToString(inv),
                SemMaskType = c.SemMaskType.ToString()
            };
        }

        public WlanRfInstrumentConfig ToConfig()
        {
            var inv = CultureInfo.InvariantCulture;
            return new WlanRfInstrumentConfig
            {
                ResourceName = ResourceName ?? "",
                ReferenceLevelDbm = ParseDouble(ReferenceLevelDbm, nameof(ReferenceLevelDbm)),
                ExternalAttenuationDb = ParseDouble(ExternalAttenuationDb, nameof(ExternalAttenuationDb)),
                RfsgPowerDbm = ParseDouble(RfsgPowerDbm, nameof(RfsgPowerDbm)),
                MeasurementTimeoutSec = ParseDouble(MeasurementTimeoutSec, nameof(MeasurementTimeoutSec)),
                IqPowerEdgeTriggerEnabled = IqPowerEdgeTriggerEnabled,
                IqPowerEdgeLevelDb = ParseDouble(IqPowerEdgeLevelDb, nameof(IqPowerEdgeLevelDb)),
                TriggerDelaySec = ParseDouble(TriggerDelaySec, nameof(TriggerDelaySec)),
                MinimumQuietTimeSec = ParseDouble(MinimumQuietTimeSec, nameof(MinimumQuietTimeSec)),
                MinimumQuietTimeMode = ParseEnum<RFmxWlanMXTriggerMinimumQuietTimeMode>(MinimumQuietTimeMode),
                OfdmModAccMeasurementOffsetSymbols = ParseInt(OfdmModAccMeasurementOffsetSymbols, nameof(OfdmModAccMeasurementOffsetSymbols)),
                OfdmModAccMaxMeasurementLengthSymbols = ParseInt(OfdmModAccMaxMeasurementLengthSymbols, nameof(OfdmModAccMaxMeasurementLengthSymbols)),
                FrequencyErrorEstimationMethod = ParseEnum<RFmxWlanMXOfdmModAccFrequencyErrorEstimationMethod>(FrequencyErrorEstimationMethod),
                ChannelEstimationType = ParseEnum<RFmxWlanMXOfdmModAccChannelEstimationType>(ChannelEstimationType),
                PhaseTracking = ParseEnum<RFmxWlanMXOfdmModAccPhaseTrackingEnabled>(PhaseTracking),
                AmplitudeTracking = ParseEnum<RFmxWlanMXOfdmModAccAmplitudeTrackingEnabled>(AmplitudeTracking),
                SymbolClockCorrection = ParseEnum<RFmxWlanMXOfdmModAccSymbolClockErrorCorrectionEnabled>(SymbolClockCorrection),
                OfdmModAccAveragingEnabled = ParseEnum<RFmxWlanMXOfdmModAccAveragingEnabled>(OfdmModAccAveragingEnabled),
                OfdmModAccAveragingCount = ParseInt(OfdmModAccAveragingCount, nameof(OfdmModAccAveragingCount)),
                TxpAutoLevel = TxpAutoLevel,
                TxpAutoLevelIntervalSec = ParseDouble(TxpAutoLevelIntervalSec, nameof(TxpAutoLevelIntervalSec)),
                TxpAveragingEnabled = ParseEnum<RFmxWlanMXTxpAveragingEnabled>(TxpAveragingEnabled),
                TxpAveragingCount = ParseInt(TxpAveragingCount, nameof(TxpAveragingCount)),
                TxpMaximumMeasurementIntervalSec = ParseDouble(TxpMaximumMeasurementIntervalSec, nameof(TxpMaximumMeasurementIntervalSec)),
                SemAveragingEnabled = ParseEnum<RFmxWlanMXSemAveragingEnabled>(SemAveragingEnabled),
                SemAveragingCount = ParseInt(SemAveragingCount, nameof(SemAveragingCount)),
                SemAveragingType = ParseEnum<RFmxWlanMXSemAveragingType>(SemAveragingType),
                SemSpanAuto = ParseEnum<RFmxWlanMXSemSpanAuto>(SemSpanAuto),
                SemSpanHz = ParseDouble(SemSpanHz, nameof(SemSpanHz)),
                SemSweepTimeAuto = ParseEnum<RFmxWlanMXSemSweepTimeAuto>(SemSweepTimeAuto),
                SemSweepTimeSec = ParseDouble(SemSweepTimeSec, nameof(SemSweepTimeSec)),
                SemMaskType = ParseEnum<RFmxWlanMXSemMaskType>(SemMaskType)
            };
        }

        static double ParseDouble(string s, string field)
        {
            if (!double.TryParse((s ?? "").Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double v))
                throw new InvalidOperationException("Invalid number for " + field + ".");
            return v;
        }

        static int ParseInt(string s, string field)
        {
            if (!int.TryParse((s ?? "").Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int v))
                throw new InvalidOperationException("Invalid integer for " + field + ".");
            return v;
        }

        static T ParseEnum<T>(string name) where T : struct, Enum
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new InvalidOperationException("Missing enum value for " + typeof(T).Name + ".");
            if (Enum.TryParse(name.Trim(), true, out T v))
                return v;
            throw new InvalidOperationException("Invalid value '" + name + "' for " + typeof(T).Name + ".");
        }
    }

    /// <summary>Enum name lists for populating combo boxes without an RFmx reference.</summary>
    public static class WlanRfInstrumentUiCatalog
    {
        public static string[] MinimumQuietTimeModes() => Enum.GetNames(typeof(RFmxWlanMXTriggerMinimumQuietTimeMode));
        public static string[] FrequencyErrorEstimationMethods() => Enum.GetNames(typeof(RFmxWlanMXOfdmModAccFrequencyErrorEstimationMethod));
        public static string[] ChannelEstimationTypes() => Enum.GetNames(typeof(RFmxWlanMXOfdmModAccChannelEstimationType));
        public static string[] PhaseTrackingModes() => Enum.GetNames(typeof(RFmxWlanMXOfdmModAccPhaseTrackingEnabled));
        public static string[] AmplitudeTrackingModes() => Enum.GetNames(typeof(RFmxWlanMXOfdmModAccAmplitudeTrackingEnabled));
        public static string[] SymbolClockCorrections() => Enum.GetNames(typeof(RFmxWlanMXOfdmModAccSymbolClockErrorCorrectionEnabled));
        public static string[] OfdmModAccAveragingModes() => Enum.GetNames(typeof(RFmxWlanMXOfdmModAccAveragingEnabled));
        public static string[] TxpAveragingModes() => Enum.GetNames(typeof(RFmxWlanMXTxpAveragingEnabled));
        public static string[] SemAveragingModes() => Enum.GetNames(typeof(RFmxWlanMXSemAveragingEnabled));
        public static string[] SemAveragingTypes() => Enum.GetNames(typeof(RFmxWlanMXSemAveragingType));
        public static string[] SemSpanAutoModes() => Enum.GetNames(typeof(RFmxWlanMXSemSpanAuto));
        public static string[] SemSweepTimeAutoModes() => Enum.GetNames(typeof(RFmxWlanMXSemSweepTimeAuto));
        public static string[] SemMaskTypes() => Enum.GetNames(typeof(RFmxWlanMXSemMaskType));
    }
}
