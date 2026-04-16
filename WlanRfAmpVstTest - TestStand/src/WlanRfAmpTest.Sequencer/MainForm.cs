using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WlanRfAmpTest.Core;
using WlanRfAmpTest.Instrument;

namespace WlanRfAmpTest.Sequencer
{
    public sealed class MainForm : Form
    {
        enum RowPhase
        {
            Pending,
            Running,
            Pass,
            Fail,
            Stopped
        }

        readonly TextBox _catalogPath = new TextBox();
        readonly TextBox _resultsFolder = new TextBox();
        readonly TextBox _resource = new TextBox();
        readonly CheckBox _band24 = new CheckBox();
        readonly CheckBox _band5 = new CheckBox();
        readonly CheckBox _orderingFbs = new CheckBox();
        readonly CheckBox _bw20 = new CheckBox();
        readonly CheckBox _bw40 = new CheckBox();
        readonly CheckBox _bw80 = new CheckBox();
        readonly CheckBox _stdAc = new CheckBox();
        readonly CheckBox _stdAx = new CheckBox();
        readonly CheckBox _measEvmTxp = new CheckBox();
        readonly CheckBox _measSem = new CheckBox();
        readonly Button _browseCatalog = new Button();
        readonly Button _browseResultsFolder = new Button();
        readonly Button _writeTsSeq = new Button();
        readonly Button _writeTsBundle = new Button();
        readonly Button _start = new Button();
        readonly Button _stop = new Button();
        readonly Button _template = new Button();
        readonly ProgressBar _progress = new ProgressBar();
        readonly Label _status = new Label();
        readonly Label _runMetrics = new Label();
        readonly Label _elapsedLabel = new Label();
        readonly TableLayoutPanel _progressPanel = new TableLayoutPanel();
        readonly SplitContainer _mainSplit = new SplitContainer();
        readonly SplitContainer _bottomSplit = new SplitContainer();
        readonly DataGridView _grid = new DataGridView();
        readonly TextBox _log = new TextBox();
        readonly Stopwatch _runStopwatch = new Stopwatch();
        readonly System.Windows.Forms.Timer _elapsedTimer = new System.Windows.Forms.Timer();

        CancellationTokenSource? _cts;
        SequencerEngine? _engine;
        int _planTotal;
        int _completedCount;
        bool _sequencerRunning;

        public MainForm()
        {
            Text = "WLAN RF Amplifier — Sequencer (Agent 1)";
            Width = 1440;
            Height = 900;
            MinimumSize = new Size(960, 600);
            StartPosition = FormStartPosition.CenterScreen;
            UiTheme.ApplyForm(this);

            _band24.Text = "2.4 GHz (2.4–2.6 GHz, 20 MHz steps)";
            _band24.Checked = true;
            _band24.AutoSize = true;
            _band24.ForeColor = UiTheme.Text;

            _band5.Text = "5 GHz (5.0–5.2 GHz, 20 MHz steps)";
            _band5.Checked = true;
            _band5.AutoSize = true;
            _band5.ForeColor = UiTheme.Text;

            _bw20.Text = "20 MHz";
            _bw20.Checked = true;
            _bw20.AutoSize = true;
            _bw20.ForeColor = UiTheme.Text;
            _bw40.Text = "40 MHz";
            _bw40.Checked = true;
            _bw40.AutoSize = true;
            _bw40.ForeColor = UiTheme.Text;
            _bw80.Text = "80 MHz";
            _bw80.Checked = true;
            _bw80.AutoSize = true;
            _bw80.ForeColor = UiTheme.Text;

            _stdAc.Text = "802.11ac";
            _stdAc.Checked = true;
            _stdAc.AutoSize = true;
            _stdAc.ForeColor = UiTheme.Text;
            _stdAx.Text = "802.11ax";
            _stdAx.Checked = true;
            _stdAx.AutoSize = true;
            _stdAx.ForeColor = UiTheme.Text;

            _measEvmTxp.Text = "EVM + TxP (composite)";
            _measEvmTxp.Checked = true;
            _measEvmTxp.AutoSize = true;
            _measEvmTxp.ForeColor = UiTheme.Text;
            _measSem.Text = "SEM";
            _measSem.Checked = true;
            _measSem.AutoSize = true;
            _measSem.ForeColor = UiTheme.Text;

            _orderingFbs.Text = "Time-optimized order: frequency → bandwidth → standard (LO-stable)";
            _orderingFbs.AutoSize = true;
            _orderingFbs.ForeColor = UiTheme.Text;
            _orderingFbs.Checked = false;

            var lblRes = new Label { Text = "VST resource name:", AutoSize = true, ForeColor = UiTheme.Text };
            _resource.Text = "5841";
            UiTheme.StyleTextBox(_resource);
            _resource.Width = 120;

            var lblCat = new Label { Text = "Waveform catalog (JSON):", AutoSize = true, ForeColor = UiTheme.Text };
            UiTheme.StyleTextBox(_catalogPath);
            _catalogPath.Width = 520;

            var lblCsv = new Label { Text = "Results folder:", AutoSize = true, ForeColor = UiTheme.Text };
            UiTheme.StyleTextBox(_resultsFolder);
            _resultsFolder.Width = 520;

            _browseCatalog.Text = "Browse…";
            _browseResultsFolder.Text = "Browse…";
            UiTheme.StyleButton(_browseCatalog);
            UiTheme.StyleButton(_browseResultsFolder);
            _browseCatalog.Click += (_, _) => BrowseFile(_catalogPath, "JSON|*.json|All|*.*");
            _browseResultsFolder.Click += (_, _) => BrowseFolder(_resultsFolder);

            _start.Text = "Run sequencer";
            _stop.Text = "Stop";
            _template.Text = "Create catalog template";
            UiTheme.StyleButton(_start);
            UiTheme.StyleButton(_stop);
            UiTheme.StyleButton(_template);
            _stop.Enabled = false;

            _start.Click += async (_, _) => await RunAsync().ConfigureAwait(true);
            _stop.Click += (_, _) => _cts?.Cancel();
            _template.Click += (_, _) =>
            {
                using var d = new SaveFileDialog { Filter = "JSON|*.json", FileName = "waveforms.json" };
                if (d.ShowDialog() == DialogResult.OK)
                {
                    WaveformCatalog.WriteTemplate(d.FileName);
                    _catalogPath.Text = d.FileName;
                    AppendLog("Template written to " + d.FileName);
                }
            };

            _progress.Style = ProgressBarStyle.Continuous;
            _progress.Minimum = 0;
            _progress.Maximum = 100;
            _progress.Dock = DockStyle.Fill;
            _progress.Margin = new Padding(0, 4, 8, 4);
            _progress.BackColor = UiTheme.Panel;

            _status.AutoSize = true;
            _status.ForeColor = UiTheme.Accent;
            _status.Font = new Font(Font, FontStyle.Bold);
            _status.MaximumSize = new Size(1040, 0);

            _runMetrics.AutoSize = true;
            _runMetrics.ForeColor = UiTheme.Text;
            _runMetrics.Font = new Font(Font, FontStyle.Bold);
            _runMetrics.Text = "Completed 0 / 0 (0%)";

            _elapsedLabel.AutoSize = true;
            _elapsedLabel.ForeColor = UiTheme.Muted;
            _elapsedLabel.Font = new Font(Font.FontFamily, 9f);
            _elapsedLabel.Text = "Elapsed 00:00:00";

            var metricStack = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoSize = true,
                Padding = new Padding(8, 4, 0, 4)
            };
            metricStack.Controls.Add(_runMetrics);
            metricStack.Controls.Add(_elapsedLabel);

            _progressPanel.ColumnCount = 2;
            _progressPanel.RowCount = 1;
            _progressPanel.Dock = DockStyle.Fill;
            _progressPanel.AutoSize = true;
            _progressPanel.Padding = new Padding(0, 4, 0, 4);
            _progressPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72f));
            _progressPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28f));
            _progressPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56f));
            _progressPanel.Controls.Add(_progress, 0, 0);
            _progressPanel.Controls.Add(metricStack, 1, 0);

            _elapsedTimer.Interval = 400;
            _elapsedTimer.Tick += (_, _) => TickElapsed();

            UiTheme.StyleList(_grid);
            _grid.ReadOnly = true;
            _grid.AllowUserToAddRows = false;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.MultiSelect = false;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.RowHeadersWidth = 36;
            _grid.Columns.Add("Idx", "#");
            _grid.Columns.Add("Status", "Status");
            _grid.Columns.Add("Band", "Band");
            _grid.Columns.Add("Freq", "Frequency");
            _grid.Columns.Add("Std", "Standard");
            _grid.Columns.Add("BW", "Bandwidth");
            _grid.Columns.Add("EVM", "EVM dB");
            _grid.Columns.Add("TxP", "TxP dBm");
            _grid.Columns.Add("SEM", "SEM min dB");
            _grid.Columns.Add("Pass", "Pass");
            _grid.Columns["Idx"].FillWeight = 35;
            _grid.Columns["Status"].MinimumWidth = 72;
            _grid.Columns["Status"].FillWeight = 55;
            _grid.Columns["Band"].FillWeight = 45;
            _grid.Columns["Freq"].FillWeight = 58;
            _grid.Columns["Std"].FillWeight = 55;
            _grid.Columns["BW"].FillWeight = 40;
            _grid.Columns["EVM"].FillWeight = 50;
            _grid.Columns["TxP"].FillWeight = 50;
            _grid.Columns["SEM"].FillWeight = 50;
            _grid.Columns["Pass"].FillWeight = 40;

            var doubleBufferedProp = typeof(DataGridView).GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            doubleBufferedProp?.SetValue(_grid, true, null);

            _log.Multiline = true;
            _log.ReadOnly = true;
            _log.ScrollBars = ScrollBars.Both;
            _log.Dock = DockStyle.Fill;
            _log.Font = new Font("Consolas", 9f);
            UiTheme.StyleTextBox(_log);

            _grid.Dock = DockStyle.Fill;

            var inputs = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 1,
                Dock = DockStyle.Top,
                Padding = new Padding(4, 4, 4, 8)
            };
            var lblRfb = new Label { Text = "RF bands:", AutoSize = true, ForeColor = UiTheme.Text, MinimumSize = new Size(72, 0) };
            var lblBw = new Label { Text = "Channel BW:", AutoSize = true, ForeColor = UiTheme.Text, MinimumSize = new Size(88, 0) };
            var lblStd = new Label { Text = "WLAN std:", AutoSize = true, ForeColor = UiTheme.Text, MinimumSize = new Size(72, 0) };
            inputs.Controls.Add(MakeFlow(lblRfb, _band24, _band5, lblBw, _bw20, _bw40, _bw80, lblStd, _stdAc, _stdAx), 0, 0);

            var lblMeas = new Label { Text = "Measurements:", AutoSize = true, ForeColor = UiTheme.Text, MinimumSize = new Size(88, 0) };
            inputs.Controls.Add(MakeFlow(lblMeas, _measEvmTxp, _measSem, _orderingFbs), 0, 1);
            inputs.Controls.Add(MakeFlow(lblRes, _resource), 0, 2);
            inputs.Controls.Add(MakeFlow(lblCat, _catalogPath, _browseCatalog, _template), 0, 3);
            inputs.Controls.Add(MakeFlow(lblCsv, _resultsFolder, _browseResultsFolder), 0, 4);

            var lblTsHdr = new Label { Text = "TestStand — generate sequence files:", AutoSize = true, ForeColor = UiTheme.Muted };

            _writeTsSeq.Text = "Write .seq template (API)";
            UiTheme.StyleButton(_writeTsSeq);
            _writeTsSeq.Click += (_, _) => WriteTsSeqTemplate();

            _writeTsBundle.Text = "Write .seq bundle (loops + .NET)";
            UiTheme.StyleButton(_writeTsBundle);
            _writeTsBundle.Click += (_, _) => WriteTsSeqBundle();

            inputs.Controls.Add(MakeFlow(lblTsHdr, _writeTsSeq, _writeTsBundle), 0, 5);

            inputs.Controls.Add(MakeFlow(_start, _stop), 0, 6);
            inputs.Controls.Add(_status, 0, 7);
            inputs.Controls.Add(_progressPanel, 0, 8);

            var inputHost = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = UiTheme.Back,
                Padding = new Padding(8, 8, 8, 0)
            };
            inputHost.Controls.Add(inputs);

            _mainSplit.Dock = DockStyle.Fill;
            _mainSplit.Orientation = Orientation.Horizontal;
            _mainSplit.Panel1MinSize = 160;
            _mainSplit.SplitterWidth = 6;
            _mainSplit.BackColor = UiTheme.Panel;
            _mainSplit.Panel1.BackColor = UiTheme.Back;
            _mainSplit.Panel2.BackColor = UiTheme.Back;
            _mainSplit.Panel1.Controls.Add(inputHost);

            _bottomSplit.Dock = DockStyle.Fill;
            _bottomSplit.Orientation = Orientation.Horizontal;
            _bottomSplit.Panel1MinSize = 120;
            _bottomSplit.Panel2MinSize = 56;
            _bottomSplit.SplitterWidth = 6;
            _bottomSplit.BackColor = UiTheme.Panel;
            _bottomSplit.Panel1.BackColor = UiTheme.Back;
            _bottomSplit.Panel2.BackColor = UiTheme.Back;
            _bottomSplit.Panel1.Controls.Add(_grid);
            _bottomSplit.Panel2.Controls.Add(_log);
            _mainSplit.Panel2.Controls.Add(_bottomSplit);

            Controls.Add(_mainSplit);
            EventHandler? initSplit = null;
            initSplit = (_, _) =>
            {
                Shown -= initSplit;
                InitializeSplitterLayout();
            };
            Shown += initSplit;

            string def = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WlanRfAmpVstTest");
            Directory.CreateDirectory(def);
            _resultsFolder.Text = def;
            _catalogPath.Text = Path.Combine(def, "waveforms.json");
        }

        void InitializeSplitterLayout()
        {
            if (_mainSplit.Height < 80 || _bottomSplit.Height < 80)
                return;
            int top = _mainSplit.Height / 3;
            top = Math.Max(_mainSplit.Panel1MinSize + 8, top);
            top = Math.Min(top, _mainSplit.Height - _mainSplit.Panel2MinSize - 24);
            _mainSplit.SplitterDistance = top;

            int logH = Math.Min(180, Math.Max(100, _bottomSplit.Height / 5));
            int dist = _bottomSplit.Height - logH - _bottomSplit.SplitterWidth;
            _bottomSplit.SplitterDistance = Math.Max(_bottomSplit.Panel1MinSize, dist);
        }

        static FlowLayoutPanel MakeFlow(params Control[] c)
        {
            var f = new FlowLayoutPanel
            {
                AutoSize = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(0, 0, 0, 4)
            };
            foreach (var x in c)
                f.Controls.Add(x);
            return f;
        }

        void BrowseFile(TextBox target, string filter)
        {
            using var d = new OpenFileDialog { Filter = filter };
            if (d.ShowDialog() == DialogResult.OK)
                target.Text = d.FileName;
        }

        void BrowseFolder(TextBox target)
        {
            using var d = new FolderBrowserDialog
            {
                Description = "Choose folder for sequencer result CSV files (one unique file per run)."
            };
            if (!string.IsNullOrWhiteSpace(target.Text) && Directory.Exists(target.Text.Trim()))
                d.SelectedPath = Path.GetFullPath(target.Text.Trim());
            if (d.ShowDialog() == DialogResult.OK)
                target.Text = d.SelectedPath;
        }

        /// <summary>Resolves a unique CSV path: <c>wlan_amp_results_yyyyMMdd_HHmmss.csv</c> (same base name as legacy single-file runs).</summary>
        static string AllocateUniqueResultCsvPath(string resultsFolder)
        {
            if (string.IsNullOrWhiteSpace(resultsFolder))
                throw new ArgumentException("Results folder is required.", nameof(resultsFolder));

            string dir = Path.GetFullPath(resultsFolder.Trim());
            Directory.CreateDirectory(dir);

            string stamp = DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture);
            string path = Path.Combine(dir, "wlan_amp_results_" + stamp + ".csv");
            if (!File.Exists(path))
                return path;

            for (int i = 1; i < 1000; i++)
            {
                path = Path.Combine(dir, string.Format(CultureInfo.InvariantCulture, "wlan_amp_results_{0}_{1}.csv", stamp, i));
                if (!File.Exists(path))
                    return path;
            }

            throw new IOException("Could not allocate a unique result file name under: " + dir);
        }

        /// <summary>Default CSV file name embedded in generated TestStand sequences (single placeholder path).</summary>
        static string DefaultCsvPathForTestStandSnapshot(string resultsFolder)
        {
            if (string.IsNullOrWhiteSpace(resultsFolder))
                return "";
            string dir = Path.GetFullPath(resultsFolder.Trim());
            return Path.Combine(dir, "wlan_amp_results.csv");
        }

        void WriteTsSeqTemplate()
        {
            using var d = new SaveFileDialog { Filter = "TestStand sequence|*.seq", FileName = "WlanHook_MainSequence.seq" };
            if (d.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                TestStandSequenceFileFactory.Create(d.FileName);
                AppendLog("TestStand sequence written: " + d.FileName);
                MessageBox.Show(this, "Sequence file created (MainSequence + WLAN parameters).\n\n" + d.FileName, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppendLog(ex.ToString());
            }
        }

        void WriteTsSeqBundle()
        {
            if (!File.Exists(_catalogPath.Text))
            {
                MessageBox.Show(this, "Waveform catalog file not found. Generate a template or pick an existing JSON.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateSweepSelection(out string badSel))
            {
                MessageBox.Show(this, badSel, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var snapshot = BuildTestStandGenerationSnapshotFromUi();
            if (!snapshot.TryComputeTotalPointCount(out int total, out string computeErr))
            {
                MessageBox.Show(this, computeErr, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            snapshot.TotalPointCount = total;

            using var d = new SaveFileDialog { Filter = "TestStand sequence|*.seq", FileName = "WlanRfAmpTest_Bundle.seq" };
            if (d.ShowDialog() != DialogResult.OK)
                return;
            string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "";
            string defaultDll = Path.Combine(exeDir, "WlanRfAmpTest.Instrument.dll");
            string dllPath = defaultDll;
            if (!File.Exists(dllPath))
            {
                using var od = new OpenFileDialog
                {
                    Filter = "Instrument assembly|WlanRfAmpTest.Instrument.dll|All files|*.*",
                    Title = "Select WlanRfAmpTest.Instrument.dll (build output)"
                };
                if (od.ShowDialog() != DialogResult.OK)
                    return;
                dllPath = od.FileName;
            }

            try
            {
                TestStandSequenceFileFactory.CreateWlanInstrumentBundle(d.FileName, dllPath, snapshot);
                AppendLog("TestStand bundle written: " + d.FileName + " (Instrument DLL: " + dllPath + ", points: " + total + ")");
                MessageBox.Show(this,
                    "Sequence file created using the current catalog path, CSV path, resource, bands, bandwidths, standards, measurement options, and sweep ordering from this window.\n" +
                    "Main sequence: nested band/frequency/standard/bandwidth loops with Numeric Limit Test steps for EVM, TxP, SEM, and aggregate pass (" + total + " points, same order as Run).\n.NET Adapter DLL:\n" + dllPath + "\n\n" + d.FileName,
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppendLog(ex.ToString());
            }
        }

        TestStandSequenceGenerationSnapshot BuildTestStandGenerationSnapshotFromUi()
        {
            return new TestStandSequenceGenerationSnapshot
            {
                CatalogPath = _catalogPath.Text.Trim(),
                CsvPath = DefaultCsvPathForTestStandSnapshot(_resultsFolder.Text),
                ResourceName = _resource.Text.Trim(),
                OptionsString = "",
                IncludeBand24 = _band24.Checked,
                IncludeBand5 = _band5.Checked,
                Bw20 = _bw20.Checked,
                Bw40 = _bw40.Checked,
                Bw80 = _bw80.Checked,
                StdAc = _stdAc.Checked,
                StdAx = _stdAx.Checked,
                RunCompositeEvmTxp = _measEvmTxp.Checked,
                RunSem = _measSem.Checked,
                SweepOrdering = _orderingFbs.Checked ? TestSweepOrdering.FrequencyBandwidthStandard : TestSweepOrdering.Default,
                TotalPointCount = 0
            };
        }

        void AppendLog(string line)
        {
            if (_log.InvokeRequired)
                _log.Invoke(new Action(() => AppendLog(line)));
            else
                _log.AppendText(line + Environment.NewLine);
        }

        void TickElapsed()
        {
            if (!_sequencerRunning)
                return;
            _elapsedLabel.Text = "Elapsed " + FormatElapsed(_runStopwatch.Elapsed);
        }

        static string FormatElapsed(TimeSpan t)
        {
            if (t.TotalHours >= 1)
                return string.Format(CultureInfo.InvariantCulture, "{0}:{1:D2}:{2:D2}", (int)t.TotalHours, t.Minutes, t.Seconds);
            return string.Format(CultureInfo.InvariantCulture, "{0:D2}:{1:D2}", (int)t.TotalMinutes, t.Seconds);
        }

        void UpdateMetricsLabel(int completed, int total)
        {
            if (total <= 0)
            {
                _runMetrics.Text = "Completed 0 / 0 (0%)";
                return;
            }
            double pct = 100.0 * completed / total;
            _runMetrics.Text = string.Format(CultureInfo.InvariantCulture,
                "Completed {0} / {1} ({2:0.#}%)", completed, total, pct);
        }

        static void ApplyRowPhase(DataGridViewRow gr, RowPhase phase)
        {
            switch (phase)
            {
                case RowPhase.Pending:
                    gr.DefaultCellStyle.BackColor = UiTheme.Panel;
                    gr.DefaultCellStyle.ForeColor = UiTheme.Muted;
                    gr.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 80, 120);
                    break;
                case RowPhase.Running:
                    gr.DefaultCellStyle.BackColor = Color.FromArgb(52, 62, 88);
                    gr.DefaultCellStyle.ForeColor = UiTheme.Text;
                    gr.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 90, 130);
                    break;
                case RowPhase.Pass:
                    gr.DefaultCellStyle.BackColor = Color.FromArgb(38, 58, 48);
                    gr.DefaultCellStyle.ForeColor = UiTheme.Text;
                    gr.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 85, 65);
                    break;
                case RowPhase.Fail:
                    gr.DefaultCellStyle.BackColor = Color.FromArgb(58, 42, 42);
                    gr.DefaultCellStyle.ForeColor = UiTheme.Text;
                    gr.DefaultCellStyle.SelectionBackColor = Color.FromArgb(90, 55, 55);
                    break;
                case RowPhase.Stopped:
                    gr.DefaultCellStyle.BackColor = Color.FromArgb(48, 46, 40);
                    gr.DefaultCellStyle.ForeColor = UiTheme.Muted;
                    gr.DefaultCellStyle.SelectionBackColor = Color.FromArgb(65, 62, 55);
                    break;
            }
        }

        void PrepopulateGrid(IReadOnlyList<TestPoint> plan)
        {
            _grid.Rows.Clear();
            var inv = CultureInfo.InvariantCulture;
            foreach (var pt in plan)
            {
                string freq = ScientificNumberFormat.FormatSi(pt.CenterFrequencyHz, "Hz");
                int r = _grid.Rows.Add(
                    pt.Index.ToString(),
                    "Pending",
                    pt.BandLabel,
                    freq,
                    pt.StandardLabel,
                    ScientificNumberFormat.FormatSi(pt.BandwidthMHz * 1e6, "Hz"),
                    "—",
                    "—",
                    "—",
                    "—");
                ApplyRowPhase(_grid.Rows[r], RowPhase.Pending);
            }
        }

        void ScrollRowIntoView(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _grid.Rows.Count)
                return;
            try
            {
                _grid.ClearSelection();
                _grid.Rows[rowIndex].Selected = true;
                int first = Math.Max(0, rowIndex - 4);
                if (first < _grid.Rows.Count)
                    _grid.FirstDisplayedScrollingRowIndex = first;
            }
            catch
            {
                /* ignore layout race */
            }
        }

        void OnProgressUi(int index, int total, string msg)
        {
            _status.Text = msg;
            UpdateMetricsLabel(index, total);
            if (index >= 0 && index < _grid.Rows.Count)
            {
                _grid.Rows[index].Cells["Status"].Value = "Running";
                ApplyRowPhase(_grid.Rows[index], RowPhase.Running);
                ScrollRowIntoView(index);
            }
        }

        void OnRowCompletedUi(MeasurementRow row, int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _grid.Rows.Count)
                return;
            var inv = CultureInfo.InvariantCulture;
            var gr = _grid.Rows[rowIndex];
            string freq = ScientificNumberFormat.FormatSi(row.CenterFrequencyHz, "Hz");
            gr.Cells["Idx"].Value = row.TestIndex.ToString(inv);
            gr.Cells["Band"].Value = row.Band;
            gr.Cells["Freq"].Value = freq;
            gr.Cells["Std"].Value = row.Standard;
            gr.Cells["BW"].Value = ScientificNumberFormat.FormatSi(row.BandwidthMHz * 1e6, "Hz");
            gr.Cells["EVM"].Value = row.EvmRmsDb is double e && !double.IsNaN(e) && !double.IsInfinity(e)
                ? ScientificNumberFormat.FormatDb(e, "dB")
                : "—";
            gr.Cells["TxP"].Value = row.TxpAverageDbm is double p && !double.IsNaN(p) && !double.IsInfinity(p)
                ? ScientificNumberFormat.FormatDb(p, "dBm")
                : "—";
            gr.Cells["SEM"].Value = row.SemMinMarginDb is double s && !double.IsNaN(s) && !double.IsInfinity(s)
                ? ScientificNumberFormat.FormatDb(s, "dB")
                : "—";
            gr.Cells["Pass"].Value = row.Pass ? "Yes" : "No";

            bool fail = !row.Pass || !string.IsNullOrEmpty(row.Error);
            gr.Cells["Status"].Value = fail ? (string.IsNullOrEmpty(row.Error) ? "Fail" : "Error") : "Pass";
            ApplyRowPhase(gr, fail ? RowPhase.Fail : RowPhase.Pass);

            _progress.Value = Math.Min(_progress.Maximum, _completedCount);
            UpdateMetricsLabel(_completedCount, _planTotal);
        }

        void MarkPendingRowsAsStopped()
        {
            foreach (DataGridViewRow gr in _grid.Rows)
            {
                if (gr.Cells["Status"].Value?.ToString() == "Pending")
                {
                    gr.Cells["Status"].Value = "Stopped";
                    ApplyRowPhase(gr, RowPhase.Stopped);
                }
            }
        }

        static List<int> CollectBandwidths(CheckBox bw20, CheckBox bw40, CheckBox bw80)
        {
            var list = new List<int>();
            if (bw20.Checked)
                list.Add(20);
            if (bw40.Checked)
                list.Add(40);
            if (bw80.Checked)
                list.Add(80);
            return list;
        }

        static List<WlanStandardKind> CollectStandards(CheckBox ac, CheckBox ax)
        {
            var list = new List<WlanStandardKind>();
            if (ac.Checked)
                list.Add(WlanStandardKind.IEEE802_11ac);
            if (ax.Checked)
                list.Add(WlanStandardKind.IEEE802_11ax);
            return list;
        }

        SequencerMeasurementOptions CollectMeasurementOptions()
        {
            return new SequencerMeasurementOptions
            {
                RunCompositeEvmTxp = _measEvmTxp.Checked,
                RunSem = _measSem.Checked
            };
        }

        bool ValidateSweepSelection(out string message)
        {
            if (!_band24.Checked && !_band5.Checked)
            {
                message = "Select at least one RF band (2.4 GHz and/or 5 GHz).";
                return false;
            }

            if (!_bw20.Checked && !_bw40.Checked && !_bw80.Checked)
            {
                message = "Select at least one channel bandwidth (20 / 40 / 80 MHz).";
                return false;
            }

            if (!_stdAc.Checked && !_stdAx.Checked)
            {
                message = "Select at least one WLAN standard (802.11ac and/or 802.11ax).";
                return false;
            }

            if (!_measEvmTxp.Checked && !_measSem.Checked)
            {
                message = "Select at least one measurement (EVM + TxP composite and/or SEM).";
                return false;
            }

            message = "";
            return true;
        }

        async Task RunAsync()
        {
            if (!File.Exists(_catalogPath.Text))
            {
                MessageBox.Show(this, "Waveform catalog file not found. Generate a template or pick an existing JSON.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateSweepSelection(out string badSel))
            {
                MessageBox.Show(this, badSel, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string csvPath;
            try
            {
                csvPath = AllocateUniqueResultCsvPath(_resultsFolder.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Invalid results folder: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IReadOnlyList<TestPoint> plan;
            try
            {
                var cat = WaveformCatalog.FromJsonFile(_catalogPath.Text);
                var bws = CollectBandwidths(_bw20, _bw40, _bw80);
                var stds = CollectStandards(_stdAc, _stdAx);
                plan = TestPlanBuilder.Build(cat, _band24.Checked, _band5.Checked, bws, stds);
                if (plan.Count == 0)
                {
                    MessageBox.Show(this, "No test points match the current sweep selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_orderingFbs.Checked)
                    plan = TestPlanBuilder.ApplyOrdering(plan, TestSweepOrdering.FrequencyBandwidthStandard);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var measOpts = CollectMeasurementOptions();

            _cts = new CancellationTokenSource();
            _engine = new SequencerEngine();
            _start.Enabled = false;
            _stop.Enabled = true;
            _planTotal = plan.Count;
            _completedCount = 0;
            _sequencerRunning = true;

            PrepopulateGrid(plan);

            _progress.Maximum = Math.Max(1, _planTotal);
            _progress.Value = 0;
            UpdateMetricsLabel(0, _planTotal);
            _status.Text = "Starting…";
            _elapsedLabel.Text = "Elapsed 00:00";
            _runStopwatch.Restart();
            _elapsedTimer.Start();
            AppendLog("Result file (this run): " + csvPath);

            var cfg = new WlanRfInstrumentConfig { ResourceName = _resource.Text.Trim() };

            _engine.Progress += (idx, tot, msg) =>
            {
                AppendLog(msg);
                if (InvokeRequired)
                    BeginInvoke(new Action(() => OnProgressUi(idx, tot, msg)));
                else
                    OnProgressUi(idx, tot, msg);
            };

            _engine.RowCompleted += row =>
            {
                int i = _completedCount++;
                if (InvokeRequired)
                    BeginInvoke(new Action(() => OnRowCompletedUi(row, i)));
                else
                    OnRowCompletedUi(row, i);
            };

            bool cancelled = false;
            bool failed = false;

            try
            {
                await _engine.RunAsync(plan, cfg, measOpts, csvPath, _cts.Token).ConfigureAwait(true);
                MessageBox.Show(this, "Sequencer finished. Results saved to:\n" + csvPath, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                cancelled = true;
                AppendLog("Stopped by user.");
            }
            catch (Exception ex)
            {
                failed = true;
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppendLog(ex.ToString());
            }
            finally
            {
                _sequencerRunning = false;
                _elapsedTimer.Stop();
                _runStopwatch.Stop();
                TickElapsed();

                if (cancelled || failed)
                    MarkPendingRowsAsStopped();

                _start.Enabled = true;
                _stop.Enabled = false;
                _cts = null;
                _status.ForeColor = cancelled || failed ? UiTheme.Muted : UiTheme.Accent;
                if (!cancelled && !failed)
                    _status.Text = "Finished " + _planTotal + " test point(s).";
                else if (cancelled)
                    _status.Text = "Cancelled after " + _completedCount + " / " + _planTotal + " point(s).";
            }
        }
    }
}
