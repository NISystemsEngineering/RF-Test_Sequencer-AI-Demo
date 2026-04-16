using System.Drawing;
using System.Windows.Forms;

namespace WlanRfAmpTest.ModuleRunner
{
    internal static class UiTheme
    {
        public static readonly Color Back = Color.FromArgb(26, 28, 34);
        public static readonly Color Panel = Color.FromArgb(42, 46, 56);
        public static readonly Color Accent = Color.FromArgb(100, 200, 180);
        public static readonly Color Text = Color.FromArgb(238, 240, 245);
        public static readonly Color Muted = Color.FromArgb(160, 165, 175);

        public static void ApplyForm(Form f)
        {
            f.BackColor = Back;
            f.ForeColor = Text;
            f.Font = new Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static void StyleButton(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderColor = Accent;
            b.FlatAppearance.BorderSize = 1;
            b.BackColor = Panel;
            b.ForeColor = Text;
            b.Cursor = Cursors.Hand;
            b.UseCompatibleTextRendering = false;
            b.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
            b.AutoSize = true;
            b.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            b.Padding = new Padding(10, 5, 10, 5);
            b.Margin = new Padding(3, 2, 3, 2);
            b.MinimumSize = new Size(0, 26);
        }

        public static void StyleTextBox(TextBox t)
        {
            t.BackColor = Panel;
            t.ForeColor = Text;
            t.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Back;
            g.BorderStyle = BorderStyle.None;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = Panel;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Text;
            g.DefaultCellStyle.BackColor = Panel;
            g.DefaultCellStyle.ForeColor = Text;
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 90, 100);
            g.DefaultCellStyle.SelectionForeColor = Text;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.ReadOnly = true;
        }
    }
}
