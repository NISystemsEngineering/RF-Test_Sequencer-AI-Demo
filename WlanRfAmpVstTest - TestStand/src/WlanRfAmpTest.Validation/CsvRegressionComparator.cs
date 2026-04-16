using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Validation
{
    public sealed class CsvRegressionComparator
    {
        public double EvmToleranceDb { get; set; } = 0.5;
        public double TxpToleranceDb { get; set; } = 0.5;
        public double SemMarginToleranceDb { get; set; } = 0.5;

        public RegressionReport Compare(string baselineCsvPath, string candidateCsvPath)
        {
            var report = new RegressionReport
            {
                BaselinePath = Path.GetFullPath(baselineCsvPath),
                CandidatePath = Path.GetFullPath(candidateCsvPath),
                EvmToleranceDb = EvmToleranceDb,
                TxpToleranceDb = TxpToleranceDb,
                SemMarginToleranceDb = SemMarginToleranceDb
            };

            var baseRows = CsvResultLogger.ReadRows(baselineCsvPath);
            var candRows = CsvResultLogger.ReadRows(candidateCsvPath);
            report.BaselineRowCount = baseRows.Count;
            report.CandidateRowCount = candRows.Count;

            var byIndex = candRows
                .GroupBy(r => GetInt(r, "TestIndex"))
                .ToDictionary(g => g.Key, g => g.First());

            var baseIndexSet = new HashSet<int>(baseRows.Select(r => GetInt(r, "TestIndex")).Where(i => i >= 0));
            var candIndexSet = new HashSet<int>(candRows.Select(r => GetInt(r, "TestIndex")).Where(i => i >= 0));

            foreach (int idx in candIndexSet)
            {
                if (!baseIndexSet.Contains(idx))
                    report.Errors.Add("Extra candidate row(s) for TestIndex " + idx + " (not present in baseline).");
            }

            foreach (var b in baseRows)
            {
                int idx = GetInt(b, "TestIndex");
                if (idx < 0)
                {
                    report.Errors.Add("Baseline row has invalid TestIndex.");
                    continue;
                }

                if (!byIndex.TryGetValue(idx, out var c))
                {
                    report.Errors.Add("Missing candidate row for TestIndex " + idx);
                    continue;
                }

                report.PairedRowCount++;

                CompareNum("EVM_RMS_dB", idx, b, c, EvmToleranceDb, report);
                CompareNum("TxP_Average_dBm", idx, b, c, TxpToleranceDb, report);
                CompareNum("SEM_MinMargin_dB", idx, b, c, SemMarginToleranceDb, report);

                CompareOptionalMetric("DataEVM_RMS_dB", idx, b, c, report);
                CompareOptionalMetric("PilotEVM_RMS_dB", idx, b, c, report);
                CompareOptionalMetric("TxP_Peak_dBm", idx, b, c, report);

                string passB = GetStr(b, "Pass");
                string passC = GetStr(c, "Pass");
                if (!string.Equals(passB, passC, StringComparison.Ordinal))
                    report.Warnings.Add("TestIndex " + idx + " Pass flag differs: baseline=" + passB + " candidate=" + passC);

                string semB = GetStr(b, "SEM_Status");
                string semC = GetStr(c, "SEM_Status");
                if (!string.Equals(semB, semC, StringComparison.Ordinal))
                    report.Warnings.Add("TestIndex " + idx + " SEM_Status differs: baseline=\"" + semB + "\" candidate=\"" + semC + "\"");

                string errB = GetStr(b, "Error");
                string errC = GetStr(c, "Error");
                bool hasB = !string.IsNullOrWhiteSpace(errB);
                bool hasC = !string.IsNullOrWhiteSpace(errC);
                if (hasB != hasC)
                {
                    report.Warnings.Add("TestIndex " + idx + " Error field presence differs: baseline " + (hasB ? "has" : "empty") +
                                        ", candidate " + (hasC ? "has" : "empty") + ".");
                }
                else if (hasB && hasC && !string.Equals(errB, errC, StringComparison.Ordinal))
                {
                    report.Warnings.Add("TestIndex " + idx + " Error text differs.");
                }

                string ctx = RowContext(b);
                if (!string.IsNullOrEmpty(ctx))
                    report.RowContexts[idx] = ctx;
            }

            return report;
        }

        static string RowContext(Dictionary<string, string> b)
        {
            string band = GetStr(b, "Band");
            string f = GetStr(b, "CenterFrequency_Hz");
            string std = GetStr(b, "Standard");
            string bw = GetStr(b, "Bandwidth_MHz");
            if (string.IsNullOrEmpty(band) && string.IsNullOrEmpty(f))
                return "";
            string freqDisp = "";
            if (double.TryParse(f, NumberStyles.Float, CultureInfo.InvariantCulture, out double hz))
                freqDisp = ScientificNumberFormat.FormatSi(hz, "Hz");
            var parts = new List<string>();
            if (!string.IsNullOrWhiteSpace(band))
                parts.Add(band);
            if (!string.IsNullOrWhiteSpace(freqDisp))
                parts.Add(freqDisp);
            if (!string.IsNullOrWhiteSpace(std))
                parts.Add(std);
            if (!string.IsNullOrWhiteSpace(bw) && double.TryParse(bw, NumberStyles.Float, CultureInfo.InvariantCulture, out double bwMHz))
                parts.Add(ScientificNumberFormat.FormatSi(bwMHz * 1e6, "Hz"));
            return string.Join(" ", parts);
        }

        static void CompareOptionalMetric(string col, int idx, Dictionary<string, string> b, Dictionary<string, string> c, RegressionReport report)
        {
            double? vb = ParseD(GetStr(b, col));
            double? vc = ParseD(GetStr(c, col));
            if (vb.HasValue != vc.HasValue)
                report.Warnings.Add("TestIndex " + idx + ": " + col + " presence mismatch (baseline " + (vb.HasValue ? "numeric" : "empty") +
                                    ", candidate " + (vc.HasValue ? "numeric" : "empty") + ").");
            else if (vb.HasValue && vc.HasValue)
            {
                double d = vc.Value - vb.Value;
                string u = col.IndexOf("dBm", StringComparison.OrdinalIgnoreCase) >= 0 ? "dBm" : "dB";
                string F(double x) => ScientificNumberFormat.FormatDb(x, u);
                report.DetailLines.Add(string.Format(CultureInfo.InvariantCulture,
                    "  TestIndex {0} {1}: baseline={2} candidate={3} (Δ={4})",
                    idx, col, F(vb.Value), F(vc.Value), F(d)));
            }
        }

        static void CompareNum(string col, int idx, Dictionary<string, string> b, Dictionary<string, string> c, double tol, RegressionReport report)
        {
            double? vb = ParseD(GetStr(b, col));
            double? vc = ParseD(GetStr(c, col));
            if (vb.HasValue != vc.HasValue)
            {
                report.Warnings.Add("TestIndex " + idx + ": " + col + " presence mismatch.");
                return;
            }

            if (!vb.HasValue)
                return;

            double delta = vc!.Value - vb.Value;
            double abs = Math.Abs(delta);
            switch (col)
            {
                case "EVM_RMS_dB":
                    if (abs > report.MaxAbsDeltaEvm)
                    {
                        report.MaxAbsDeltaEvm = abs;
                        report.MaxAbsDeltaEvmIndex = idx;
                    }
                    break;
                case "TxP_Average_dBm":
                    if (abs > report.MaxAbsDeltaTxp)
                    {
                        report.MaxAbsDeltaTxp = abs;
                        report.MaxAbsDeltaTxpIndex = idx;
                    }
                    break;
                case "SEM_MinMargin_dB":
                    if (abs > report.MaxAbsDeltaSem)
                    {
                        report.MaxAbsDeltaSem = abs;
                        report.MaxAbsDeltaSemIndex = idx;
                    }
                    break;
            }

            if (abs > tol)
            {
                string u = col.IndexOf("dBm", StringComparison.OrdinalIgnoreCase) >= 0 ? "dBm" : "dB";
                string F(double x) => ScientificNumberFormat.FormatDb(x, u);
                report.Failures.Add(string.Format(CultureInfo.InvariantCulture,
                    "TestIndex {0}: {1} baseline={2} candidate={3}  |Δ|={4}  (tolerance ±{5})",
                    idx, col, F(vb!.Value), F(vc!.Value), F(abs), F(tol)));
            }
        }

        static double? ParseD(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return null;
            return double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v) ? v : (double?)null;
        }

        static int GetInt(Dictionary<string, string> r, string key)
        {
            string s = GetStr(r, key);
            return int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out int v) ? v : -1;
        }

        static string GetStr(Dictionary<string, string> r, string key)
        {
            return r.TryGetValue(key, out var v) ? v.Trim() : "";
        }
    }

    public sealed class RegressionReport
    {
        public string BaselinePath { get; set; } = "";
        public string CandidatePath { get; set; } = "";
        public double EvmToleranceDb { get; set; }
        public double TxpToleranceDb { get; set; }
        public double SemMarginToleranceDb { get; set; }

        public int BaselineRowCount { get; set; }
        public int CandidateRowCount { get; set; }
        public int PairedRowCount { get; set; }

        public double MaxAbsDeltaEvm { get; set; }
        public int MaxAbsDeltaEvmIndex { get; set; } = -1;
        public double MaxAbsDeltaTxp { get; set; }
        public int MaxAbsDeltaTxpIndex { get; set; } = -1;
        public double MaxAbsDeltaSem { get; set; }
        public int MaxAbsDeltaSemIndex { get; set; } = -1;

        public Dictionary<int, string> RowContexts { get; } = new Dictionary<int, string>();

        public List<string> Errors { get; } = new List<string>();
        public List<string> Warnings { get; } = new List<string>();
        public List<string> Failures { get; } = new List<string>();
        public List<string> DetailLines { get; } = new List<string>();

        public bool Success => Errors.Count == 0 && Failures.Count == 0;

        public string Summarize()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=== CSV regression comparison ===");
            sb.AppendLine("Baseline:  " + BaselinePath);
            sb.AppendLine("           (" + BaselineRowCount + " data row(s))");
            sb.AppendLine("Candidate: " + CandidatePath);
            sb.AppendLine("           (" + CandidateRowCount + " data row(s))");
            sb.AppendLine();
            sb.AppendLine("Tolerances (regression gates):");
            sb.AppendLine("  EVM_RMS_dB        ±" + ScientificNumberFormat.FormatDb(EvmToleranceDb, "dB"));
            sb.AppendLine("  TxP_Average_dBm   ±" + ScientificNumberFormat.FormatDb(TxpToleranceDb, "dBm"));
            sb.AppendLine("  SEM_MinMargin_dB  ±" + ScientificNumberFormat.FormatDb(SemMarginToleranceDb, "dB"));
            sb.AppendLine();
            sb.AppendLine("Paired rows (matched TestIndex): " + PairedRowCount);
            sb.AppendLine("Result: " + (Success ? "PASS" : "FAIL") + "  (errors: " + Errors.Count + ", gate failures: " + Failures.Count + ", warnings: " + Warnings.Count + ")");
            sb.AppendLine();

            void AppendSection(string title, List<string> lines)
            {
                sb.AppendLine("--- " + title + " ---");
                if (lines.Count == 0)
                    sb.AppendLine("  (none)");
                else
                {
                    foreach (var e in lines)
                        sb.AppendLine("  " + e);
                }
                sb.AppendLine();
            }

            AppendSection("Errors (missing/extra rows or bad index)", Errors);
            AppendSection("Failures (numeric delta beyond tolerance)", Failures);
            AppendSection("Warnings (Pass, SEM_Status, Error field, optional columns)", Warnings);

            sb.AppendLine("--- Worst |Δ| among gated metrics (paired rows only) ---");
            sb.AppendLine(FormatWorst("EVM_RMS_dB", MaxAbsDeltaEvm, MaxAbsDeltaEvmIndex));
            sb.AppendLine(FormatWorst("TxP_Average_dBm", MaxAbsDeltaTxp, MaxAbsDeltaTxpIndex));
            sb.AppendLine(FormatWorst("SEM_MinMargin_dB", MaxAbsDeltaSem, MaxAbsDeltaSemIndex));
            sb.AppendLine();

            if (Failures.Count > 0)
            {
                sb.AppendLine("--- Failure context (test conditions from baseline) ---");
                var seenIdx = new HashSet<int>();
                foreach (var f in Failures)
                {
                    int idx = TryParseTestIndexFromFailure(f);
                    if (idx >= 0 && seenIdx.Add(idx) && RowContexts.TryGetValue(idx, out var ctx) && !string.IsNullOrEmpty(ctx))
                        sb.AppendLine("  TestIndex " + idx + ": " + ctx);
                }
                sb.AppendLine();
            }

            const int maxDetailLines = 200;
            if (DetailLines.Count > 0)
            {
                sb.AppendLine("--- Optional columns (Data / Pilot EVM, TxP peak): per-row baseline vs candidate ---");
                var sorted = DetailLines.OrderBy(s => s, StringComparer.Ordinal).ToList();
                int show = Math.Min(maxDetailLines, sorted.Count);
                for (int i = 0; i < show; i++)
                    sb.AppendLine(sorted[i]);
                if (sorted.Count > maxDetailLines)
                    sb.AppendLine("  ... " + (sorted.Count - maxDetailLines) + " more line(s) omitted.");
                sb.AppendLine();
            }

            return sb.ToString();
        }

        static int TryParseTestIndexFromFailure(string line)
        {
            int p = line.IndexOf("TestIndex ", StringComparison.Ordinal);
            if (p < 0)
                return -1;
            p += "TestIndex ".Length;
            int end = p;
            while (end < line.Length && char.IsDigit(line[end]))
                end++;
            if (end == p)
                return -1;
            return int.TryParse(line.Substring(p, end - p), NumberStyles.Integer, CultureInfo.InvariantCulture, out int v) ? v : -1;
        }

        static string FormatWorst(string name, double maxAbs, int index)
        {
            if (index < 0 || maxAbs <= 0)
                return "  " + name + ": n/a";
            string u = name.IndexOf("dBm", StringComparison.OrdinalIgnoreCase) >= 0 ? "dBm" : "dB";
            return string.Format(CultureInfo.InvariantCulture, "  {0}: max |Δ| = {1}  (at TestIndex {2})",
                name, ScientificNumberFormat.FormatDb(maxAbs, u), index);
        }
    }
}
