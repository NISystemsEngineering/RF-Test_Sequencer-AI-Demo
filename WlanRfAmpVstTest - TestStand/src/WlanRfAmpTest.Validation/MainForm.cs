using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace WlanRfAmpTest.Validation
{
    public sealed class MainForm : Form
    {
        readonly TextBox _baseline = new TextBox { Width = 520 };
        readonly TextBox _candidate = new TextBox { Width = 520 };
        readonly TextBox _sequencerExe = new TextBox { Width = 520 };
        readonly TextBox _catalog = new TextBox { Width = 520 };
        readonly TextBox _outCsv = new TextBox { Width = 520 };
        readonly TextBox _tolEvm = new TextBox { Width = 80, Text = "0.5" };
        readonly TextBox _tolTxp = new TextBox { Width = 80, Text = "0.5" };
        readonly TextBox _tolSem = new TextBox { Width = 80, Text = "0.5" };
        readonly CheckBox _headlessFbs = new CheckBox { Text = "Use --fbs (frequency → BW → standard) when running sequencer", AutoSize = true, ForeColor = Color.FromArgb(200, 200, 200) };
        readonly TextBox _report = new TextBox { Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Both };

        public MainForm()
        {
            Text = "WLAN RF Amplifier — Validation (Agent 3)";
            Width = 1100;
            Height = 820;
            MinimumSize = new Size(800, 520);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(24, 26, 30);
            ForeColor = Color.FromArgb(235, 237, 240);
            Font = new Font("Segoe UI", 10f);

            void Style(TextBox t) { t.BackColor = Color.FromArgb(40, 44, 52); t.ForeColor = ForeColor; t.BorderStyle = BorderStyle.FixedSingle; }
            Style(_baseline);
            Style(_candidate);
            Style(_sequencerExe);
            Style(_catalog);
            Style(_outCsv);
            Style(_tolEvm);
            Style(_tolTxp);
            Style(_tolSem);
            Style(_report);
            _report.Font = new Font("Consolas", 9f);
            _report.Dock = DockStyle.Fill;

            var btnB1 = new Button { Text = "Browse…" };
            var btnB2 = new Button { Text = "Browse…" };
            var btnB3 = new Button { Text = "Browse…" };
            var btnB4 = new Button { Text = "Browse…" };
            var btnB5 = new Button { Text = "Browse…" };
            foreach (Button b in new[] { btnB1, btnB2, btnB3, btnB4, btnB5 })
                StyleValidationButton(b, Color.FromArgb(44, 48, 58));

            btnB1.Click += (_, _) => BrowseOpen(_baseline);
            btnB2.Click += (_, _) => BrowseOpen(_candidate);
            btnB3.Click += (_, _) => BrowseOpen(_sequencerExe);
            btnB4.Click += (_, _) => BrowseOpen(_catalog);
            btnB5.Click += (_, _) => BrowseSave(_outCsv);

            var compare = new Button { Text = "Compare CSVs (regression)" };
            StyleValidationButton(compare, Color.FromArgb(60, 120, 100));
            compare.Click += (_, _) => RunCompare();

            var runSeq = new Button { Text = "Run headless sequencer" };
            StyleValidationButton(runSeq, Color.FromArgb(50, 90, 130));
            runSeq.Click += (_, _) => RunSequencer();

            _sequencerExe.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "WlanRfAmpTest.Sequencer", "bin", "x64", "Debug", "net48", "WlanRfAmpTest.Sequencer.exe");
            string doc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WlanRfAmpVstTest");
            _catalog.Text = Path.Combine(doc, "waveforms.json");
            _outCsv.Text = Path.Combine(doc, "wlan_amp_candidate.csv");

            var root = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, Padding = new Padding(12) };
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(MakeRow("Gold / baseline CSV", _baseline, btnB1), 0, 0);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(MakeRow("New / candidate CSV", _candidate, btnB2), 0, 1);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(MakeRow("Tolerances: EVM (dB)", _tolEvm, new Label { Text = "TxP (dB)", AutoSize = true }, _tolTxp, new Label { Text = "SEM (dB)", AutoSize = true }, _tolSem, compare), 0, 2);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(new Label { Text = "— Or capture a new run —", AutoSize = true, ForeColor = Color.Gray }, 0, 3);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(MakeRow("Sequencer.exe", _sequencerExe, btnB3), 0, 4);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(MakeRow("waveforms.json", _catalog, btnB4), 0, 5);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(MakeRow("Output CSV", _outCsv, btnB5), 0, 6);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(_headlessFbs, 0, 7);
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.Controls.Add(MakeRow(runSeq), 0, 8);
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            var reportHost = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 10, 0, 0) };
            var reportLabel = new Label
            {
                Text = "Comparison output (scroll for full report)",
                AutoSize = true,
                ForeColor = Color.FromArgb(180, 180, 190),
                Dock = DockStyle.Top,
                Padding = new Padding(0, 0, 0, 6)
            };
            reportHost.Controls.Add(reportLabel);
            reportHost.Controls.Add(_report);
            root.Controls.Add(reportHost, 0, 9);

            Controls.Add(root);
        }

        static void StyleValidationButton(Button b, Color back)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = Color.FromArgb(100, 110, 130);
            b.ForeColor = Color.FromArgb(235, 237, 240);
            b.BackColor = back;
            b.Cursor = Cursors.Hand;
            b.UseCompatibleTextRendering = false;
            b.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
            b.AutoSize = true;
            b.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            b.Padding = new Padding(10, 5, 10, 5);
            b.Margin = new Padding(3, 2, 3, 2);
            b.MinimumSize = new Size(0, 26);
        }

        static FlowLayoutPanel MakeRow(string label, params Control[] rest)
        {
            var f = new FlowLayoutPanel { AutoSize = true, WrapContents = true, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 0, 0, 4) };
            f.Controls.Add(new Label { Text = label + ":", AutoSize = true, ForeColor = Color.FromArgb(235, 237, 240), MinimumSize = new Size(160, 0) });
            foreach (var x in rest)
                f.Controls.Add(x);
            return f;
        }

        static FlowLayoutPanel MakeRow(params Control[] c)
        {
            var f = new FlowLayoutPanel { AutoSize = true, WrapContents = true, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 0, 0, 4) };
            foreach (var x in c)
                f.Controls.Add(x);
            return f;
        }

        void BrowseOpen(TextBox t)
        {
            using var d = new OpenFileDialog { Filter = "All|*.*" };
            if (d.ShowDialog() == DialogResult.OK)
                t.Text = d.FileName;
        }

        void BrowseSave(TextBox t)
        {
            using var d = new SaveFileDialog { Filter = "CSV|*.csv" };
            if (d.ShowDialog() == DialogResult.OK)
                t.Text = d.FileName;
        }

        void RunCompare()
        {
            _report.Clear();
            try
            {
                var cmp = new CsvRegressionComparator
                {
                    EvmToleranceDb = ParseTol(_tolEvm),
                    TxpToleranceDb = ParseTol(_tolTxp),
                    SemMarginToleranceDb = ParseTol(_tolSem)
                };
                var r = cmp.Compare(_baseline.Text.Trim(), _candidate.Text.Trim());
                _report.Text = r.Summarize();
            }
            catch (Exception ex)
            {
                _report.Text = ex.ToString();
            }
        }

        static double ParseTol(TextBox t)
        {
            return double.TryParse(t.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double v) ? v : 0.5;
        }

        void RunSequencer()
        {
            _report.Clear();
            try
            {
                if (!File.Exists(_sequencerExe.Text))
                {
                    _report.Text = "Sequencer.exe not found at: " + _sequencerExe.Text;
                    return;
                }
                string extra = _headlessFbs.Checked ? " --fbs" : "";
                var psi = new ProcessStartInfo
                {
                    FileName = _sequencerExe.Text,
                    Arguments = "--headless --catalog \"" + _catalog.Text + "\" --out \"" + _outCsv.Text + "\"" + extra,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false
                };
                using var p = Process.Start(psi);
                if (p == null)
                {
                    _report.Text = "Failed to start process.";
                    return;
                }
                string o = p.StandardOutput.ReadToEnd();
                string e = p.StandardError.ReadToEnd();
                p.WaitForExit();
                _report.Text = "Exit code: " + p.ExitCode + "\r\n\r\n--- stdout ---\r\n" + o + "\r\n--- stderr ---\r\n" + e;
            }
            catch (Exception ex)
            {
                _report.Text = ex.ToString();
            }
        }
    }
}
