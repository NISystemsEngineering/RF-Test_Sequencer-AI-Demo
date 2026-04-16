using System;
using System.Collections.Concurrent;
using System.Threading;

namespace WlanRfAmpTest.Sequencer
{
    /// <summary>Serializes work on a single STA thread (required for NI TestStand Engine COM interop).</summary>
    internal sealed class StaExecutionQueue : IDisposable
    {
        readonly BlockingCollection<Action> _jobs = new BlockingCollection<Action>();
        readonly Thread _thread;

        public StaExecutionQueue()
        {
            _thread = new Thread(Worker)
            {
                IsBackground = true,
                Name = "TestStand STA"
            };
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        void Worker()
        {
            foreach (Action job in _jobs.GetConsumingEnumerable())
            {
                job();
            }
        }

        public void Invoke(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var done = new ManualResetEventSlim(false);
            Exception? caught = null;
            _jobs.Add(() =>
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    caught = ex;
                }
                finally
                {
                    done.Set();
                }
            });
            done.Wait();
            if (caught != null)
                throw caught;
        }

        public void Dispose()
        {
            _jobs.CompleteAdding();
            try
            {
                _thread.Join(TimeSpan.FromSeconds(30));
            }
            catch
            {
                // ignore
            }
            _jobs.Dispose();
        }
    }
}
