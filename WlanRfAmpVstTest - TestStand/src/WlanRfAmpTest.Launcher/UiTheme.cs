using System.Drawing;
using System.Windows.Forms;

namespace WlanRfAmpTest.Launcher
{
    internal static class UiTheme
    {
        public static readonly Color Back = Color.FromArgb(28, 28, 32);
        public static readonly Color Panel = Color.FromArgb(40, 40, 48);
        public static readonly Color Accent = Color.FromArgb(88, 166, 255);
        public static readonly Color Text = Color.FromArgb(235, 235, 240);
        public static readonly Color Muted = Color.FromArgb(160, 160, 170);

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

        /// <summary>Primary action (e.g. Launch) on dark cards.</summary>
        public static void StylePrimaryButton(Button b)
        {
            StyleButton(b);
            b.BackColor = Color.FromArgb(52, 98, 168);
            b.ForeColor = Color.White;
            b.FlatAppearance.BorderColor = Color.FromArgb(120, 170, 240);
            b.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point);
            b.Padding = new Padding(14, 6, 14, 6);
        }

        public static void StyleTextBox(TextBox t)
        {
            t.BackColor = Panel;
            t.ForeColor = Text;
            t.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
