using System;
using System.Text;
using NationalInstruments;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    internal static class RfmxTraceFetcher
    {
        const string ChainSel = "segment0/chain0";
        const string StreamSel = "segment0/stream0";

        public static void TryPopulate(RFmxWlanMX wlan, WlanRfInstrumentConfig cfg, StandaloneMeasurementKind kind, WlanPointMeasurementResult result)
        {
            var snap = new WlanRfmxTraceSnapshot();
            var notes = new StringBuilder();
            double t = cfg.MeasurementTimeoutSec;

            void Try(string what, Action act)
            {
                try
                {
                    act();
                }
                catch (Exception ex)
                {
                    if (notes.Length > 0)
                        notes.Append("; ");
                    notes.Append(what).Append(": ").Append(ex.GetBaseException().Message);
                }
            }

            switch (kind)
            {
                case StandaloneMeasurementKind.Evm:
                case StandaloneMeasurementKind.EvmTxpComposite:
                    Try("ModAcc traces", () =>
                    {
                        AnalogWaveform<float>? evmSc = null;
                        wlan.OfdmModAcc.Results.FetchChainRmsEvmPerSubcarrierMeanTrace(ChainSel, t, ref evmSc);
                        snap.EvmPerSubcarrierDb = RfmxTraceConverters.FromAnalogWaveform(evmSc);

                        ComplexSingle[]? pilot = null;
                        wlan.OfdmModAcc.Results.FetchPilotConstellationTrace(StreamSel, t, ref pilot);
                        snap.PilotConstellation = RfmxTraceConverters.FromComplex(pilot);

                        ComplexSingle[]? data = null;
                        wlan.OfdmModAcc.Results.FetchDataConstellationTrace(StreamSel, t, ref data);
                        snap.DataConstellation = RfmxTraceConverters.FromComplex(data);
                    });
                    break;
            }

            switch (kind)
            {
                case StandaloneMeasurementKind.Txp:
                case StandaloneMeasurementKind.EvmTxpComposite:
                    Try("TxP trace", () =>
                    {
                        AnalogWaveform<float>? pwr = null;
                        wlan.Txp.Results.FetchPowerTrace(ChainSel, t, ref pwr);
                        snap.TxpPowerDbm = RfmxTraceConverters.FromAnalogWaveform(pwr);
                    });
                    break;
            }

            if (kind == StandaloneMeasurementKind.Sem)
            {
                Try("SEM spectrum", () =>
                {
                    Spectrum<float>? spec = null;
                    Spectrum<float>? mask = null;
                    wlan.Sem.Results.FetchSpectrum(ChainSel, t, ref spec, ref mask);
                    snap.SemSpectrum = RfmxTraceConverters.FromSpectrum(spec);
                    snap.SemCompositeMask = RfmxTraceConverters.FromSpectrum(mask);
                });
            }

            if (notes.Length > 0)
                snap.TraceFetchNote = notes.ToString();
            result.Traces = snap;
        }
    }
}
