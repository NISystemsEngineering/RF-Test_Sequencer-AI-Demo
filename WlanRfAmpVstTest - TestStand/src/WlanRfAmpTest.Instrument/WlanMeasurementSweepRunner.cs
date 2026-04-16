using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    /// <summary>Shared synchronous measurement sweep (CSV + orchestrator) used by the WinForms sequencer and TestStand code modules.</summary>
    public static class WlanMeasurementSweepRunner
    {
        public static void Run(
            IReadOnlyList<TestPoint> plan,
            WlanRfInstrumentConfig instrumentConfig,
            SequencerMeasurementOptions measurementOptions,
            string csvPath,
            CancellationToken cancellationToken,
            Action<int, int, string> progress = null,
            Action<MeasurementRow> rowCompleted = null)
        {
            var orchestrator = new WlanMeasurementOrchestrator();
            using var logger = new CsvResultLogger(csvPath, append: false);
            int total = plan.Count;

            for (int i = 0; i < total; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                TestPoint pt = plan[i];
                progress?.Invoke(i, total, string.Format(CultureInfo.InvariantCulture,
                    "Running {0}/{1}  {2}  {3}  {4}  {5}",
                    i + 1, total, pt.BandLabel, ScientificNumberFormat.FormatSi(pt.CenterFrequencyHz, "Hz"), pt.StandardLabel,
                    ScientificNumberFormat.FormatSi(pt.BandwidthMHz * 1e6, "Hz")));

                var row = new MeasurementRow
                {
                    TimestampUtc = DateTime.UtcNow,
                    TestIndex = pt.Index,
                    Band = pt.BandLabel,
                    CenterFrequencyHz = pt.CenterFrequencyHz,
                    Standard = pt.StandardLabel,
                    BandwidthMHz = pt.BandwidthMHz,
                    WaveformPath = pt.WaveformFilePath,
                    Pass = false
                };

                try
                {
                    WlanPointMeasurementResult r = orchestrator.MeasurePoint(pt, instrumentConfig, measurementOptions, cancellationToken);

                    if (measurementOptions.RunCompositeEvmTxp)
                    {
                        row.EvmRmsDb = r.CompositeRmsEvmDb;
                        row.TxpAverageDbm = r.AveragePowerDbm;
                        row.TxpPeakDbm = r.PeakPowerDbm;
                    }
                    else
                    {
                        row.EvmRmsDb = null;
                        row.TxpAverageDbm = null;
                        row.TxpPeakDbm = null;
                    }

                    if (measurementOptions.RunSem)
                    {
                        row.SemMeasurementStatus = r.SemStatus.ToString();
                        row.SemMinMarginDb = r.SemMinMarginDb;
                    }
                    else
                    {
                        row.SemMeasurementStatus = "NotRun";
                        row.SemMinMarginDb = null;
                    }

                    row.Pass = EvaluatePass(r, measurementOptions);
                    row.Error = null;
                    logger.WriteRow(row,
                        measurementOptions.RunCompositeEvmTxp ? r.CompositeDataRmsEvmDb : null,
                        measurementOptions.RunCompositeEvmTxp ? r.CompositePilotRmsEvmDb : null);
                }
                catch (Exception ex)
                {
                    row.Error = ex.Message;
                    row.Pass = false;
                    logger.WriteRow(row, null, null);
                }

                rowCompleted?.Invoke(row);
            }
        }

        static bool EvaluatePass(WlanPointMeasurementResult r, SequencerMeasurementOptions o)
        {
            if (o.RunCompositeEvmTxp)
            {
                if (double.IsNaN(r.CompositeRmsEvmDb) || double.IsInfinity(r.CompositeRmsEvmDb))
                    return false;
            }

            if (o.RunSem)
            {
                string sem = r.SemStatus.ToString();
                if (sem.IndexOf("Fail", StringComparison.OrdinalIgnoreCase) >= 0)
                    return false;
                if (double.IsNaN(r.SemMinMarginDb) || double.IsInfinity(r.SemMinMarginDb))
                    return false;
            }

            return true;
        }
    }
}
