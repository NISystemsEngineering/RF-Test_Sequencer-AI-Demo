using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace WlanRfAmpTest.Core
{
    /// <summary>UTF-8 CSV with a fixed header for regression and NI-style post-processing. Use <paramref name="append"/> to open in append mode (existing file) or create/overwrite.</summary>
    public sealed class CsvResultLogger : IDisposable
    {
        readonly StreamWriter _writer;
        readonly object _lock = new object();
        bool _headerWritten;

        public CsvResultLogger(string csvPath, bool append)
        {
            if (string.IsNullOrWhiteSpace(csvPath))
                throw new ArgumentException("csvPath", nameof(csvPath));
            string? dir = Path.GetDirectoryName(csvPath);
            if (!string.IsNullOrEmpty(dir))
                Directory.CreateDirectory(dir);
            _writer = new StreamWriter(new FileStream(csvPath, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
        }

        public static string Header => string.Join(",",
            "TimestampUtc",
            "TestIndex",
            "Band",
            "CenterFrequency_Hz",
            "Standard",
            "Bandwidth_MHz",
            "WaveformPath",
            "EVM_RMS_dB",
            "DataEVM_RMS_dB",
            "PilotEVM_RMS_dB",
            "TxP_Average_dBm",
            "TxP_Peak_dBm",
            "SEM_Status",
            "SEM_MinMargin_dB",
            "Pass",
            "Error");

        static string Escape(string? s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (s.IndexOfAny(new[] { ',', '"', '\r', '\n' }) >= 0)
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        public void WriteRow(MeasurementRow row, double? dataEvmDb = null, double? pilotEvmDb = null)
        {
            lock (_lock)
            {
                if (!_headerWritten)
                {
                    _writer.WriteLine(Header);
                    _headerWritten = true;
                }
                var inv = CultureInfo.InvariantCulture;
                var line = string.Join(",",
                    row.TimestampUtc.ToString("o", inv),
                    row.TestIndex.ToString(inv),
                    Escape(row.Band),
                    row.CenterFrequencyHz.ToString(inv),
                    Escape(row.Standard),
                    row.BandwidthMHz.ToString(inv),
                    Escape(row.WaveformPath),
                    Format(row.EvmRmsDb),
                    Format(dataEvmDb),
                    Format(pilotEvmDb),
                    Format(row.TxpAverageDbm),
                    Format(row.TxpPeakDbm),
                    Escape(row.SemMeasurementStatus ?? ""),
                    Format(row.SemMinMarginDb),
                    row.Pass ? "1" : "0",
                    Escape(row.Error ?? ""));
                _writer.WriteLine(line);
                _writer.Flush();
            }
        }

        static string Format(double? v)
        {
            if (!v.HasValue)
                return "";
            return v.Value.ToString("G17", CultureInfo.InvariantCulture);
        }

        public void Dispose()
        {
            _writer.Dispose();
        }

        /// <summary>Reads all data rows from an existing CSV (skips header).</summary>
        public static IReadOnlyList<Dictionary<string, string>> ReadRows(string csvPath)
        {
            var lines = File.ReadAllLines(csvPath);
            if (lines.Length == 0)
                return Array.Empty<Dictionary<string, string>>();
            var header = lines[0].Split(',');
            var list = new List<Dictionary<string, string>>();
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;
                var cols = SplitCsvLine(lines[i]);
                var row = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                for (int c = 0; c < header.Length && c < cols.Count; c++)
                    row[header[c].Trim()] = cols[c];
                list.Add(row);
            }
            return list;
        }

        static List<string> SplitCsvLine(string line)
        {
            var result = new List<string>();
            var cur = new StringBuilder();
            bool inQuote = false;
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (inQuote)
                {
                    if (ch == '"' && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        cur.Append('"');
                        i++;
                    }
                    else if (ch == '"')
                        inQuote = false;
                    else
                        cur.Append(ch);
                }
                else
                {
                    if (ch == '"')
                        inQuote = true;
                    else if (ch == ',')
                    {
                        result.Add(cur.ToString());
                        cur.Clear();
                    }
                    else
                        cur.Append(ch);
                }
            }
            result.Add(cur.ToString());
            return result;
        }
    }
}
