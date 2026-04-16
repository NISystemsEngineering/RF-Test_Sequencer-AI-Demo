using System;
using NationalInstruments;
using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    internal static class RfmxTraceConverters
    {
        public static RfmxTimeTrace? FromAnalogWaveform(AnalogWaveform<float>? w)
        {
            if (w == null || w.SampleCount <= 0)
                return null;
            int n = w.SampleCount;
            var y = new double[n];
            for (int i = 0; i < n; i++)
                y[i] = w.Samples[i].Value;
            double dt = w.IsPrecisionTimingInitialized
                ? w.PrecisionTiming.SampleInterval.TotalSeconds
                : w.Timing.SampleInterval.TotalSeconds;
            return new RfmxTimeTrace
            {
                StartTimeSec = 0,
                SampleSpacingSec = dt,
                Values = y
            };
        }

        public static RfmxSpectrumTrace? FromSpectrum(Spectrum<float>? s)
        {
            if (s == null || s.SampleCount <= 0)
                return null;
            float[] raw = s.GetData();
            int size = raw.Length;
            var amp = new double[size];
            for (int i = 0; i < size; i++)
                amp[i] = raw[i];
            return new RfmxSpectrumTrace
            {
                StartFrequencyHz = s.StartFrequency,
                FrequencyStepHz = s.FrequencyIncrement,
                Amplitudes = amp
            };
        }

        public static RfmxConstellationTrace? FromComplex(ComplexSingle[]? c)
        {
            if (c == null || c.Length == 0)
                return null;
            var ri = new double[c.Length];
            var rq = new double[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                ri[i] = c[i].Real;
                rq[i] = c[i].Imaginary;
            }
            return new RfmxConstellationTrace { I = ri, Q = rq };
        }
    }
}
