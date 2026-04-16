using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WlanRfAmpTest.Core;
using WlanRfAmpTest.Instrument;

namespace WlanRfAmpTest.Sequencer
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length >= 2 && string.Equals(args[0], "--generate-ts-seq", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    TestStandSequenceFileFactory.Create(args[1]);
                    Console.WriteLine("Wrote TestStand sequence: " + Path.GetFullPath(args[1]));
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                    Environment.ExitCode = 1;
                }
                return;
            }

            if (args.Length >= 2 && string.Equals(args[0], "--generate-ts-seq-bundle", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string outSeq = args[1];
                    string dllPath;
                    if (args.Length >= 3 && !string.IsNullOrWhiteSpace(args[2]))
                        dllPath = Path.GetFullPath(args[2]);
                    else
                        dllPath = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location) ?? Environment.CurrentDirectory, "WlanRfAmpTest.Instrument.dll");

                    if (args.Length >= 4 && !string.IsNullOrWhiteSpace(args[3]))
                    {
                        var snap = TestStandSequenceGenerationSnapshot.CreateTemplateDefaults();
                        snap.CatalogPath = Path.GetFullPath(args[3]);
                        if (!snap.TryComputeTotalPointCount(out int n, out string err))
                        {
                            Console.Error.WriteLine(err);
                            Environment.ExitCode = 1;
                            return;
                        }

                        snap.TotalPointCount = n;
                        TestStandSequenceFileFactory.CreateWlanInstrumentBundle(outSeq, dllPath, snap);
                    }
                    else
                    {
                        TestStandSequenceFileFactory.CreateWlanInstrumentBundle(outSeq, dllPath);
                    }

                    Console.WriteLine("Wrote TestStand bundle: " + Path.GetFullPath(outSeq));
                    Console.WriteLine("Instrument DLL: " + Path.GetFullPath(dllPath));
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                    Environment.ExitCode = 1;
                }
                return;
            }

            if (args.Length > 0 && string.Equals(args[0], "--headless", StringComparison.OrdinalIgnoreCase))
            {
                RunHeadless(args);
                return;
            }

            Application.Run(new MainForm());
        }

        static void RunHeadless(string[] args)
        {
            string? catalog = null;
            string outCsv = Path.Combine(Environment.CurrentDirectory, "wlan_amp_results.csv");
            bool band24 = true;
            bool band5 = true;
            bool orderingFbs = false;
            var cfg = new WlanRfInstrumentConfig();

            for (int i = 1; i < args.Length; i++)
            {
                string a = args[i];
                if (string.Equals(a, "--catalog", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                    catalog = args[++i];
                else if (string.Equals(a, "--out", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                    outCsv = args[++i];
                else if (string.Equals(a, "--no24", StringComparison.OrdinalIgnoreCase))
                    band24 = false;
                else if (string.Equals(a, "--no5", StringComparison.OrdinalIgnoreCase))
                    band5 = false;
                else if (string.Equals(a, "--fbs", StringComparison.OrdinalIgnoreCase) || string.Equals(a, "--freq-bw-std", StringComparison.OrdinalIgnoreCase))
                    orderingFbs = true;
                else if (string.Equals(a, "--resource", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                    cfg.ResourceName = args[++i];
            }

            if (string.IsNullOrWhiteSpace(catalog))
            {
                Console.Error.WriteLine("Usage: WlanRfAmpTest.Sequencer --generate-ts-seq out.seq");
                Console.Error.WriteLine("   or: WlanRfAmpTest.Sequencer --generate-ts-seq-bundle out.seq [path\\to\\WlanRfAmpTest.Instrument.dll] [waveforms.json]");
                Console.Error.WriteLine("        (without waveforms.json the bundle uses CreateTemplateDefaults; with waveforms.json the catalog path is set and point count is computed). Prefer the Sequencer UI to match your sweep UI.");
                Console.Error.WriteLine("   or: WlanRfAmpTest.Sequencer --headless --catalog waveforms.json [--out results.csv] [--no24] [--no5] [--fbs] [--resource 5841]");
                Environment.ExitCode = 2;
                return;
            }

            var wave = WaveformCatalog.FromJsonFile(catalog);
            IReadOnlyList<TestPoint> plan = TestPlanBuilder.Build(wave, band24, band5);
            if (orderingFbs)
                plan = TestPlanBuilder.ApplyOrdering(plan, TestSweepOrdering.FrequencyBandwidthStandard);
            var engine = new SequencerEngine();
            var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (_, e) => { e.Cancel = true; cts.Cancel(); };
            engine.Progress += (idx, tot, msg) => Console.WriteLine("[{0}/{1}] {2}", idx + 1, tot, msg);
            try
            {
                engine.RunAsync(plan, cfg, new SequencerMeasurementOptions(), outCsv, cts.Token).GetAwaiter().GetResult();
                Console.WriteLine("Done. Results: " + outCsv);
            }
            catch (OperationCanceledException)
            {
                Console.Error.WriteLine("Cancelled.");
                Environment.ExitCode = 3;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                Environment.ExitCode = 1;
            }
        }
    }
}
