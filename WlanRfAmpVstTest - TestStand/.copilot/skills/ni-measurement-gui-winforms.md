---
name: ni-measurement-gui-winforms
description: "Build professional Windows Forms measurement GUIs for NI hardware instrumentation projects. Covers UI design patterns, theming, async measurement execution, data visualization (charts, grids), error handling, and results export. Use when creating test & measurement applications with .NET Framework WinForms."
argument-hint: "Describe the measurement type, hardware (RFSA, RFSG, DMM, Scope, etc.), and desired UI features (live updates, charts, export, etc.)"
user-invocable: true
---

# NI Measurement GUI - Windows Forms Skill

Build professional, production-ready measurement GUIs for National Instruments hardware using Windows Forms and .NET Framework.

## Trigger Phrases

- "Create a measurement GUI for [NI hardware]"
- "Build a Windows Forms UI for RF measurements"
- "How do I make a GUI for NI-SCOPE measurements?"
- "Design a measurement application UI"
- "Create a test GUI with charts and data grids"
- "Build a WinForms app for DMM measurements"
- "Make a professional-looking measurement interface"
- "Add data visualization to my measurement app"

## What This Skill Covers

### UI Components
- Main form layout and design
- Dark theme implementation
- Control styling (buttons, text boxes, combo boxes)
- Status bar for errors and progress
- Tab-based navigation
- Data grids for results tables
- Charts for data visualization
- Log/console output windows

### Measurement Workflow
- Async measurement execution
- Progress reporting
- Error handling and display
- Results storage and export
- CSV file generation
- Configuration persistence

### Best Practices
- Responsive UI (don't freeze during measurements)
- Professional appearance
- Consistent theming
- Proper resource management
- Thread-safe UI updates

---

## Architecture Pattern

### Recommended Structure

```
Project/
├── MainForm.cs                    ← Main GUI form
├── MainForm.Designer.cs           ← Auto-generated designer code
├── UiTheme.cs                     ← Centralized theme/styling
├── MeasurementModule.cs           ← Measurement logic (separate from UI)
└── ResultsExporter.cs             ← CSV/file export utilities
```

**Key Principle:** Separate measurement logic from UI code for testability and reusability.

---

## Core Components

### 1. Main Form Setup

**Basic Form Configuration:**

```csharp
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;

public sealed class MainForm : Form
{
    // Controls
    readonly Label _statusLabel;
    readonly TextBox _resourceName;
    readonly Button _runButton;
    readonly DataGridView _resultsGrid;
    readonly Chart _resultsChart;
    readonly TextBox _logOutput;

    public MainForm()
    {
        // Form properties
        Text = "NI Measurement Application";
        Width = 1024;
        Height = 768;
        StartPosition = FormStartPosition.CenterScreen;

        // Apply theme
        UiTheme.ApplyForm(this);

        // Initialize controls
        InitializeControls();

        // Setup event handlers
        _runButton.Click += OnRunMeasurement;
    }

    private void InitializeControls()
    {
        // Status label (top)
        _statusLabel = new Label
        {
            Text = "Ready",
            Dock = DockStyle.Top,
            Height = 30,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(12, 4, 12, 4)
        };

        // Resource name input
        _resourceName = new TextBox
        {
            Text = "Dev1",
            Width = 150
        };
        UiTheme.StyleTextBox(_resourceName);

        // Run button
        _runButton = new Button
        {
            Text = "Run Measurement"
        };
        UiTheme.StyleButton(_runButton);

        // Results grid
        _resultsGrid = new DataGridView
        {
            Dock = DockStyle.Fill
        };
        UiTheme.StyleGrid(_resultsGrid);
        SetupResultsGrid();

        // Results chart
        _resultsChart = new Chart
        {
            Dock = DockStyle.Fill
        };
        SetupChart();

        // Log output
        _logOutput = new TextBox
        {
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            Dock = DockStyle.Fill,
            Font = new Font("Consolas", 9f)
        };
        UiTheme.StyleTextBox(_logOutput);

        // Layout (create panels, split containers, etc.)
        LayoutControls();
    }

    private void SetupResultsGrid()
    {
        _resultsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _resultsGrid.Columns.Add("Metric", "Measurement");
        _resultsGrid.Columns.Add("Value", "Result");
        _resultsGrid.Columns.Add("Unit", "Unit");
    }

    private void SetupChart()
    {
        var area = new ChartArea("MainArea");
        area.BackColor = UiTheme.Panel;
        area.AxisX.LabelStyle.ForeColor = UiTheme.Text;
        area.AxisY.LabelStyle.ForeColor = UiTheme.Text;
        _resultsChart.ChartAreas.Add(area);

        var series = new Series("Results")
        {
            ChartType = SeriesChartType.Column,
            Color = UiTheme.Accent
        };
        _resultsChart.Series.Add(series);
    }

    private void LayoutControls()
    {
        // Use TableLayoutPanel, SplitContainer, or nested panels
        // Example: Top status bar, middle config area, bottom results

        var mainLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            RowCount = 3,
            ColumnCount = 1
        };

        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // Status
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100)); // Config
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // Results

        mainLayout.Controls.Add(_statusLabel, 0, 0);
        // Add config panel to row 1
        // Add results (tabs/split) to row 2

        Controls.Add(mainLayout);
    }
}
```

---

### 2. Dark Theme Implementation

**Centralized UiTheme Class:**

```csharp
internal static class UiTheme
{
    // Color palette
    public static readonly Color Back = Color.FromArgb(26, 28, 34);
    public static readonly Color Panel = Color.FromArgb(42, 46, 56);
    public static readonly Color Accent = Color.FromArgb(100, 200, 180);
    public static readonly Color Text = Color.FromArgb(238, 240, 245);
    public static readonly Color Muted = Color.FromArgb(160, 165, 175);
    public static readonly Color Error = Color.FromArgb(220, 80, 80);
    public static readonly Color Success = Color.FromArgb(100, 200, 130);

    public static void ApplyForm(Form form)
    {
        form.BackColor = Back;
        form.ForeColor = Text;
        form.Font = new Font("Segoe UI", 10f);
    }

    public static void StyleButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = Accent;
        button.FlatAppearance.BorderSize = 1;
        button.BackColor = Panel;
        button.ForeColor = Text;
        button.Cursor = Cursors.Hand;
        button.AutoSize = true;
        button.Padding = new Padding(10, 5, 10, 5);
        button.MinimumSize = new Size(0, 28);
    }

    public static void StyleTextBox(TextBox textBox)
    {
        textBox.BackColor = Panel;
        textBox.ForeColor = Text;
        textBox.BorderStyle = BorderStyle.FixedSingle;
    }

    public static void StyleComboBox(ComboBox comboBox)
    {
        comboBox.FlatStyle = FlatStyle.Flat;
        comboBox.BackColor = Panel;
        comboBox.ForeColor = Text;
    }

    public static void StyleGrid(DataGridView grid)
    {
        grid.BackgroundColor = Back;
        grid.BorderStyle = BorderStyle.None;
        grid.EnableHeadersVisualStyles = false;

        grid.ColumnHeadersDefaultCellStyle.BackColor = Panel;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Text;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

        grid.DefaultCellStyle.BackColor = Panel;
        grid.DefaultCellStyle.ForeColor = Text;
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 90, 100);
        grid.DefaultCellStyle.SelectionForeColor = Text;

        grid.RowHeadersVisible = false;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.ReadOnly = true;
    }

    public static void StyleChart(Chart chart)
    {
        chart.BackColor = Back;
        chart.ChartAreas[0].BackColor = Panel;
        chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Text;
        chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Text;
        chart.ChartAreas[0].AxisX.LineColor = Muted;
        chart.ChartAreas[0].AxisY.LineColor = Muted;
        chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(50, 55, 65);
        chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(50, 55, 65);

        foreach (var series in chart.Series)
        {
            series.Color = Accent;
        }
    }
}
```

---

### 3. Async Measurement Execution

**Thread-Safe, Non-Blocking Measurements:**

```csharp
private async void OnRunMeasurement(object sender, EventArgs e)
{
    // Disable button during measurement
    _runButton.Enabled = false;
    UpdateStatus("Running measurement...", UiTheme.Accent);
    ClearResults();

    try
    {
        // Run measurement on background thread
        var results = await Task.Run(() => RunMeasurementLogic());

        // Update UI on UI thread
        DisplayResults(results);
        UpdateStatus("Measurement complete", UiTheme.Success);
    }
    catch (Exception ex)
    {
        // Show error
        UpdateStatus($"Error: {ex.Message}", UiTheme.Error);
        AppendLog($"Exception: {ex}");
        MessageBox.Show(ex.Message, "Measurement Error", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        _runButton.Enabled = true;
    }
}

private MeasurementResults RunMeasurementLogic()
{
    string resource = GetResourceName();

    // Initialize hardware (NOT on UI thread)
    using (var instrument = new NiInstrument(resource))
    {
        // Configure
        instrument.Configure(/* parameters */);

        // Acquire data
        var data = instrument.Measure();

        // Analyze
        var results = AnalyzeData(data);

        return results;
    }
}

// Thread-safe status update
private void UpdateStatus(string message, Color color)
{
    if (InvokeRequired)
    {
        Invoke(new Action(() => UpdateStatus(message, color)));
        return;
    }

    _statusLabel.Text = message;
    _statusLabel.ForeColor = color;
}

// Thread-safe log append
private void AppendLog(string message)
{
    if (InvokeRequired)
    {
        Invoke(new Action(() => AppendLog(message)));
        return;
    }

    _logOutput.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
}

private string GetResourceName()
{
    // Must be called on UI thread or use Invoke
    if (InvokeRequired)
        return (string)Invoke(new Func<string>(() => _resourceName.Text));
    return _resourceName.Text;
}
```

---

### 4. Results Display

**Populate Grid and Chart:**

```csharp
private void DisplayResults(MeasurementResults results)
{
    // Clear previous data
    _resultsGrid.Rows.Clear();
    _resultsChart.Series[0].Points.Clear();

    // Populate grid
    foreach (var metric in results.Metrics)
    {
        _resultsGrid.Rows.Add(
            metric.Name,
            metric.Value.ToString("F3"),
            metric.Unit
        );

        // Add to chart
        var point = _resultsChart.Series[0].Points.AddXY(
            metric.Name, 
            metric.Value
        );

        // Color code by pass/fail
        if (metric.IsFail)
            _resultsChart.Series[0].Points[point].Color = UiTheme.Error;
    }

    // Auto-scale chart
    _resultsChart.ChartAreas[0].RecalculateAxesScale();

    // Enable export button
    _exportButton.Enabled = true;
}

private void ClearResults()
{
    _resultsGrid.Rows.Clear();
    _resultsChart.Series[0].Points.Clear();
    _exportButton.Enabled = false;
}
```

---

### 5. CSV Export

**Save Results to File:**

```csharp
private void OnExportResults(object sender, EventArgs e)
{
    using (var dialog = new SaveFileDialog())
    {
        dialog.Filter = "CSV files|*.csv|All files|*.*";
        dialog.DefaultExt = "csv";
        dialog.FileName = $"measurement_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                ExportToCsv(dialog.FileName);
                UpdateStatus($"Results saved to {Path.GetFileName(dialog.FileName)}", 
                    UiTheme.Success);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

private void ExportToCsv(string filePath)
{
    using (var writer = new StreamWriter(filePath))
    {
        // Header
        writer.WriteLine("Timestamp,Resource,Metric,Value,Unit");

        // Data rows
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string resource = _resourceName.Text;

        foreach (DataGridViewRow row in _resultsGrid.Rows)
        {
            if (row.IsNewRow) continue;

            writer.WriteLine($"{timestamp},{resource},{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value}");
        }
    }
}
```

---

## Complete Example: NI-SCOPE Measurement GUI

```csharp
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using NationalInstruments.ModularInstruments.NIScope;

public class ScopeMeasurementForm : Form
{
    readonly TextBox _resourceName = new TextBox { Width = 150, Text = "Dev1" };
    readonly NumericUpDown _sampleRate = new NumericUpDown { Minimum = 1e6M, Maximum = 1e9M, Value = 10e6M, DecimalPlaces = 0, Width = 120 };
    readonly NumericUpDown _numSamples = new NumericUpDown { Minimum = 1000, Maximum = 10000000, Value = 10000, DecimalPlaces = 0, Width = 120 };
    readonly Button _runButton = new Button { Text = "Acquire Waveform" };
    readonly Button _exportButton = new Button { Text = "Export to CSV", Enabled = false };
    readonly Chart _waveformChart = new Chart();
    readonly DataGridView _measurementsGrid = new DataGridView();
    readonly TextBox _log = new TextBox { Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Font = new Font("Consolas", 9f) };
    readonly Label _status = new Label { Dock = DockStyle.Top, Height = 30, TextAlign = ContentAlignment.MiddleLeft };

    double[] _lastWaveform;
    double _lastSampleInterval;

    public ScopeMeasurementForm()
    {
        Text = "NI-SCOPE Waveform Measurement";
        Width = 1200;
        Height = 800;
        StartPosition = FormStartPosition.CenterScreen;

        UiTheme.ApplyForm(this);
        UiTheme.StyleTextBox(_resourceName);
        UiTheme.StyleButton(_runButton);
        UiTheme.StyleButton(_exportButton);
        UiTheme.StyleGrid(_measurementsGrid);
        UiTheme.StyleTextBox(_log);

        SetupChart();
        SetupGrid();
        LayoutControls();

        _runButton.Click += async (s, e) => await RunAcquisition();
        _exportButton.Click += ExportData;

        _status.Text = "Ready to acquire";
        _status.ForeColor = UiTheme.Accent;
    }

    private void SetupChart()
    {
        var area = new ChartArea();
        area.BackColor = UiTheme.Panel;
        area.AxisX.Title = "Time (s)";
        area.AxisY.Title = "Voltage (V)";
        area.AxisX.TitleForeColor = UiTheme.Text;
        area.AxisY.TitleForeColor = UiTheme.Text;
        area.AxisX.LabelStyle.ForeColor = UiTheme.Text;
        area.AxisY.LabelStyle.ForeColor = UiTheme.Text;
        _waveformChart.ChartAreas.Add(area);

        var series = new Series("Waveform");
        series.ChartType = SeriesChartType.Line;
        series.Color = UiTheme.Accent;
        series.BorderWidth = 2;
        _waveformChart.Series.Add(series);

        _waveformChart.BackColor = UiTheme.Back;
        _waveformChart.Dock = DockStyle.Fill;
    }

    private void SetupGrid()
    {
        _measurementsGrid.Columns.Add("Measurement", "Measurement");
        _measurementsGrid.Columns.Add("Value", "Value");
        _measurementsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _measurementsGrid.Dock = DockStyle.Fill;
    }

    private void LayoutControls()
    {
        var mainLayout = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 3, ColumnCount = 1, Padding = new Padding(8) };
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30));

        // Status bar
        mainLayout.Controls.Add(_status, 0, 0);

        // Config panel
        var configPanel = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight, AutoSize = true, Padding = new Padding(4) };
        configPanel.Controls.Add(new Label { Text = "Resource:", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(0, 5, 8, 0) });
        configPanel.Controls.Add(_resourceName);
        configPanel.Controls.Add(new Label { Text = "Sample Rate:", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(8, 5, 8, 0) });
        configPanel.Controls.Add(_sampleRate);
        configPanel.Controls.Add(new Label { Text = "# Samples:", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(8, 5, 8, 0) });
        configPanel.Controls.Add(_numSamples);
        configPanel.Controls.Add(_runButton);
        configPanel.Controls.Add(_exportButton);

        // Results area (split: chart + measurements table)
        var resultsSplit = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Vertical };
        resultsSplit.Panel1.Controls.Add(_waveformChart);
        resultsSplit.Panel2.Controls.Add(_measurementsGrid);
        resultsSplit.SplitterDistance = 600;

        // Bottom area (results + log)
        var bottomSplit = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Horizontal };
        bottomSplit.Panel1.Controls.Add(resultsSplit);
        bottomSplit.Panel2.Controls.Add(_log);
        bottomSplit.SplitterDistance = 300;

        // Combine: config at top, results at bottom
        var contentArea = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2, ColumnCount = 1 };
        contentArea.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        contentArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        contentArea.Controls.Add(configPanel, 0, 0);
        contentArea.Controls.Add(bottomSplit, 0, 1);

        mainLayout.Controls.Add(contentArea, 0, 1);
        Controls.Add(mainLayout);
    }

    private async Task RunAcquisition()
    {
        _runButton.Enabled = false;
        UpdateStatus("Acquiring waveform...", UiTheme.Accent);

        try
        {
            var result = await Task.Run(() => AcquireWaveform());

            _lastWaveform = result.Waveform;
            _lastSampleInterval = result.SampleInterval;

            PlotWaveform(result.Waveform, result.SampleInterval);
            CalculateMeasurements(result.Waveform);
            UpdateStatus("Acquisition complete", UiTheme.Success);
            _exportButton.Enabled = true;
        }
        catch (Exception ex)
        {
            UpdateStatus($"Error: {ex.Message}", UiTheme.Error);
            AppendLog($"Exception: {ex}");
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _runButton.Enabled = true;
        }
    }

    private (double[] Waveform, double SampleInterval) AcquireWaveform()
    {
        string resource = _resourceName.Text;
        double sampleRate = (double)_sampleRate.Value;
        int numSamples = (int)_numSamples.Value;

        using (var session = new NIScope(resource, true, false))
        {
            session.ConfigureHorizontalTiming(sampleRate, numSamples, 50.0, 1, true);
            session.ConfigureVertical("0", 1.0, 0.0, NIScope.VerticalCoupling.DC, 1.0, true);
            session.ConfigureTrigger(NIScope.TriggerType.Edge, "0");

            var waveform = session.Channels["0"].Measurement.ReadWaveform(1.0);

            return (waveform.GetRawData(), waveform.PrecisionTiming.SampleInterval.TotalSeconds);
        }
    }

    private void PlotWaveform(double[] data, double sampleInterval)
    {
        _waveformChart.Series[0].Points.Clear();

        for (int i = 0; i < data.Length; i++)
        {
            double time = i * sampleInterval;
            _waveformChart.Series[0].Points.AddXY(time, data[i]);
        }

        _waveformChart.ChartAreas[0].RecalculateAxesScale();
    }

    private void CalculateMeasurements(double[] data)
    {
        _measurementsGrid.Rows.Clear();

        double min = double.MaxValue, max = double.MinValue, sum = 0;
        foreach (var v in data)
        {
            if (v < min) min = v;
            if (v > max) max = v;
            sum += v;
        }
        double mean = sum / data.Length;

        double variance = 0;
        foreach (var v in data)
            variance += (v - mean) * (v - mean);
        double rms = Math.Sqrt(variance / data.Length);

        _measurementsGrid.Rows.Add("Minimum", $"{min:F6} V");
        _measurementsGrid.Rows.Add("Maximum", $"{max:F6} V");
        _measurementsGrid.Rows.Add("Peak-to-Peak", $"{max - min:F6} V");
        _measurementsGrid.Rows.Add("Mean", $"{mean:F6} V");
        _measurementsGrid.Rows.Add("RMS", $"{rms:F6} V");
    }

    private void ExportData(object sender, EventArgs e)
    {
        using (var dialog = new SaveFileDialog { Filter = "CSV|*.csv", DefaultExt = "csv" })
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new System.IO.StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("Time (s),Voltage (V)");
                    for (int i = 0; i < _lastWaveform.Length; i++)
                        writer.WriteLine($"{i * _lastSampleInterval:E6},{_lastWaveform[i]:F6}");
                }
                UpdateStatus($"Exported to {System.IO.Path.GetFileName(dialog.FileName)}", UiTheme.Success);
            }
        }
    }

    private void UpdateStatus(string message, Color color)
    {
        if (InvokeRequired) { Invoke(new Action(() => UpdateStatus(message, color))); return; }
        _status.Text = message;
        _status.ForeColor = color;
    }

    private void AppendLog(string message)
    {
        if (InvokeRequired) { Invoke(new Action(() => AppendLog(message))); return; }
        _log.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
    }
}
```

---

## Best Practices Summary

### ✅ Do's
- **Separate UI from logic** - Keep measurement code in separate classes
- **Use async/await** - Prevent UI freezing during long operations
- **Invoke for thread safety** - Always check `InvokeRequired` when updating UI from background threads
- **Implement IDisposable** - Properly dispose of NI session objects
- **Centralize theming** - Use a UiTheme class for consistent styling
- **Provide feedback** - Status bar, progress indicators, log output
- **Handle errors gracefully** - Try-catch blocks, user-friendly error messages
- **Enable/disable controls** - Prevent user actions during operations
- **Export results** - CSV export for data analysis

### ❌ Don'ts
- **Don't block UI thread** - Never run measurements synchronously on button click
- **Don't ignore exceptions** - Always catch and display errors
- **Don't forget resource cleanup** - Use `using` statements for NI sessions
- **Don't hardcode paths** - Use file dialogs for user file selection
- **Don't use magic numbers** - Define constants for timeout values, ranges, etc.
- **Don't skip validation** - Check user inputs before starting measurements

---

## Testing Checklist

Before deploying your measurement GUI:

- [ ] Test with actual hardware connected
- [ ] Test with hardware disconnected (error handling)
- [ ] Test with invalid resource names
- [ ] Verify UI doesn't freeze during long measurements
- [ ] Test CSV export with various data sizes
- [ ] Verify chart scales correctly with different data ranges
- [ ] Test cancellation/abort of in-progress measurements
- [ ] Verify memory doesn't leak on repeated measurements
- [ ] Test on different screen resolutions
- [ ] Verify tab order and keyboard navigation

---

## Common Patterns

### Progress Reporting

```csharp
private IProgress<int> _progress;

private async void OnRunWithProgress(object sender, EventArgs e)
{
    _progressBar.Value = 0;
    _progressBar.Visible = true;

    _progress = new Progress<int>(percent =>
    {
        _progressBar.Value = percent;
        _status.Text = $"Progress: {percent}%";
    });

    await Task.Run(() => RunWithProgress(_progress));

    _progressBar.Visible = false;
}

private void RunWithProgress(IProgress<int> progress)
{
    for (int i = 0; i < 100; i++)
    {
        // Do work
        progress?.Report(i + 1);
    }
}
```

### Cancellation Support

```csharp
private CancellationTokenSource _cts;

private async void OnRunCancellable(object sender, EventArgs e)
{
    _cts = new CancellationTokenSource();
    _cancelButton.Enabled = true;

    try
    {
        await Task.Run(() => RunMeasurement(_cts.Token), _cts.Token);
    }
    catch (OperationCanceledException)
    {
        UpdateStatus("Measurement cancelled", UiTheme.Muted);
    }
    finally
    {
        _cancelButton.Enabled = false;
        _cts?.Dispose();
    }
}

private void OnCancel(object sender, EventArgs e)
{
    _cts?.Cancel();
}

private void RunMeasurement(CancellationToken token)
{
    for (int i = 0; i < 1000; i++)
    {
        token.ThrowIfCancellationRequested();
        // Do work
    }
}
```

---

## References

- [Windows Forms Documentation](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- [Chart Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.chart)
- [DataGridView](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview)
- [Async/Await Best Practices](https://docs.microsoft.com/en-us/archive/msdn-magazine/2013/march/async-await-best-practices-in-asynchronous-programming)

---

**Skill Version:** 1.0  
**Last Updated:** 2026-04-24  
**Tested With:** .NET Framework 4.8, NI-SCOPE 23.x, RFmx 23.8
