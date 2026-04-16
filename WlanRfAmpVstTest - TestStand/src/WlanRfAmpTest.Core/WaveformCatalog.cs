using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;

namespace WlanRfAmpTest.Core
{
    /// <summary>Maps logical matrix keys (band + standard + bandwidth) to TDMS file paths.</summary>
    public sealed class WaveformCatalog
    {
        readonly Dictionary<string, string> _entries;

        WaveformCatalog(Dictionary<string, string> entries)
        {
            _entries = entries;
        }

        public static string KeyFor(RfBand band, WlanStandardKind standard, int bandwidthMHz)
        {
            string b = band == RfBand.Band2_4GHz ? "2.4GHz" : "5GHz";
            string s = standard == WlanStandardKind.IEEE802_11ac ? "802.11ac" : "802.11ax";
            return string.Format(CultureInfo.InvariantCulture, "{0}_{1}_{2}MHz", b, s, bandwidthMHz);
        }

        public bool TryGetPath(string key, out string path)
        {
            return _entries.TryGetValue(key, out path!);
        }

        public IReadOnlyDictionary<string, string> Entries => _entries;

        public static WaveformCatalog FromJsonFile(string jsonPath)
        {
            if (!File.Exists(jsonPath))
                throw new FileNotFoundException("Waveform catalog file not found.", jsonPath);
            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(jsonPath))
                ?? new Dictionary<string, string>();
            return new WaveformCatalog(dict);
        }

        public static void WriteTemplate(string jsonPath)
        {
            var sample = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var band in new[] { RfBand.Band2_4GHz, RfBand.Band5GHz })
            {
                foreach (var std in new[] { WlanStandardKind.IEEE802_11ac, WlanStandardKind.IEEE802_11ax })
                {
                    foreach (int bw in TestPlanBuilder.DefaultBandwidthsMHz)
                    {
                        string key = KeyFor(band, std, bw);
                        sample[key] = "C:\\\\Path\\\\To\\\\Waveforms\\\\" + key.Replace(" ", "") + ".tdms";
                    }
                }
            }
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(sample, Formatting.Indented));
        }
    }
}
