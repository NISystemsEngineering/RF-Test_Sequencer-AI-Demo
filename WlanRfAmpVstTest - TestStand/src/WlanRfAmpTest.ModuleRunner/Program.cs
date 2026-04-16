using System;
using System.Threading;
using System.Windows.Forms;

namespace WlanRfAmpTest.ModuleRunner
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (_, e) =>
            {
                try
                {
                    MessageBox.Show(
                        e.Exception.ToString(),
                        "Module runner — UI thread error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch
                {
                    // ignore secondary failures
                }
            };
            AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                {
                    try
                    {
                        MessageBox.Show(
                            ex.ToString(),
                            "Module runner — unhandled error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    catch
                    {
                        // ignore
                    }
                }
            };
            Application.Run(new MainForm());
        }
    }
}
