using System;
using System.Threading;
using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>Runs RFSG playback plus selected RFmx measurement blocks for one matrix point.</summary>
    public sealed class WlanMeasurementOrchestrator
    {
        public WlanPointMeasurementResult MeasurePoint(TestPoint point, WlanRfInstrumentConfig cfg, CancellationToken cancellationToken)
        {
            return MeasurePoint(point, cfg, null, cancellationToken);
        }

        public WlanPointMeasurementResult MeasurePoint(
            TestPoint point,
            WlanRfInstrumentConfig cfg,
            SequencerMeasurementOptions? measurementOptions,
            CancellationToken cancellationToken)
        {
            var opt = measurementOptions ?? new SequencerMeasurementOptions();
            if (!opt.IsValid)
                throw new InvalidOperationException("Select at least one measurement (EVM+TxP and/or SEM).");

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

                double evm = double.NaN, dataEvm = double.NaN, pilotEvm = double.NaN, avgP = double.NaN, peakP = double.NaN;
                if (opt.RunCompositeEvmTxp)
                {
                    EvmTxpCompositeModule.Configure(instr, wlan, point, cfg);
                    EvmTxpCompositeModule.Initiate(wlan);
                    EvmTxpCompositeModule.Fetch(wlan, cfg, out evm, out dataEvm, out pilotEvm, out avgP, out peakP);
                }

                cancellationToken.ThrowIfCancellationRequested();

                RFmxWlanMXSemMeasurementStatus semStatus = default;
                double semMin = double.NaN;
                if (opt.RunSem)
                {
                    SemMeasurementModule.Configure(instr, wlan, point, cfg);
                    SemMeasurementModule.Initiate(wlan);
                    SemMeasurementModule.FetchMargins(wlan, cfg, out semStatus, out semMin);
                }

                return new WlanPointMeasurementResult
                {
                    CompositeRmsEvmDb = evm,
                    CompositeDataRmsEvmDb = dataEvm,
                    CompositePilotRmsEvmDb = pilotEvm,
                    AveragePowerDbm = avgP,
                    PeakPowerDbm = peakP,
                    SemStatus = semStatus,
                    SemMinMarginDb = semMin
                };
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
