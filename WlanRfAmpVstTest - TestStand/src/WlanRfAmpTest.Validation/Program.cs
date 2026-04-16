using System;
using System.Windows.Forms;

namespace WlanRfAmpTest.Validation
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && string.Equals(args[0], "--compare", StringComparison.OrdinalIgnoreCase))
            {
                RunCliCompare(args);
                return;
            }

            Application.Run(new MainForm());
        }

        static void RunCliCompare(string[] args)
        {
            string baseline = null;
            string candidate = null;
            double? tolEvm = null;
            double? tolTxp = null;
            double? tolSem = null;
            for (int i = 1; i < args.Length; i++)
            {
                if (string.Equals(args[i], "--baseline", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                    baseline = args[++i];
                else if (string.Equals(args[i], "--candidate", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                    candidate = args[++i];
                else if (string.Equals(args[i], "--tol-evm", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length &&
                         double.TryParse(args[++i], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double e))
                    tolEvm = e;
                else if (string.Equals(args[i], "--tol-txp", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length &&
                         double.TryParse(args[++i], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double t))
                    tolTxp = t;
                else if (string.Equals(args[i], "--tol-sem", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length &&
                         double.TryParse(args[++i], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double s))
                    tolSem = s;
            }
            if (string.IsNullOrEmpty(baseline) || string.IsNullOrEmpty(candidate))
            {
                Console.Error.WriteLine("Usage: --compare --baseline gold.csv --candidate new.csv [--tol-evm 0.5] [--tol-txp 0.5] [--tol-sem 0.5]");
                Environment.ExitCode = 2;
                return;
            }
            var c = new CsvRegressionComparator();
            if (tolEvm.HasValue)
                c.EvmToleranceDb = tolEvm.Value;
            if (tolTxp.HasValue)
                c.TxpToleranceDb = tolTxp.Value;
            if (tolSem.HasValue)
                c.SemMarginToleranceDb = tolSem.Value;
            var r = c.Compare(baseline, candidate);
            Console.WriteLine(r.Summarize());
            Environment.ExitCode = r.Success ? 0 : 1;
        }
    }
}
