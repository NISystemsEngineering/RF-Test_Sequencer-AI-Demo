using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WlanRfAmpTest.Launcher
{
    /// <summary>Unified entry point for the WLAN RF amplifier test tools (sequencer, modules, regression validation).</summary>
    public sealed class MainForm : Form
    {
        string _pathSequencer = "";
        string _pathModules = "";
        string _pathValidation = "";
        readonly TextBox _docFolder = new TextBox();

        public MainForm()
        {
            Text = "WLAN RF Amplifier — Test Framework";
            MinimumSize = new Size(640, 560);
            Size = new Size(880, 720);
            StartPosition = FormStartPosition.CenterScreen;
            Padding = new Padding(0);
            UiTheme.ApplyForm(this);

            _pathSequencer = ExeLocator.TryFind("WlanRfAmpTest.Sequencer.exe");
            _pathModules = ExeLocator.TryFind("WlanRfAmpTest.ModuleRunner.exe");
            _pathValidation = ExeLocator.TryFind("WlanRfAmpTest.Validation.exe");

            string doc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WlanRfAmpVstTest");
            _docFolder.Text = doc;
            _docFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            UiTheme.StyleTextBox(_docFolder);
            _docFolder.Height = 26;

            var scroll = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = UiTheme.Back
            };

            var root = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Top,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(20, 0, 20, 16),
                BackColor = UiTheme.Back
            };
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            // Compact fixed height — was Percent 100 and hid the working folder below the fold.
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 152f));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            root.Controls.Add(BuildHeader(), 0, 0);
            root.Controls.Add(BuildToolSection(), 0, 1);
            root.Controls.Add(BuildWorkflowPanel(), 0, 2);
            root.Controls.Add(BuildWorkingFolderSection(), 0, 3);

            void FitRootWidth()
            {
                int w = scroll.ClientSize.Width;
                if (w < 1)
                    return;
                int reserve = 8 + (scroll.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0);
                root.Width = Math.Max(320, w - reserve);
            }

            scroll.Controls.Add(root);
            scroll.Resize += (_, _) => FitRootWidth();
            Shown += (_, _) => FitRootWidth();

            Controls.Add(scroll);
        }

        Panel BuildHeader()
        {
            var wrap = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                BackColor = Color.FromArgb(32, 33, 40),
                Padding = new Padding(0, 20, 0, 0)
            };

            var accentBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 3,
                BackColor = UiTheme.Accent
            };
            wrap.Controls.Add(accentBar);

            var title = new Label
            {
                Text = "WLAN RF Amplifier",
                Dock = DockStyle.Top,
                Height = 44,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 22f, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = UiTheme.Text,
                BackColor = Color.FromArgb(32, 33, 40)
            };
            wrap.Controls.Add(title);

            var subtitle = new Label
            {
                Text = "Test framework",
                Dock = DockStyle.Top,
                Height = 28,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = UiTheme.Accent,
                BackColor = Color.FromArgb(32, 33, 40)
            };
            wrap.Controls.Add(subtitle);

            var blurb = new Label
            {
                Text = "PXIe-5841 VST · NI RFmx WLAN · NI-RFSG Playback\r\n" +
                       "Full matrix sequencing, single-point modules, and CSV regression validation.",
                Dock = DockStyle.Top,
                AutoSize = true,
                MaximumSize = new Size(820, 0),
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = UiTheme.Muted,
                BackColor = Color.FromArgb(32, 33, 40),
                Padding = new Padding(40, 12, 40, 16)
            };
            wrap.Controls.Add(blurb);

            var linksHost = new Panel
            {
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(32, 33, 40),
                Padding = new Padding(0, 0, 0, 16)
            };
            var linksRow = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                BackColor = Color.FromArgb(32, 33, 40)
            };
            linksRow.Controls.Add(MakeDocLink("RFmx WLAN overview", "https://www.ni.com/docs/en-US/bundle/rfmx-wlan/page/rfmxwlan-overview.html"));
            linksRow.Controls.Add(new Label { Text = "  ·  ", AutoSize = true, ForeColor = UiTheme.Muted, Margin = new Padding(0, 6, 0, 0), BackColor = Color.FromArgb(32, 33, 40) });
            linksRow.Controls.Add(MakeDocLink("RFmx WLAN manual", "https://www.ni.com/docs/en-US/bundle/rfmx-wlan/page/user-manual-welcome.html"));
            linksRow.Controls.Add(new Label { Text = "  ·  ", AutoSize = true, ForeColor = UiTheme.Muted, Margin = new Padding(0, 6, 0, 0), BackColor = Color.FromArgb(32, 33, 40) });
            linksRow.Controls.Add(MakeDocLink("NI-RFSG Playback API", "https://www.ni.com/docs/en-US/bundle/rfsgplaybacklibrary-labview-api-ref/page/menus/categories/measurement/nirfsgplayback-mnu.html"));
            linksHost.Controls.Add(linksRow);
            void CenterLinks()
            {
                if (linksHost.ClientSize.Width <= 0)
                    return;
                linksRow.Left = Math.Max(0, (linksHost.ClientSize.Width - linksRow.PreferredSize.Width) / 2);
                linksRow.Top = 4;
                linksHost.Height = Math.Max(40, linksRow.Bottom + 20);
            }
            linksHost.Layout += (_, _) => CenterLinks();
            wrap.Controls.Add(linksHost);

            return wrap;
        }

        Panel BuildToolSection()
        {
            // AutoSize + Dock.Top so row height is not collapsed to zero (Fill in an AutoSize TableLayout row breaks preferred height).
            var section = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0, 4, 0, 8),
                BackColor = UiTheme.Back
            };

            var grid = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 1,
                RowCount = 3,
                BackColor = UiTheme.Back,
                Padding = new Padding(0)
            };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            grid.Controls.Add(MakeToolCard(
                "Sequencer",
                "Launch Sequencer",
                "Full RF matrix: 2.4 / 5 GHz, 802.11ac / ax, 20 / 40 / 80 MHz — EVM, TxP, and SEM per point with CSV logging.",
                p => _pathSequencer = p,
                "WlanRfAmpTest.Sequencer.exe",
                () => LaunchExe(_pathSequencer, "Sequencer")), 0, 0);

            grid.Controls.Add(MakeToolCard(
                "Module runner",
                "Launch Module runner",
                "Run EVM, TxP, or SEM individually with tables, charts, and RF trace tabs.",
                p => _pathModules = p,
                "WlanRfAmpTest.ModuleRunner.exe",
                () => LaunchExe(_pathModules, "Module runner")), 0, 1);

            grid.Controls.Add(MakeToolCard(
                "Validation",
                "Launch Validation",
                "Compare candidate CSVs to a gold baseline and run the headless sequencer from here.",
                p => _pathValidation = p,
                "WlanRfAmpTest.Validation.exe",
                () => LaunchExe(_pathValidation, "Validation")), 0, 2);

            section.Controls.Add(grid);
            return section;
        }

        Panel MakeToolCard(
            string heading,
            string launchButtonText,
            string description,
            Action<string> setPath,
            string filterExe,
            Action launch)
        {
            var card = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = UiTheme.Panel,
                Margin = new Padding(0, 0, 0, 10),
                BorderStyle = BorderStyle.FixedSingle,
                MinimumSize = new Size(100, 72)
            };

            var inner = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 2,
                RowCount = 2,
                BackColor = UiTheme.Panel,
                Padding = new Padding(16, 12, 16, 14)
            };
            inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            inner.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            inner.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            inner.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var title = new Label
            {
                Text = heading,
                Font = new Font("Segoe UI", 11f, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = UiTheme.Text,
                AutoSize = true,
                MaximumSize = new Size(420, 0),
                BackColor = UiTheme.Panel,
                Margin = new Padding(0, 2, 12, 0)
            };

            var btnLaunch = new Button { Text = launchButtonText };
            UiTheme.StylePrimaryButton(btnLaunch);
            btnLaunch.Click += (_, _) => launch();

            var btnLocate = new Button { Text = "Locate executable…" };
            UiTheme.StyleButton(btnLocate);
            btnLocate.Click += (_, _) =>
            {
                using var d = new OpenFileDialog
                {
                    Filter = "Executable (*.exe)|*.exe|All files|*.*",
                    FileName = filterExe,
                    Title = "Select " + heading
                };
                if (d.ShowDialog(this) == DialogResult.OK)
                    setPath(d.FileName);
            };

            var buttons = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = UiTheme.Panel,
                Margin = new Padding(0, 0, 0, 0)
            };
            buttons.Controls.Add(btnLaunch);
            buttons.Controls.Add(btnLocate);

            var desc = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 9.25f, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = UiTheme.Muted,
                AutoSize = true,
                BackColor = UiTheme.Panel,
                Margin = new Padding(0, 6, 0, 0)
            };

            inner.Controls.Add(title, 0, 0);
            inner.Controls.Add(buttons, 1, 0);
            inner.Controls.Add(desc, 0, 1);
            inner.SetColumnSpan(desc, 2);

            card.Controls.Add(inner);
            return card;
        }

        Panel BuildWorkflowPanel()
        {
            var p = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(2, 2, 2, 6),
                Padding = new Padding(0),
                BackColor = UiTheme.Back
            };
            var inner = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(34, 35, 42),
                Padding = new Padding(12, 8, 12, 8),
                BorderStyle = BorderStyle.FixedSingle
            };
            var title = new Label
            {
                Text = "Typical workflow",
                Dock = DockStyle.Top,
                Height = 22,
                ForeColor = UiTheme.Text,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold, GraphicsUnit.Point),
                BackColor = Color.FromArgb(34, 35, 42)
            };
            var body = new TextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true,
                WordWrap = true,
                TabStop = false,
                ShortcutsEnabled = true,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(34, 35, 42),
                ForeColor = Color.FromArgb(210, 212, 220),
                Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point),
                ScrollBars = ScrollBars.Vertical,
                Margin = new Padding(0, 2, 0, 0),
                Text =
                    "Steps" + Environment.NewLine +
                    "  1. Create waveforms.json (Sequencer template) and point each entry at your TDMS files." + Environment.NewLine +
                    "  2. Run the Sequencer. Optional: frequency → bandwidth → standard order to save LO time." + Environment.NewLine +
                    "  3. Save a CSV baseline; use Validation to compare new runs within tolerances." + Environment.NewLine +
                    Environment.NewLine +
                    "Command line" + Environment.NewLine +
                    "  Sequencer" + Environment.NewLine +
                    "    --headless --catalog waveforms.json --out out.csv [--fbs]" + Environment.NewLine +
                    Environment.NewLine +
                    "  Validation" + Environment.NewLine +
                    "    --compare --baseline gold.csv --candidate new.csv [--tol-evm 0.5]"
            };
            inner.Controls.Add(title);
            inner.Controls.Add(body);
            p.Controls.Add(inner);
            return p;
        }

        Panel BuildWorkingFolderSection()
        {
            var section = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0, 4, 0, 0),
                BackColor = UiTheme.Back
            };
            var box = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.FromArgb(34, 35, 42),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(16, 14, 16, 14)
            };

            var grid = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 2,
                RowCount = 5,
                BackColor = Color.FromArgb(34, 35, 42)
            };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var heading = new Label
            {
                Text = "Working folder",
                Font = new Font("Segoe UI", 10f, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = UiTheme.Text,
                AutoSize = true,
                BackColor = Color.FromArgb(34, 35, 42),
                Margin = new Padding(0, 0, 0, 4)
            };
            var hint = new Label
            {
                Text = "waveforms.json, CSV results, and TDMS paths resolve relative to this folder when you launch tools.",
                Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = UiTheme.Muted,
                AutoSize = true,
                BackColor = Color.FromArgb(34, 35, 42),
                Margin = new Padding(0, 0, 0, 10)
            };

            _docFolder.Dock = DockStyle.Fill;
            _docFolder.MinimumSize = new Size(120, 26);
            _docFolder.Margin = new Padding(0, 0, 8, 0);

            var browse = new Button { Text = "Browse…" };
            UiTheme.StyleButton(browse);
            browse.Margin = new Padding(0, 0, 0, 10);
            browse.Click += (_, _) =>
            {
                using var d = new FolderBrowserDialog
                {
                    SelectedPath = Directory.Exists(_docFolder.Text) ? _docFolder.Text : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };
                if (d.ShowDialog(this) == DialogResult.OK)
                    _docFolder.Text = d.SelectedPath;
            };

            var openExplorer = new Button { Text = "Open in File Explorer" };
            UiTheme.StyleButton(openExplorer);
            openExplorer.Click += (_, _) =>
            {
                string path = _docFolder.Text.Trim();
                try
                {
                    Directory.CreateDirectory(path);
                    Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            var openRow = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                BackColor = Color.FromArgb(34, 35, 42)
            };
            openRow.Controls.Add(openExplorer);

            var plotEvm = new Button { Text = "Plot EVM from CSV reports…" };
            UiTheme.StyleButton(plotEvm);
            plotEvm.Margin = new Padding(0, 6, 0, 0);
            plotEvm.Click += (_, _) =>
            {
                string wd = _docFolder.Text.Trim();
                if (!Directory.Exists(wd))
                {
                    try
                    {
                        Directory.CreateDirectory(wd);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                using var f = new EvmReportsPlotForm(wd);
                f.ShowDialog(this);
            };

            var plotRow = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                BackColor = Color.FromArgb(34, 35, 42)
            };
            plotRow.Controls.Add(plotEvm);

            grid.Controls.Add(heading, 0, 0);
            grid.SetColumnSpan(heading, 2);
            grid.Controls.Add(hint, 0, 1);
            grid.SetColumnSpan(hint, 2);
            grid.Controls.Add(_docFolder, 0, 2);
            grid.Controls.Add(browse, 1, 2);
            grid.Controls.Add(openRow, 0, 3);
            grid.SetColumnSpan(openRow, 2);
            grid.Controls.Add(plotRow, 0, 4);
            grid.SetColumnSpan(plotRow, 2);

            box.Controls.Add(grid);
            section.Controls.Add(box);
            return section;
        }

        static LinkLabel MakeDocLink(string text, string url)
        {
            var l = new LinkLabel
            {
                Text = text,
                AutoSize = true,
                LinkColor = UiTheme.Accent,
                ActiveLinkColor = Color.White,
                VisitedLinkColor = UiTheme.Accent,
                BackColor = Color.FromArgb(32, 33, 40),
                Margin = new Padding(4, 4, 4, 4)
            };
            l.Click += (_, _) =>
            {
                try
                {
                    Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Open link", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            return l;
        }

        void LaunchExe(string path, string friendlyName)
        {
            path = path.Trim();
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                MessageBox.Show(this,
                    "Could not find " + friendlyName + ".\r\n\r\nBuild the solution or click “Locate executable…” on that card.",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            try
            {
                string wd = _docFolder.Text.Trim();
                if (!Directory.Exists(wd))
                    Directory.CreateDirectory(wd);
                Process.Start(new ProcessStartInfo
                {
                    FileName = path,
                    WorkingDirectory = wd,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
