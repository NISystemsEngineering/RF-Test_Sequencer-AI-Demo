using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace WlanRfAmpTest.Core
{
    /// <summary>One row with a parsed composite RMS EVM from a sequencer/module CSV report.</summary>
    public sealed class EvmReportSample
    {
        public string FullPath { get; }
        public int RowIndex { get; }
        public DateTime? TimestampUtc { get; }
        public double EvmRmsDb { get; }

        public EvmReportSample(string fullPath, int rowIndex, DateTime? timestampUtc, double evmRmsDb)
        {
            FullPath = fullPath;
            RowIndex = rowIndex;
            TimestampUtc = timestampUtc;
            EvmRmsDb = evmRmsDb;
        }
    }

    /// <summary>Loads <see cref="EvmReportSample"/> rows from <see cref="CsvResultLogger"/> CSV files in a folder.</summary>
    public static class CsvReportEvmAggregator
    {
        /// <summary>True if the first line looks like our fixed result CSV header (TimestampUtc + EVM_RMS_dB).</summary>
        public static bool IsCompatibleResultCsv(string csvPath)
        {
            if (string.IsNullOrWhiteSpace(csvPath) || !File.Exists(csvPath))
                return false;
            using var r = new StreamReader(csvPath);
            string line = r.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
                return false;
            if (line.Length > 0 && line[0] == '\uFEFF')
                line = line.TrimStart('\uFEFF');
            return line.IndexOf("TimestampUtc", StringComparison.Ordinal) >= 0
                && line.IndexOf("EVM_RMS_dB", StringComparison.Ordinal) >= 0;
        }

        /// <summary>All *.csv in <paramref name="directory"/> (non-recursive) that pass <see cref="IsCompatibleResultCsv"/>, ordered by path then row order.</summary>
        public static IReadOnlyList<EvmReportSample> CollectFromDirectory(string directory)
        {
            if (string.IsNullOrWhiteSpace(directory) || !Directory.Exists(directory))
                return Array.Empty<EvmReportSample>();

            var list = new List<EvmReportSample>();
            foreach (string path in Directory.EnumerateFiles(directory, "*.csv").OrderBy(p => p, StringComparer.OrdinalIgnoreCase))
            {
                if (!IsCompatibleResultCsv(path))
                    continue;
                IReadOnlyList<Dictionary<string, string>> rows;
                try
                {
                    rows = CsvResultLogger.ReadRows(path);
                }
                catch
                {
                    continue;
                }

                for (int i = 0; i < rows.Count; i++)
                {
                    var row = rows[i];
                    if (!row.TryGetValue("EVM_RMS_dB", out string evmStr) || string.IsNullOrWhiteSpace(evmStr))
                        continue;
                    if (!double.TryParse(evmStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double evm))
                        continue;

                    DateTime? ts = null;
                    if (row.TryGetValue("TimestampUtc", out string tsStr)
                        && DateTime.TryParse(tsStr, null, DateTimeStyles.RoundtripKind, out DateTime t))
                        ts = t;

                    list.Add(new EvmReportSample(path, i, ts, evm));
                }
            }

            list.Sort(CompareSampleOrder);
            return list;
        }

        static int CompareSampleOrder(EvmReportSample a, EvmReportSample b)
        {
            int c = string.Compare(a.FullPath, b.FullPath, StringComparison.OrdinalIgnoreCase);
            if (c != 0)
                return c;
            return a.RowIndex.CompareTo(b.RowIndex);
        }
    }
}
