using System.Threading;
using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    public enum StandaloneMeasurementKind
    {
        Evm = 0,
        Txp = 1,
        Sem = 2,
        EvmTxpComposite = 3
    }

    /// <summary>Runs a single measurement type with RFSG + RFmx (Agent 2 wrapper).</summary>
    public sealed class WlanStandaloneMeasurement
    {
        public WlanPointMeasurementResult Run(TestPoint point, WlanRfInstrumentConfig cfg, StandaloneMeasurementKind kind, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var rfsg = new RfsgPlaybackController();
            RFmxInstrMX? instr = null;
            RFmxWlanMX? wlan = null;
            try
            {
                instr = new RFmxInstrMX(cfg.ResourceName, cfg.OptionsString ?? "");
                wlan = instr.GetWlanSignalConfiguration();

                rfsg.Start(
                    cfg.ResourceName,
                    cfg.OptionsString ?? "",
                    point.WaveformFilePath,
                    point.CenterFrequencyHz,
                    cfg.RfsgPowerDbm,
                    cfg.ExternalAttenuationDb,
                    cfg.RfsgFrequencyReferenceSource,
                    cfg.FrequencyReferenceHz);

                cancellationToken.ThrowIfCancellationRequested();

                var result = new WlanPointMeasurementResult();
                switch (kind)
                {
                    case StandaloneMeasurementKind.Evm:
                    {
                        EvmOnlyModule.Configure(instr, wlan, point, cfg);
                        EvmOnlyModule.Initiate(wlan);
                        EvmOnlyModule.FetchCompositeEvm(wlan, cfg, out double e, out double d, out double p);
                        result.CompositeRmsEvmDb = e;
                        result.CompositeDataRmsEvmDb = d;
                        result.CompositePilotRmsEvmDb = p;
                        break;
                    }
                    case StandaloneMeasurementKind.Txp:
                    {
                        TxpOnlyModule.Configure(instr, wlan, point, cfg);
                        TxpOnlyModule.Initiate(wlan);
                        TxpOnlyModule.FetchPower(wlan, cfg, out double avg, out double peak);
                        result.AveragePowerDbm = avg;
                        result.PeakPowerDbm = peak;
                        break;
                    }
                    case StandaloneMeasurementKind.Sem:
                    {
                        SemMeasurementModule.Configure(instr, wlan, point, cfg);
                        SemMeasurementModule.Initiate(wlan);
                        SemMeasurementModule.FetchMargins(wlan, cfg, out RFmxWlanMXSemMeasurementStatus st, out double minM);
                        result.SemStatus = st;
                        result.SemMinMarginDb = minM;
                        break;
                    }
                    case StandaloneMeasurementKind.EvmTxpComposite:
                    {
                        EvmTxpCompositeModule.Configure(instr, wlan, point, cfg);
                        EvmTxpCompositeModule.Initiate(wlan);
                        EvmTxpCompositeModule.Fetch(wlan, cfg,
                            out double evm, out double de, out double pe, out double avgp, out double peakp);
                        result.CompositeRmsEvmDb = evm;
                        result.CompositeDataRmsEvmDb = de;
                        result.CompositePilotRmsEvmDb = pe;
                        result.AveragePowerDbm = avgp;
                        result.PeakPowerDbm = peakp;
                        break;
                    }
                }

                RfmxTraceFetcher.TryPopulate(wlan, cfg, kind, result);
                return result;
            }
            finally
            {
                rfsg.Dispose();
                wlan?.Dispose();
                instr?.Close();
            }
        }
    }
}
