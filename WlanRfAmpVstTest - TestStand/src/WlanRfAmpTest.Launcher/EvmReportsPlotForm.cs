using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Launcher
{
    /// <summary>Line chart of composite RMS EVM from all compatible CSV reports in a folder.</summary>
    public sealed class EvmReportsPlotForm : Form
    {
        readonly Chart _chart = new Chart();
        readonly Label _status = new Label();

        public EvmReportsPlotForm(string workingDirectory)
        {
            Text = "EVM from CSV reports";
            MinimumSize = new Size(640, 420);
            Size = new Size(960, 600);
            StartPosition = FormStartPosition.CenterScreen;
            UiTheme.ApplyForm(this);

            _status.Dock = DockStyle.Top;
            _status.Height = 32;
            _status.TextAlign = ContentAlignment.MiddleLeft;
            _status.Padding = new Padding(12, 8, 12, 4);
            _status.ForeColor = UiTheme.Muted;

            _chart.Dock = DockStyle.Fill;
            _chart.BackColor = UiTheme.Back;

            var area = new ChartArea("main")
            {
                BackColor = UiTheme.Panel
            };
            area.AxisX.Title = "Sample index (files A–Z, then row order)";
            area.AxisY.Title = "EVM RMS (dB)";
            area.AxisX.MajorGrid.Enabled = true;
            area.AxisY.MajorGrid.Enabled = true;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 68);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(60, 60, 68);
            area.AxisX.LineColor = UiTheme.Muted;
            area.AxisY.LineColor = UiTheme.Muted;
            area.AxisX.TitleForeColor = UiTheme.Text;
            area.AxisY.TitleForeColor = UiTheme.Text;
            area.AxisX.LabelStyle.ForeColor = UiTheme.Text;
            area.AxisY.LabelStyle.ForeColor = UiTheme.Text;
            _chart.ChartAreas.Add(area);

            var series = new Series("EVM_RMS_dB")
            {
                ChartType = SeriesChartType.Line,
                Color = UiTheme.Accent,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5,
                MarkerColor = UiTheme.Accent
            };
            _chart.Series.Add(series);
            _chart.Legends.Clear();

            Controls.Add(_chart);
            Controls.Add(_status);

            Load += (_, _) => LoadData(workingDirectory);
        }

        void LoadData(string dir)
        {
            dir = dir?.Trim() ?? "";
            if (!Directory.Exists(dir))
            {
                _status.Text = "Folder does not exist: " + dir;
                return;
            }

            var samples = CsvReportEvmAggregator.CollectFromDirectory(dir);
            int fileCount = samples.Select(s => s.FullPath).Distinct(StringComparer.OrdinalIgnoreCase).Count();

            if (samples.Count == 0)
            {
                _status.Text = "No EVM rows found. Expected CSV files with header containing TimestampUtc and EVM_RMS_dB (sequencer / module runner format) in:\r\n" + dir;
                return;
            }

            _status.Text = samples.Count + " sample(s) from " + fileCount + " report file(s) — " + dir;

            Series series = _chart.Series["EVM_RMS_dB"];
            series.Points.Clear();
            var inv = System.Globalization.CultureInfo.InvariantCulture;
            for (int i = 0; i < samples.Count; i++)
            {
                EvmReportSample s = samples[i];
                int pi = series.Points.AddXY(i, s.EvmRmsDb);
                DataPoint pt = series.Points[pi];
                string name = Path.GetFileName(s.FullPath);
                string ts = s.TimestampUtc.HasValue
                    ? s.TimestampUtc.Value.ToString("u", inv)
                    : "—";
                pt.ToolTip = s.EvmRmsDb.ToString("0.###", inv) + " dB\r\n"
                    + name + "  row " + (s.RowIndex + 1) + "\r\n" + ts;
            }

            _chart.ChartAreas[0].RecalculateAxesScale();
        }
    }
}
