using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WlanRfAmpTest.Core;
using WlanRfAmpTest.Instrument;

namespace WlanRfAmpTest.ModuleRunner
{
    /// <summary>Run EVM, TxP, SEM, or EVM+TxP composite with table, bar chart, and surfaced errors.</summary>
    public sealed partial class MainForm : Form
    {
        readonly Label _status = new Label
        {
            AutoSize = false,
            Height = 28,
            Dock = DockStyle.Top,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(12, 4, 12, 4),
            ForeColor = UiTheme.Accent
        };

        readonly ComboBox _combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 220 };
        readonly TextBox _freqHz = new TextBox { Width = 200 };
        readonly ComboBox _band = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 100 };
        readonly ComboBox _std = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 120 };
        readonly ComboBox _bw = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 80 };
        readonly TextBox _tdms = new TextBox { Width = 480 };
        readonly TextBox _resource = new TextBox { Width = 100 };
        readonly DataGridView _grid = new DataGridView();
        readonly Chart _chart = new Chart();
        readonly TabControl _traceTabs = new TabControl();
        readonly TextBox _log = new TextBox { Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Both };
        readonly Button _btnBrowse = new Button { Text = "Browse TDMS…" };
        readonly Button _run = new Button { Text = "Run measurement" };
        readonly Button _btnSaveCsv = new Button { Text = "Save results to CSV…" };

        MeasurementRow? _lastCsvRow;
        double? _lastDataEvmDb;
        double? _lastPilotEvmDb;

        public MainForm()
        {
            Text = "WLAN RF Amplifier — Measurement modules";
            Width = 960;
            Height = 820;
            StartPosition = FormStartPosition.CenterScreen;
            UiTheme.ApplyForm(this);
            _status.BackColor = UiTheme.Panel;
            _status.Font = new Font(Font, FontStyle.Bold);
            _status.Text = "Ready. Errors are shown here, in the log, and in a message box.";

            _combo.Items.AddRange(new object[]
            {
                "EVM (OFDM ModAcc)",
                "TxP",
                "SEM",
                "EVM + TxP composite"
            });
            _combo.SelectedIndex = 0;
            _combo.SelectedIndexChanged += (_, _) => UpdateInstrumentConfigVisibility();

            _band.Items.AddRange(new object[] { "2.4 GHz", "5 GHz" });
            _band.SelectedIndex = 0;
            _std.Items.AddRange(new object[] { "802.11ac", "802.11ax" });
            _std.SelectedIndex = 1;
            _bw.Items.AddRange(new object[] { "20", "40", "80" });
            _bw.SelectedIndex = 0;

            _freqHz.Text = ScientificNumberFormat.FormatSi(2.412e9, "Hz");
            _resource.Text = "5841";
            _tdms.Text = "C:\\\\Path\\\\To\\\\waveform.tdms";

            UiTheme.StyleTextBox(_freqHz);
            UiTheme.StyleTextBox(_tdms);
            UiTheme.StyleTextBox(_resource);
            UiTheme.StyleTextBox(_log);
            UiTheme.StyleButton(_btnBrowse);
            UiTheme.StyleButton(_run);
            UiTheme.StyleButton(_btnSaveCsv);
            _btnSaveCsv.Enabled = false;

            _log.Dock = DockStyle.Fill;
            _log.Font = new Font("Consolas", 9f);
            _log.WordWrap = true;

            UiTheme.StyleGrid(_grid);
            _grid.Dock = DockStyle.Fill;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.Columns.Add("Metric", "Result name");
            _grid.Columns.Add("Value", "Value");
            _grid.Columns[0].FillWeight = 42;
            _grid.Columns[1].FillWeight = 58;

            SetupChart();

            _btnBrowse.Click += (_, _) =>
            {
                using var d = new OpenFileDialog { Filter = "TDMS|*.tdms|All|*.*" };
                if (d.ShowDialog() == DialogResult.OK)
                    _tdms.Text = d.FileName;
            };

            _run.Click += OnRunClicked;
            _btnSaveCsv.Click += (_, _) => SaveLastResultToCsv();

            var tabs = new TabControl { Dock = DockStyle.Fill };
            var tabTable = new TabPage { Text = "Results table", BackColor = UiTheme.Back, ForeColor = UiTheme.Text };
            tabTable.Controls.Add(_grid);
            var tabChart = new TabPage { Text = "Results chart", BackColor = UiTheme.Back, ForeColor = UiTheme.Text };
            tabChart.Controls.Add(_chart);
            var tabTraces = new TabPage { Text = "RF traces", BackColor = UiTheme.Back, ForeColor = UiTheme.Text };
            _traceTabs.Dock = DockStyle.Fill;
            _traceTabs.BackColor = UiTheme.Back;
            _traceTabs.ForeColor = UiTheme.Text;
            tabTraces.Controls.Add(_traceTabs);
            tabs.TabPages.Add(tabTable);
            tabs.TabPages.Add(tabChart);
            tabs.TabPages.Add(tabTraces);

            var bottomSplit = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
            bottomSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 62f));
            bottomSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 38f));
            bottomSplit.Controls.Add(tabs, 0, 0);
            var logPanel = new Panel { Dock = DockStyle.Fill };
            var logLabel = new Label { Text = "Log / exception detail", Dock = DockStyle.Top, Height = 22, ForeColor = UiTheme.Text, Padding = new Padding(0, 4, 0, 0) };
            logPanel.Controls.Add(logLabel);
            logPanel.Controls.Add(_log);
            bottomSplit.Controls.Add(logPanel, 0, 1);

            var splitMain = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Horizontal,
                SplitterWidth = 6,
                Panel1MinSize = 200,
                Panel2MinSize = 150,
                BackColor = UiTheme.Back
            };

            var scrollTop = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(14, 14, 14, 0),
                BackColor = UiTheme.Back
            };

            var topLayout = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 1,
                Dock = DockStyle.Top,
                Width = 900,
                BackColor = UiTheme.Back
            };
            topLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            topLayout.Controls.Add(_status, 0, 0);
            topLayout.Controls.Add(MakeRow("Module", _combo), 0, 1);
            var cfgPanel = CreateInstrumentConfigPanel();
            cfgPanel.Dock = DockStyle.Top;
            topLayout.Controls.Add(cfgPanel, 0, 2);
            topLayout.Controls.Add(MakeRow("Band", _band, new Label { Text = "Center frequency", AutoSize = true, ForeColor = UiTheme.Text }, _freqHz), 0, 3);
            topLayout.Controls.Add(MakeRow("Standard", _std, new Label { Text = "BW MHz", AutoSize = true, ForeColor = UiTheme.Text }, _bw), 0, 4);
            topLayout.Controls.Add(MakeRow("TDMS waveform", _tdms, _btnBrowse), 0, 5);
            topLayout.Controls.Add(MakeRow("Resource", _resource, _run), 0, 6);
            var csvRow = new FlowLayoutPanel { AutoSize = true, WrapContents = false, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 6, 0, 0) };
            csvRow.Controls.Add(_btnSaveCsv);
            topLayout.Controls.Add(csvRow, 0, 7);

            scrollTop.Controls.Add(topLayout);
            void SyncTopLayoutWidth()
            {
                int w = Math.Max(320, scrollTop.ClientSize.Width - 20);
                topLayout.Width = w;
            }
            scrollTop.SizeChanged += (_, _) => SyncTopLayoutWidth();
            scrollTop.HandleCreated += (_, _) => SyncTopLayoutWidth();
            SyncTopLayoutWidth();

            splitMain.Panel1.Controls.Add(scrollTop);
            splitMain.Panel2.Padding = new Padding(14, 0, 14, 14);
            splitMain.Panel2.Controls.Add(bottomSplit);
            Shown += (_, _) =>
            {
                int h = splitMain.Height;
                if (h <= splitMain.Panel1MinSize + splitMain.Panel2MinSize + splitMain.SplitterWidth)
                    return;
                int want = Math.Min(540, Math.Max(320, (int)(h * 0.48)));
                int maxDist = h - splitMain.Panel2MinSize - splitMain.SplitterWidth;
                splitMain.SplitterDistance = Math.Min(want, maxDist);
            };

            Controls.Add(splitMain);
            UpdateInstrumentConfigVisibility();
            _log.Text = "Tip: If the run appears to do nothing, check TDMS path, resource name, and NI drivers. A timeout will surface as an error below.";
        }

        void SetupChart()
        {
            _chart.Dock = DockStyle.Fill;
            _chart.BackColor = UiTheme.Back;
            _chart.BorderlineColor = UiTheme.Accent;
            _chart.BorderlineDashStyle = ChartDashStyle.Solid;
            _chart.BorderlineWidth = 1;

            var area = new ChartArea("Main");
            area.BackColor = UiTheme.Panel;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(80, 90, 100);
            area.AxisX.LabelStyle.ForeColor = UiTheme.Text;
            area.AxisY.LabelStyle.ForeColor = UiTheme.Text;
            area.AxisX.LineColor = UiTheme.Text;
            area.AxisY.LineColor = UiTheme.Text;
            area.AxisX.MajorTickMark.LineColor = UiTheme.Text;
            area.AxisY.MajorTickMark.LineColor = UiTheme.Text;
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -35;
            area.AxisY.Title = "Value (dB or dBm — see labels)";
            area.AxisY.TitleForeColor = UiTheme.Muted;
            area.AxisY.LabelStyle.Format = ScientificNumberFormat.ChartAxis;
            _chart.ChartAreas.Add(area);

            var series = new Series("Metrics")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(100, 200, 180),
                BorderColor = UiTheme.Accent,
                IsValueShownAsLabel = true,
                LabelForeColor = UiTheme.Text,
                Font = new Font(Font.FontFamily, 8f)
            };
            _chart.Series.Add(series);

            var title = new Title("Numeric results (names under each bar)", Docking.Top, new Font(Font.FontFamily, 10f, FontStyle.Bold), UiTheme.Text);
            _chart.Titles.Add(title);

            var leg = new Legend("L")
            {
                BackColor = Color.Transparent,
                ForeColor = UiTheme.Text,
                Docking = Docking.Bottom,
                LegendStyle = LegendStyle.Row
            };
            _chart.Legends.Add(leg);
            series.Legend = "L";
        }

        async void OnRunClicked(object? sender, EventArgs e)
        {
            try
            {
                await RunAsync().ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                ReportFailure(ex, "Run failed (async)");
            }
        }

        static FlowLayoutPanel MakeRow(string label, params Control[] rest)
        {
            var f = new FlowLayoutPanel { AutoSize = true, WrapContents = true, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 4, 0, 4) };
            f.Controls.Add(new Label { Text = label + ":", AutoSize = true, ForeColor = UiTheme.Text, MinimumSize = new Size(140, 0) });
            foreach (var c in rest)
                f.Controls.Add(c);
            return f;
        }

        static string FmtDb(double v, string unitSuffix) => ScientificNumberFormat.FormatDbOrPlaceholder(v, unitSuffix);

        static string FormatExceptionChain(Exception ex)
        {
            var sb = new StringBuilder();
            for (Exception? e = ex; e != null; e = e.InnerException)
            {
                sb.AppendLine("--- " + e.GetType().FullName + " ---");
                sb.AppendLine(e.Message);
                if (!string.IsNullOrEmpty(e.StackTrace))
                    sb.AppendLine(e.StackTrace);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        void ReportFailure(Exception ex, string headline)
        {
            void Apply()
            {
                string detail = headline + "\r\n\r\n" + FormatExceptionChain(ex);
                _status.ForeColor = Color.FromArgb(255, 140, 120);
                _status.Text = "FAILED: " + ex.GetBaseException().Message;
                _log.Text = detail;
                ClearResultsVisuals();
                MessageBox.Show(this, detail, Text + " — error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (InvokeRequired)
                BeginInvoke(new Action(Apply));
            else
                Apply();
        }

        void ReportSuccess(string shortMessage)
        {
            void Apply()
            {
                _status.ForeColor = UiTheme.Accent;
                _status.Text = shortMessage;
            }
            if (InvokeRequired)
                BeginInvoke(new Action(Apply));
            else
                Apply();
        }

        void ClearResultsVisuals()
        {
            _grid.Rows.Clear();
            _chart.Series["Metrics"].Points.Clear();
            ClearTraceTabs();
            _btnSaveCsv.Enabled = false;
            _lastCsvRow = null;
            _lastDataEvmDb = null;
            _lastPilotEvmDb = null;
        }

        void ClearTraceTabs()
        {
            _traceTabs.TabPages.Clear();
        }

        static ChartArea NewTraceChartArea()
        {
            var area = new ChartArea("Main");
            area.BackColor = UiTheme.Panel;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(60, 70, 80);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(60, 70, 80);
            area.AxisX.LabelStyle.ForeColor = UiTheme.Text;
            area.AxisY.LabelStyle.ForeColor = UiTheme.Text;
            area.AxisX.LineColor = UiTheme.Text;
            area.AxisY.LineColor = UiTheme.Text;
            area.AxisX.MajorTickMark.LineColor = UiTheme.Text;
            area.AxisY.MajorTickMark.LineColor = UiTheme.Text;
            area.AxisX.LabelStyle.Format = ScientificNumberFormat.ChartAxis;
            area.AxisY.LabelStyle.Format = ScientificNumberFormat.ChartAxis;
            return area;
        }

        static TabPage MakeTracePlaceholder(string message)
        {
            var p = new TabPage { Text = "Info", BackColor = UiTheme.Back, ForeColor = UiTheme.Text };
            p.Padding = new Padding(12);
            p.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                Text = message,
                ForeColor = UiTheme.Muted,
                TextAlign = ContentAlignment.TopLeft
            });
            return p;
        }

        static void AppendDecimatedXY(Series series, double[] x, double[] y, int maxPoints)
        {
            if (x.Length != y.Length || x.Length == 0)
                return;
            int n = x.Length;
            int step = Math.Max(1, (n + maxPoints - 1) / maxPoints);
            for (int i = 0; i < n; i += step)
                series.Points.AddXY(x[i], y[i]);
        }

        static double[] LinearX(int count, double x0, double dx)
        {
            var x = new double[count];
            for (int i = 0; i < count; i++)
                x[i] = x0 + i * dx;
            return x;
        }

        TabPage MakeLineTraceTab(string title, string xTitle, string yTitle, double[] x, double[] y)
        {
            var page = new TabPage { Text = title, BackColor = UiTheme.Back };
            var chart = new Chart { Dock = DockStyle.Fill, BackColor = UiTheme.Back };
            var area = NewTraceChartArea();
            area.AxisX.Title = xTitle;
            area.AxisY.Title = yTitle;
            area.AxisX.TitleForeColor = UiTheme.Muted;
            area.AxisY.TitleForeColor = UiTheme.Muted;
            chart.ChartAreas.Add(area);
            var ser = new Series("Trace")
            {
                ChartType = SeriesChartType.FastLine,
                Color = Color.FromArgb(100, 200, 180),
                BorderWidth = 2
            };
            AppendDecimatedXY(ser, x, y, 8000);
            chart.Series.Add(ser);
            chart.Titles.Add(new Title(title, Docking.Top, new Font(Font.FontFamily, 9f, FontStyle.Bold), UiTheme.Text));
            page.Controls.Add(chart);
            return page;
        }

        TabPage MakeSemSpectrumTab(RfmxSpectrumTrace spectrum, RfmxSpectrumTrace? mask)
        {
            var page = new TabPage { Text = "SEM spectrum", BackColor = UiTheme.Back };
            var chart = new Chart { Dock = DockStyle.Fill, BackColor = UiTheme.Back };
            var area = NewTraceChartArea();
            area.AxisX.Title = "Frequency (MHz)";
            area.AxisY.Title = "Level (dBm, RFmx)";
            area.AxisX.TitleForeColor = UiTheme.Muted;
            area.AxisY.TitleForeColor = UiTheme.Muted;
            chart.ChartAreas.Add(area);

            int n = spectrum.Amplitudes.Length;
            var x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = (spectrum.StartFrequencyHz + i * spectrum.FrequencyStepHz) / 1e6;
            var s1 = new Series("Measured") { ChartType = SeriesChartType.FastLine, Color = Color.FromArgb(120, 200, 255), BorderWidth = 2 };
            AppendDecimatedXY(s1, x, spectrum.Amplitudes, 8000);
            chart.Series.Add(s1);

            if (mask != null && mask.Amplitudes.Length > 0)
            {
                int m = mask.Amplitudes.Length;
                var xm = new double[m];
                for (int i = 0; i < m; i++)
                    xm[i] = (mask.StartFrequencyHz + i * mask.FrequencyStepHz) / 1e6;
                var s2 = new Series("Composite mask") { ChartType = SeriesChartType.FastLine, Color = Color.FromArgb(255, 180, 100), BorderWidth = 2 };
                AppendDecimatedXY(s2, xm, mask.Amplitudes, 8000);
                chart.Series.Add(s2);
            }

            chart.Titles.Add(new Title("SEM spectrum and mask", Docking.Top, new Font(Font.FontFamily, 9f, FontStyle.Bold), UiTheme.Text));
            page.Controls.Add(chart);
            return page;
        }

        TabPage MakeConstellationTab(RfmxConstellationTrace? pilot, RfmxConstellationTrace? data)
        {
            var page = new TabPage { Text = "Constellation", BackColor = UiTheme.Back };
            var chart = new Chart { Dock = DockStyle.Fill, BackColor = UiTheme.Back };
            var area = NewTraceChartArea();
            area.AxisX.Title = "I";
            area.AxisY.Title = "Q";
            area.AxisX.TitleForeColor = UiTheme.Muted;
            area.AxisY.TitleForeColor = UiTheme.Muted;
            area.AxisX.MajorGrid.Enabled = true;
            area.AxisY.MajorGrid.Enabled = true;
            chart.ChartAreas.Add(area);

            void AddConst(string name, RfmxConstellationTrace ct, Color col)
            {
                var ser = new Series(name)
                {
                    ChartType = SeriesChartType.Point,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 3,
                    Color = col
                };
                int n = ct.I.Length;
                int step = Math.Max(1, n / 4000);
                for (int i = 0; i < n; i += step)
                    ser.Points.AddXY(ct.I[i], ct.Q[i]);
                chart.Series.Add(ser);
            }

            if (pilot != null && pilot.I.Length > 0)
                AddConst("Pilot", pilot, Color.FromArgb(180, 220, 255));
            if (data != null && data.I.Length > 0)
                AddConst("Data", data, Color.FromArgb(255, 200, 120));

            chart.Titles.Add(new Title("OFDM ModAcc constellation", Docking.Top, new Font(Font.FontFamily, 9f, FontStyle.Bold), UiTheme.Text));
            page.Controls.Add(chart);
            return page;
        }

        void PopulateTraceTabs(WlanRfmxTraceSnapshot? snap)
        {
            ClearTraceTabs();
            if (snap == null)
            {
                _traceTabs.TabPages.Add(MakeTracePlaceholder("No trace snapshot on this result."));
                return;
            }

            bool anyPlot = false;
            if (snap.EvmPerSubcarrierDb != null && snap.EvmPerSubcarrierDb.Values.Length > 0)
            {
                var tr = snap.EvmPerSubcarrierDb;
                double[] x = LinearX(tr.Values.Length, tr.StartTimeSec, tr.SampleSpacingSec);
                _traceTabs.TabPages.Add(MakeLineTraceTab(
                    "EVM / SC",
                    "Subcarrier index (spacing from RFmx)",
                    "RMS EVM per subcarrier (dB or % — RFmx unit)",
                    x,
                    tr.Values));
                anyPlot = true;
            }

            bool hasPilot = snap.PilotConstellation != null && snap.PilotConstellation.I.Length > 0;
            bool hasData = snap.DataConstellation != null && snap.DataConstellation.I.Length > 0;
            if (hasPilot || hasData)
            {
                _traceTabs.TabPages.Add(MakeConstellationTab(
                    hasPilot ? snap.PilotConstellation : null,
                    hasData ? snap.DataConstellation : null));
                anyPlot = true;
            }

            if (snap.SemSpectrum != null && snap.SemSpectrum.Amplitudes.Length > 0)
            {
                _traceTabs.TabPages.Add(MakeSemSpectrumTab(snap.SemSpectrum, snap.SemCompositeMask));
                anyPlot = true;
            }

            if (snap.TxpPowerDbm != null && snap.TxpPowerDbm.Values.Length > 0)
            {
                var tr = snap.TxpPowerDbm;
                double[] x = LinearX(tr.Values.Length, tr.StartTimeSec, tr.SampleSpacingSec);
                _traceTabs.TabPages.Add(MakeLineTraceTab(
                    "TxP trace",
                    "Time (s) from trace start",
                    "Power (dBm)",
                    x,
                    tr.Values));
                anyPlot = true;
            }

            if (!string.IsNullOrEmpty(snap.TraceFetchNote))
                _traceTabs.TabPages.Add(MakeTracePlaceholder("Trace fetch note: " + snap.TraceFetchNote));

            if (!anyPlot && string.IsNullOrEmpty(snap.TraceFetchNote))
                _traceTabs.TabPages.Add(MakeTracePlaceholder("No trace arrays were returned for this module."));
        }

        static bool EvaluatePass(StandaloneMeasurementKind kind, WlanPointMeasurementResult r)
        {
            switch (kind)
            {
                case StandaloneMeasurementKind.Evm:
                    return !double.IsNaN(r.CompositeRmsEvmDb) && !double.IsInfinity(r.CompositeRmsEvmDb);
                case StandaloneMeasurementKind.Txp:
                    return !double.IsNaN(r.AveragePowerDbm) && !double.IsInfinity(r.AveragePowerDbm);
                case StandaloneMeasurementKind.Sem:
                    if (double.IsNaN(r.SemMinMarginDb) || double.IsInfinity(r.SemMinMarginDb))
                        return false;
                    string sem = r.SemStatusText;
                    return sem.IndexOf("Fail", StringComparison.OrdinalIgnoreCase) < 0;
                case StandaloneMeasurementKind.EvmTxpComposite:
                    if (double.IsNaN(r.CompositeRmsEvmDb) || double.IsInfinity(r.CompositeRmsEvmDb))
                        return false;
                    return !double.IsNaN(r.AveragePowerDbm) && !double.IsInfinity(r.AveragePowerDbm);
                default:
                    return false;
            }
        }

        static MeasurementRow BuildCsvRow(TestPoint pt, StandaloneMeasurementKind kind, WlanPointMeasurementResult r, bool pass)
        {
            var row = new MeasurementRow
            {
                TimestampUtc = DateTime.UtcNow,
                TestIndex = 0,
                Band = pt.BandLabel,
                CenterFrequencyHz = pt.CenterFrequencyHz,
                Standard = pt.StandardLabel,
                BandwidthMHz = pt.BandwidthMHz,
                WaveformPath = pt.WaveformFilePath,
                Pass = pass,
                Error = null
            };
            switch (kind)
            {
                case StandaloneMeasurementKind.Evm:
                    row.EvmRmsDb = r.CompositeRmsEvmDb;
                    break;
                case StandaloneMeasurementKind.Txp:
                    row.TxpAverageDbm = r.AveragePowerDbm;
                    row.TxpPeakDbm = r.PeakPowerDbm;
                    break;
                case StandaloneMeasurementKind.Sem:
                    row.SemMeasurementStatus = r.SemStatusText;
                    row.SemMinMarginDb = r.SemMinMarginDb;
                    break;
                case StandaloneMeasurementKind.EvmTxpComposite:
                    row.EvmRmsDb = r.CompositeRmsEvmDb;
                    row.TxpAverageDbm = r.AveragePowerDbm;
                    row.TxpPeakDbm = r.PeakPowerDbm;
                    break;
            }
            return row;
        }

        static (double? data, double? pilot) DataPilotForCsv(StandaloneMeasurementKind kind, WlanPointMeasurementResult r)
        {
            if (kind == StandaloneMeasurementKind.Evm || kind == StandaloneMeasurementKind.EvmTxpComposite)
                return (r.CompositeDataRmsEvmDb, r.CompositePilotRmsEvmDb);
            return (null, null);
        }

        void PopulateResultsGrid(StandaloneMeasurementKind kind, TestPoint pt, WlanPointMeasurementResult r, bool pass)
        {
            _grid.Rows.Clear();
            string freq = ScientificNumberFormat.FormatSi(pt.CenterFrequencyHz, "Hz");

            void Add(string metric, string value) => _grid.Rows.Add(metric, value);

            Add("Module", _combo.Text);
            Add("Pass", pass ? "Yes" : "No");
            Add("Band", pt.BandLabel);
            Add("Center frequency", freq);
            Add("Standard", pt.StandardLabel);
            Add("Bandwidth", ScientificNumberFormat.FormatSi(pt.BandwidthMHz * 1e6, "Hz"));
            Add("Waveform", pt.WaveformFilePath);

            bool evm = kind == StandaloneMeasurementKind.Evm || kind == StandaloneMeasurementKind.EvmTxpComposite;
            bool txp = kind == StandaloneMeasurementKind.Txp || kind == StandaloneMeasurementKind.EvmTxpComposite;
            bool sem = kind == StandaloneMeasurementKind.Sem;

            Add("Composite RMS EVM (dB)", evm ? FmtDb(r.CompositeRmsEvmDb, "dB") : "—");
            Add("Data RMS EVM (dB)", evm ? FmtDb(r.CompositeDataRmsEvmDb, "dB") : "—");
            Add("Pilot RMS EVM (dB)", evm ? FmtDb(r.CompositePilotRmsEvmDb, "dB") : "—");
            Add("TxP average (dBm)", txp ? FmtDb(r.AveragePowerDbm, "dBm") : "—");
            Add("TxP peak (dBm)", txp ? FmtDb(r.PeakPowerDbm, "dBm") : "—");
            Add("SEM status", sem ? r.SemStatusText : "—");
            Add("SEM min margin (dB)", sem ? FmtDb(r.SemMinMarginDb, "dB") : "—");
        }

        void PopulateResultsChart(StandaloneMeasurementKind kind, WlanPointMeasurementResult r)
        {
            var series = _chart.Series["Metrics"];
            series.Points.Clear();

            void AddBar(string name, double v, string suffix)
            {
                if (double.IsNaN(v) || double.IsInfinity(v))
                    return;
                int i = series.Points.AddXY(name, v);
                series.Points[i].Label = ScientificNumberFormat.FormatDb(v, suffix);
                series.Points[i].AxisLabel = name;
            }

            switch (kind)
            {
                case StandaloneMeasurementKind.Evm:
                    AddBar("Composite EVM (dB)", r.CompositeRmsEvmDb, "dB");
                    AddBar("Data EVM (dB)", r.CompositeDataRmsEvmDb, "dB");
                    AddBar("Pilot EVM (dB)", r.CompositePilotRmsEvmDb, "dB");
                    break;
                case StandaloneMeasurementKind.Txp:
                    AddBar("TxP avg (dBm)", r.AveragePowerDbm, "dBm");
                    AddBar("TxP peak (dBm)", r.PeakPowerDbm, "dBm");
                    break;
                case StandaloneMeasurementKind.Sem:
                    AddBar("SEM min margin (dB)", r.SemMinMarginDb, "dB");
                    break;
                case StandaloneMeasurementKind.EvmTxpComposite:
                    AddBar("Composite EVM (dB)", r.CompositeRmsEvmDb, "dB");
                    AddBar("Data EVM (dB)", r.CompositeDataRmsEvmDb, "dB");
                    AddBar("Pilot EVM (dB)", r.CompositePilotRmsEvmDb, "dB");
                    AddBar("TxP avg (dBm)", r.AveragePowerDbm, "dBm");
                    AddBar("TxP peak (dBm)", r.PeakPowerDbm, "dBm");
                    break;
            }

            if (series.Points.Count == 0)
            {
                int z = series.Points.AddXY("(no numeric points)", 0);
                series.Points[z].Color = Color.DimGray;
                series.Points[z].Label = "N/A";
            }

            _chart.ChartAreas["Main"].RecalculateAxesScale();
        }

        void SaveLastResultToCsv()
        {
            if (_lastCsvRow == null)
            {
                MessageBox.Show(this, "No measurement result to save. Run a measurement first.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var d = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "module_runner_results.csv" };
            if (d.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using var logger = new CsvResultLogger(d.FileName, append: false);
                logger.WriteRow(_lastCsvRow, _lastDataEvmDb, _lastPilotEvmDb);
                _log.Text = "Saved row to:\r\n" + d.FileName;
                ReportSuccess("Saved CSV: " + Path.GetFileName(d.FileName));
            }
            catch (Exception ex)
            {
                ReportFailure(ex, "CSV save failed");
            }
        }

        async Task RunAsync()
        {
            _run.Enabled = false;
            _btnSaveCsv.Enabled = false;
            _lastCsvRow = null;
            _lastDataEvmDb = null;
            _lastPilotEvmDb = null;
            _grid.Rows.Clear();
            _chart.Series["Metrics"].Points.Clear();
            ClearTraceTabs();
            _log.Text = "Running measurement on background thread…";
            ReportSuccess("Running…");

            try
            {
                if (!ScientificNumberFormat.TryParseFrequencyHz(_freqHz.Text, out double freqHz))
                {
                    throw new InvalidOperationException(
                        "Invalid center frequency. Use Hz as a number (e.g. 2.412e9) or SI form (e.g. 2.412 GHz, 2412 MHz).");
                }
                if (!File.Exists(_tdms.Text.Trim()))
                {
                    throw new FileNotFoundException("TDMS waveform file not found.", _tdms.Text.Trim());
                }

                var band = _band.SelectedIndex == 0 ? RfBand.Band2_4GHz : RfBand.Band5GHz;
                var std = _std.SelectedIndex == 0 ? WlanStandardKind.IEEE802_11ac : WlanStandardKind.IEEE802_11ax;
                int bwMHz = int.Parse(_bw.SelectedItem!.ToString()!, CultureInfo.InvariantCulture);
                var pt = new TestPoint(0, band, freqHz, std, bwMHz, _tdms.Text.Trim());
                var kind = (StandaloneMeasurementKind)_combo.SelectedIndex;
                var cfg = BuildInstrumentConfigFromUi();

                int timeoutSec = Math.Max(120, (int)Math.Ceiling(cfg.MeasurementTimeoutSec) + 90);
                using var linked = new CancellationTokenSource();
                linked.CancelAfter(TimeSpan.FromSeconds(timeoutSec));

                var runner = new WlanStandaloneMeasurement();
                WlanPointMeasurementResult r;
                try
                {
                    r = await Task.Run(() => runner.Run(pt, cfg, kind, linked.Token)).ConfigureAwait(true);
                }
                catch (OperationCanceledException oce) when (linked.IsCancellationRequested)
                {
                    throw new TimeoutException(
                        "Measurement did not finish within " + timeoutSec + " s. Check hardware, resource name, and TDMS file.", oce);
                }

                bool pass = EvaluatePass(kind, r);
                PopulateResultsGrid(kind, pt, r, pass);
                PopulateResultsChart(kind, r);
                PopulateTraceTabs(r.Traces);
                _lastCsvRow = BuildCsvRow(pt, kind, r, pass);
                var dp = DataPilotForCsv(kind, r);
                _lastDataEvmDb = dp.data;
                _lastPilotEvmDb = dp.pilot;
                _btnSaveCsv.Enabled = true;

                string passTxt = pass ? "PASS" : "FAIL (limits)";
                ReportSuccess("Done — " + passTxt + ". See Results table / chart / RF traces tabs.");
                string logDone = "Completed successfully. Pass flag: " + passTxt + ". Timeout was " + timeoutSec + " s.";
                if (r.Traces != null && !string.IsNullOrEmpty(r.Traces.TraceFetchNote))
                    logDone += "\r\nTrace fetch: " + r.Traces.TraceFetchNote;
                _log.Text = logDone;
            }
            catch (Exception ex)
            {
                ReportFailure(ex, "Measurement error");
            }
            finally
            {
                _run.Enabled = true;
            }
        }
    }
}
