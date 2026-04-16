using System;
using System.IO;
using System.Text;
using NationalInstruments.ModularInstruments.NIRfsg;
using NationalInstruments.ModularInstruments.NIRfsgPlayback;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>Loads a TDMS waveform and plays it on NI-RFSG (VST RF OUT loopback).</summary>
    public sealed class RfsgPlaybackController : IDisposable
    {
        const string DefaultWaveformName = "wlanRfAmpSeqWave";

        readonly string _waveformName;
        NIRfsg? _session;
        IntPtr _handle;

        public RfsgPlaybackController(string waveformName = DefaultWaveformName)
        {
            _waveformName = waveformName;
        }

        public void Start(string resourceName, string optionsString, string tdmsPath, double carrierFrequencyHz, double powerDbm, double externalAttenuationDb, RfsgFrequencyReferenceSource frequencyReferenceSource, double frequencyReferenceHz)
        {
            StopAndDispose();
            if (string.IsNullOrWhiteSpace(tdmsPath))
                throw new ArgumentException("TDMS path is required.", nameof(tdmsPath));
            if (!File.Exists(tdmsPath))
                throw new FileNotFoundException("TDMS waveform file not found.", tdmsPath);

            _session = new NIRfsg(resourceName, true, false, optionsString ?? "");
            _handle = _session.GetInstrumentHandle().DangerousGetHandle();
            _session.RF.Configure(carrierFrequencyHz, powerDbm);
            _session.FrequencyReference.Configure(frequencyReferenceSource, frequencyReferenceHz);
            _session.RF.ExternalGain = -externalAttenuationDb;
            NIRfsgPlayback.ReadAndDownloadWaveformFromFile(_handle, tdmsPath, _waveformName);
            string script = BuildScript(_waveformName);
            NIRfsgPlayback.SetScriptToGenerateSingleRfsg(_handle, script);
            _session.Initiate();
        }

        static string BuildScript(string waveformName)
        {
            var sb = new StringBuilder();
            sb.AppendLine("script GenerateWlan");
            sb.AppendLine("repeat forever");
            sb.Append("generate ").AppendLine(waveformName);
            sb.AppendLine("end repeat");
            sb.AppendLine("end script");
            return sb.ToString();
        }

        public void StopAndDispose()
        {
            try
            {
                if (_session != null)
                {
                    _session.Abort();
                    if (_handle != IntPtr.Zero)
                    {
                        try
                        {
                            NIRfsgPlayback.ClearWaveform(_handle, _waveformName);
                        }
                        catch
                        {
                            // ignore cleanup errors
                        }
                    }
                    _session.Close();
                    _session = null;
                    _handle = IntPtr.Zero;
                }
            }
            catch
            {
                // ignore
            }
        }

        public void Dispose()
        {
            StopAndDispose();
        }
    }
}
