using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WlanRfAmpTest.Core;
using WlanRfAmpTest.Instrument;

namespace WlanRfAmpTest.Sequencer
{
    public sealed class SequencerEngine
    {
        /// <summary>Raised when point <paramref name="index"/> (0-based) is about to run; <paramref name="total"/> is plan length.</summary>
        public event Action<int, int, string>? Progress;
        public event Action<MeasurementRow>? RowCompleted;

        public async Task RunAsync(
            IReadOnlyList<TestPoint> plan,
            WlanRfInstrumentConfig instrumentConfig,
            SequencerMeasurementOptions measurementOptions,
            string csvPath,
            CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                WlanMeasurementSweepRunner.Run(
                    plan,
                    instrumentConfig,
                    measurementOptions,
                    csvPath,
                    cancellationToken,
                    Progress,
                    RowCompleted);
            }, cancellationToken).ConfigureAwait(false);
        }
    }
}
