using System;
using System.Drawing;
using System.Windows.Forms;
using WlanRfAmpTest.Instrument;

namespace WlanRfAmpTest.ModuleRunner
{
    partial class MainForm
    {
        Control _cfgGroupSignal = null!;
        Control _cfgGroupModAcc = null!;
        Control _cfgGroupTxp = null!;
        Control _cfgGroupSem = null!;

        TableLayoutPanel _cfgOuter = null!;

        TextBox _cfgRefLevel = null!;
        TextBox _cfgExtAtten = null!;
        TextBox _cfgRfsgPower = null!;
        TextBox _cfgMeasTimeout = null!;
        CheckBox _cfgIqTrigger = null!;
        TextBox _cfgTrigLevel = null!;
        TextBox _cfgTrigDelay = null!;
        TextBox _cfgMinQuietSec = null!;
        ComboBox _cfgMinQuietMode = null!;

        TextBox _cfgModOffset = null!;
        TextBox _cfgModMaxLen = null!;
        ComboBox _cfgFreqErrEst = null!;
        ComboBox _cfgChEst = null!;
        ComboBox _cfgPhaseTrack = null!;
        ComboBox _cfgAmpTrack = null!;
        ComboBox _cfgSymClk = null!;
        ComboBox _cfgModAvgEn = null!;
        TextBox _cfgModAvgCount = null!;

        CheckBox _cfgTxpAuto = null!;
        TextBox _cfgTxpAutoInterval = null!;
        ComboBox _cfgTxpAvgEn = null!;
        TextBox _cfgTxpAvgCount = null!;
        TextBox _cfgTxpMaxInterval = null!;

        ComboBox _cfgSemAvgEn = null!;
        TextBox _cfgSemAvgCount = null!;
        ComboBox _cfgSemAvgType = null!;
        ComboBox _cfgSemSpanAuto = null!;
        TextBox _cfgSemSpanHz = null!;
        ComboBox _cfgSemSweepAuto = null!;
        TextBox _cfgSemSweepSec = null!;
        ComboBox _cfgSemMask = null!;

        Panel CreateInstrumentConfigPanel()
        {
            _cfgRefLevel = CfgText();
            _cfgExtAtten = CfgText();
            _cfgRfsgPower = CfgText();
            _cfgMeasTimeout = CfgText();
            _cfgIqTrigger = new CheckBox { AutoSize = true, ForeColor = UiTheme.Text, Margin = new Padding(2, 4, 0, 0) };
            _cfgTrigLevel = CfgText();
            _cfgTrigDelay = CfgText();
            _cfgMinQuietSec = CfgText();
            _cfgMinQuietMode = CfgCombo();

            _cfgModOffset = CfgText();
            _cfgModMaxLen = CfgText();
            _cfgFreqErrEst = CfgCombo();
            _cfgChEst = CfgCombo();
            _cfgPhaseTrack = CfgCombo();
            _cfgAmpTrack = CfgCombo();
            _cfgSymClk = CfgCombo();
            _cfgModAvgEn = CfgCombo();
            _cfgModAvgCount = CfgText();

            _cfgTxpAuto = new CheckBox { AutoSize = true, ForeColor = UiTheme.Text, Margin = new Padding(2, 4, 0, 0) };
            _cfgTxpAutoInterval = CfgText();
            _cfgTxpAvgEn = CfgCombo();
            _cfgTxpAvgCount = CfgText();
            _cfgTxpMaxInterval = CfgText();

            _cfgSemAvgEn = CfgCombo();
            _cfgSemAvgCount = CfgText();
            _cfgSemAvgType = CfgCombo();
            _cfgSemSpanAuto = CfgCombo();
            _cfgSemSpanHz = CfgText();
            _cfgSemSweepAuto = CfgCombo();
            _cfgSemSweepSec = CfgText();
            _cfgSemMask = CfgCombo();

            FillStringCombo(_cfgMinQuietMode, WlanRfInstrumentUiCatalog.MinimumQuietTimeModes(), null);
            FillStringCombo(_cfgFreqErrEst, WlanRfInstrumentUiCatalog.FrequencyErrorEstimationMethods(), null);
            FillStringCombo(_cfgChEst, WlanRfInstrumentUiCatalog.ChannelEstimationTypes(), null);
            FillStringCombo(_cfgPhaseTrack, WlanRfInstrumentUiCatalog.PhaseTrackingModes(), null);
            FillStringCombo(_cfgAmpTrack, WlanRfInstrumentUiCatalog.AmplitudeTrackingModes(), null);
            FillStringCombo(_cfgSymClk, WlanRfInstrumentUiCatalog.SymbolClockCorrections(), null);
            FillStringCombo(_cfgModAvgEn, WlanRfInstrumentUiCatalog.OfdmModAccAveragingModes(), null);
            FillStringCombo(_cfgTxpAvgEn, WlanRfInstrumentUiCatalog.TxpAveragingModes(), null);
            FillStringCombo(_cfgSemAvgEn, WlanRfInstrumentUiCatalog.SemAveragingModes(), null);
            FillStringCombo(_cfgSemAvgType, WlanRfInstrumentUiCatalog.SemAveragingTypes(), null);
            FillStringCombo(_cfgSemSpanAuto, WlanRfInstrumentUiCatalog.SemSpanAutoModes(), null);
            FillStringCombo(_cfgSemSweepAuto, WlanRfInstrumentUiCatalog.SemSweepTimeAutoModes(), null);
            FillStringCombo(_cfgSemMask, WlanRfInstrumentUiCatalog.SemMaskTypes(), null);

            ApplyInstrumentUiModelToControls(WlanRfInstrumentUiModel.FromDefaults());

            var signalGrid = new TableLayoutPanel { AutoSize = true, ColumnCount = 4, Padding = new Padding(0, 2, 0, 0) };
            ApplyTwoPairColumnStyles(signalGrid);
            int r = 0;
            AddPairRow2(signalGrid, ref r, "Ref lvl (dBm)", _cfgRefLevel, "Ext att (dB)", _cfgExtAtten);
            AddPairRow2(signalGrid, ref r, "RFSG (dBm)", _cfgRfsgPower, "Timeout (s)", _cfgMeasTimeout);
            AddPairRow2(signalGrid, ref r, "IQ edge trig", _cfgIqTrigger, "Trig lvl (dB)", _cfgTrigLevel);
            AddPairRow2(signalGrid, ref r, "Trig delay (s)", _cfgTrigDelay, "Min quiet (s)", _cfgMinQuietSec);
            AddFullWidthValueRow(signalGrid, ref r, "Min quiet mode", _cfgMinQuietMode, 4);
            _cfgGroupSignal = WrapCompactSection("Signal & trigger", signalGrid);

            var modGrid = BuildThreePairGrid(
                ("Offset (sym)", _cfgModOffset),
                ("Max len (sym)", _cfgModMaxLen),
                ("Freq err est", _cfgFreqErrEst),
                ("Ch estimation", _cfgChEst),
                ("Phase track", _cfgPhaseTrack),
                ("Amp track", _cfgAmpTrack),
                ("Sym clk corr", _cfgSymClk),
                ("Averaging", _cfgModAvgEn),
                ("Avg count", _cfgModAvgCount));
            _cfgGroupModAcc = WrapCompactSection("OFDM ModAcc (EVM)", modGrid);

            var txpGrid = BuildThreePairGrid(
                ("Auto lvl", _cfgTxpAuto),
                ("Auto intvl (s)", _cfgTxpAutoInterval),
                ("TxP avg", _cfgTxpAvgEn),
                ("Avg count", _cfgTxpAvgCount),
                ("Max meas (s)", _cfgTxpMaxInterval));
            _cfgGroupTxp = WrapCompactSection("Tx power", txpGrid);

            var semGrid = BuildThreePairGrid(
                ("SEM avg", _cfgSemAvgEn),
                ("Avg count", _cfgSemAvgCount),
                ("Avg type", _cfgSemAvgType),
                ("Span auto", _cfgSemSpanAuto),
                ("Span (Hz)", _cfgSemSpanHz),
                ("Swp auto", _cfgSemSweepAuto),
                ("Swp time (s)", _cfgSemSweepSec),
                ("Mask", _cfgSemMask));
            _cfgGroupSem = WrapCompactSection("SEM", semGrid);

            var rightCol = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 1,
                RowCount = 3,
                Dock = DockStyle.Fill,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };
            rightCol.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rightCol.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rightCol.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rightCol.Controls.Add(_cfgGroupModAcc, 0, 0);
            rightCol.Controls.Add(_cfgGroupTxp, 0, 1);
            rightCol.Controls.Add(_cfgGroupSem, 0, 2);

            _cfgOuter = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 2,
                RowCount = 1,
                Dock = DockStyle.Top,
                Padding = new Padding(0, 2, 0, 4),
                Margin = new Padding(0),
                BackColor = UiTheme.Panel
            };
            _cfgOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            _cfgOuter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            _cfgOuter.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _cfgOuter.Controls.Add(_cfgGroupSignal, 0, 0);
            _cfgOuter.Controls.Add(rightCol, 1, 0);
            _cfgGroupSignal.Dock = DockStyle.Fill;
            rightCol.Dock = DockStyle.Fill;

            var root = new Panel
            {
                AutoSize = true,
                AutoScroll = false,
                Dock = DockStyle.Top,
                Padding = new Padding(0),
                BackColor = UiTheme.Panel
            };
            root.Controls.Add(_cfgOuter);
            void SyncOuterWidth()
            {
                int w = Math.Max(400, root.ClientSize.Width);
                if (w <= 0)
                    return;
                _cfgOuter.Width = w;
            }
            root.SizeChanged += (_, _) => SyncOuterWidth();
            root.HandleCreated += (_, _) => SyncOuterWidth();
            SyncOuterWidth();
            return root;
        }

        static void ApplyTwoPairColumnStyles(TableLayoutPanel g)
        {
            g.ColumnStyles.Clear();
            g.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96f));
            g.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            g.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96f));
            g.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        }

        static void ApplyThreePairColumnStyles(TableLayoutPanel g)
        {
            g.ColumnStyles.Clear();
            for (int i = 0; i < 3; i++)
            {
                g.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82f));
                g.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
            }
        }

        static Label CfgTableLabel(string text) =>
            new Label
            {
                Text = text + ":",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = UiTheme.Text,
                Margin = new Padding(0, 2, 4, 2)
            };

        static void AddPairRow2(TableLayoutPanel g, ref int row, string l1, Control c1, string l2, Control c2)
        {
            g.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            g.Controls.Add(CfgTableLabel(l1), 0, row);
            c1.Margin = new Padding(0, 2, 8, 2);
            c1.Dock = DockStyle.Fill;
            g.Controls.Add(c1, 1, row);
            g.Controls.Add(CfgTableLabel(l2), 2, row);
            c2.Margin = new Padding(0, 2, 0, 2);
            c2.Dock = DockStyle.Fill;
            g.Controls.Add(c2, 3, row);
            row++;
        }

        static void AddFullWidthValueRow(TableLayoutPanel g, ref int row, string label, Control value, int columnCount)
        {
            g.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            g.Controls.Add(CfgTableLabel(label), 0, row);
            value.Margin = new Padding(0, 2, 0, 2);
            value.Dock = DockStyle.Fill;
            g.SetColumnSpan(value, columnCount - 1);
            g.Controls.Add(value, 1, row);
            row++;
        }

        TableLayoutPanel BuildThreePairGrid(params (string label, Control c)[] fields)
        {
            var g = new TableLayoutPanel { AutoSize = true, ColumnCount = 6, Padding = new Padding(0, 2, 0, 0) };
            ApplyThreePairColumnStyles(g);
            const int pairsPerRow = 3;
            int row = 0;
            for (int i = 0; i < fields.Length; i += pairsPerRow)
            {
                g.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
                int col = 0;
                for (int p = 0; p < pairsPerRow && i + p < fields.Length; p++)
                {
                    var (label, ctrl) = fields[i + p];
                    g.Controls.Add(CfgTableLabel(label), col, row);
                    ctrl.Margin = new Padding(0, 2, p < pairsPerRow - 1 ? 6 : 0, 2);
                    ctrl.Dock = DockStyle.Fill;
                    g.Controls.Add(ctrl, col + 1, row);
                    col += 2;
                }
                row++;
            }
            return g;
        }

        Control WrapCompactSection(string title, TableLayoutPanel grid)
        {
            var shell = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                WrapContents = false,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(38, 42, 52),
                Padding = new Padding(6, 5, 6, 6),
                Margin = new Padding(0, 0, 0, 4)
            };
            var head = new Label
            {
                Text = title,
                AutoSize = true,
                ForeColor = UiTheme.Accent,
                Font = new Font(Font.FontFamily, 8.25f, FontStyle.Bold),
                Margin = new Padding(0, 0, 0, 4)
            };
            grid.Margin = new Padding(0);
            shell.Controls.Add(head);
            shell.Controls.Add(grid);
            shell.SizeChanged += (_, _) =>
            {
                int iw = shell.ClientSize.Width - shell.Padding.Horizontal;
                if (iw > 40)
                    grid.Width = iw;
            };
            return shell;
        }

        void UpdateInstrumentConfigVisibility()
        {
            int idx = _combo.SelectedIndex;
            bool evm = idx == 0 || idx == 3;
            bool txp = idx == 1 || idx == 3;
            bool sem = idx == 2;
            _cfgGroupModAcc.Visible = evm;
            _cfgGroupTxp.Visible = txp;
            _cfgGroupSem.Visible = sem;
            _cfgOuter.PerformLayout();
        }

        WlanRfInstrumentConfig BuildInstrumentConfigFromUi()
        {
            var m = new WlanRfInstrumentUiModel
            {
                ResourceName = _resource.Text.Trim(),
                ReferenceLevelDbm = _cfgRefLevel.Text.Trim(),
                ExternalAttenuationDb = _cfgExtAtten.Text.Trim(),
                RfsgPowerDbm = _cfgRfsgPower.Text.Trim(),
                MeasurementTimeoutSec = _cfgMeasTimeout.Text.Trim(),
                IqPowerEdgeTriggerEnabled = _cfgIqTrigger.Checked,
                IqPowerEdgeLevelDb = _cfgTrigLevel.Text.Trim(),
                TriggerDelaySec = _cfgTrigDelay.Text.Trim(),
                MinimumQuietTimeSec = _cfgMinQuietSec.Text.Trim(),
                MinimumQuietTimeMode = GetComboString(_cfgMinQuietMode, "Minimum quiet time mode"),
                OfdmModAccMeasurementOffsetSymbols = _cfgModOffset.Text.Trim(),
                OfdmModAccMaxMeasurementLengthSymbols = _cfgModMaxLen.Text.Trim(),
                FrequencyErrorEstimationMethod = GetComboString(_cfgFreqErrEst, "Frequency error estimation"),
                ChannelEstimationType = GetComboString(_cfgChEst, "Channel estimation"),
                PhaseTracking = GetComboString(_cfgPhaseTrack, "Phase tracking"),
                AmplitudeTracking = GetComboString(_cfgAmpTrack, "Amplitude tracking"),
                SymbolClockCorrection = GetComboString(_cfgSymClk, "Symbol clock correction"),
                OfdmModAccAveragingEnabled = GetComboString(_cfgModAvgEn, "ModAcc averaging"),
                OfdmModAccAveragingCount = _cfgModAvgCount.Text.Trim(),
                TxpAutoLevel = _cfgTxpAuto.Checked,
                TxpAutoLevelIntervalSec = _cfgTxpAutoInterval.Text.Trim(),
                TxpAveragingEnabled = GetComboString(_cfgTxpAvgEn, "TxP averaging"),
                TxpAveragingCount = _cfgTxpAvgCount.Text.Trim(),
                TxpMaximumMeasurementIntervalSec = _cfgTxpMaxInterval.Text.Trim(),
                SemAveragingEnabled = GetComboString(_cfgSemAvgEn, "SEM averaging"),
                SemAveragingCount = _cfgSemAvgCount.Text.Trim(),
                SemAveragingType = GetComboString(_cfgSemAvgType, "SEM averaging type"),
                SemSpanAuto = GetComboString(_cfgSemSpanAuto, "SEM span auto"),
                SemSpanHz = _cfgSemSpanHz.Text.Trim(),
                SemSweepTimeAuto = GetComboString(_cfgSemSweepAuto, "SEM sweep time auto"),
                SemSweepTimeSec = _cfgSemSweepSec.Text.Trim(),
                SemMaskType = GetComboString(_cfgSemMask, "SEM mask type")
            };
            return m.ToConfig();
        }

        void ApplyInstrumentUiModelToControls(WlanRfInstrumentUiModel m)
        {
            _cfgRefLevel.Text = m.ReferenceLevelDbm;
            _cfgExtAtten.Text = m.ExternalAttenuationDb;
            _cfgRfsgPower.Text = m.RfsgPowerDbm;
            _cfgMeasTimeout.Text = m.MeasurementTimeoutSec;
            _cfgIqTrigger.Checked = m.IqPowerEdgeTriggerEnabled;
            _cfgTrigLevel.Text = m.IqPowerEdgeLevelDb;
            _cfgTrigDelay.Text = m.TriggerDelaySec;
            _cfgMinQuietSec.Text = m.MinimumQuietTimeSec;
            SelectStringCombo(_cfgMinQuietMode, m.MinimumQuietTimeMode);

            _cfgModOffset.Text = m.OfdmModAccMeasurementOffsetSymbols;
            _cfgModMaxLen.Text = m.OfdmModAccMaxMeasurementLengthSymbols;
            SelectStringCombo(_cfgFreqErrEst, m.FrequencyErrorEstimationMethod);
            SelectStringCombo(_cfgChEst, m.ChannelEstimationType);
            SelectStringCombo(_cfgPhaseTrack, m.PhaseTracking);
            SelectStringCombo(_cfgAmpTrack, m.AmplitudeTracking);
            SelectStringCombo(_cfgSymClk, m.SymbolClockCorrection);
            SelectStringCombo(_cfgModAvgEn, m.OfdmModAccAveragingEnabled);
            _cfgModAvgCount.Text = m.OfdmModAccAveragingCount;

            _cfgTxpAuto.Checked = m.TxpAutoLevel;
            _cfgTxpAutoInterval.Text = m.TxpAutoLevelIntervalSec;
            SelectStringCombo(_cfgTxpAvgEn, m.TxpAveragingEnabled);
            _cfgTxpAvgCount.Text = m.TxpAveragingCount;
            _cfgTxpMaxInterval.Text = m.TxpMaximumMeasurementIntervalSec;

            SelectStringCombo(_cfgSemAvgEn, m.SemAveragingEnabled);
            _cfgSemAvgCount.Text = m.SemAveragingCount;
            SelectStringCombo(_cfgSemAvgType, m.SemAveragingType);
            SelectStringCombo(_cfgSemSpanAuto, m.SemSpanAuto);
            _cfgSemSpanHz.Text = m.SemSpanHz;
            SelectStringCombo(_cfgSemSweepAuto, m.SemSweepTimeAuto);
            _cfgSemSweepSec.Text = m.SemSweepTimeSec;
            SelectStringCombo(_cfgSemMask, m.SemMaskType);
        }

        static string GetComboString(ComboBox cb, string fieldName)
        {
            if (cb.SelectedItem is string s && !string.IsNullOrEmpty(s))
                return s;
            throw new InvalidOperationException("Select a value for " + fieldName + ".");
        }

        static void FillStringCombo(ComboBox cb, string[] names, string select)
        {
            cb.Items.Clear();
            foreach (var n in names)
                cb.Items.Add(n);
            if (!string.IsNullOrEmpty(select) && cb.Items.Contains(select))
                cb.SelectedItem = select;
            else if (cb.Items.Count > 0)
                cb.SelectedIndex = 0;
        }

        static void SelectStringCombo(ComboBox cb, string value)
        {
            if (string.IsNullOrEmpty(value))
                return;
            int i = cb.FindStringExact(value);
            if (i >= 0)
                cb.SelectedIndex = i;
            else if (cb.Items.Count > 0)
                cb.SelectedIndex = 0;
        }

        static TextBox CfgText()
        {
            var t = new TextBox { Height = 22, MinimumSize = new Size(44, 22) };
            UiTheme.StyleTextBox(t);
            return t;
        }

        ComboBox CfgCombo()
        {
            var c = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Height = 22,
                MinimumSize = new Size(60, 22),
                DropDownWidth = 320
            };
            c.BackColor = UiTheme.Panel;
            c.ForeColor = UiTheme.Text;
            c.FlatStyle = FlatStyle.Flat;
            return c;
        }
    }
}
