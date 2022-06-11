using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ceth.Common.Mclock
{
    // The Clock interface makes it possible to replace the monotonic system clock with
    // a simulated clock.
    public interface IClock
    {
        Task<AbsTime> Now();
        Task Sleep(TimeSpan time);
        Task<IChanTimer> NewTimer(TimeSpan time);
        Channel<AbsTime> After(TimeSpan time);

    }
    public class AbsTime {
        private Int64 _abstime;
        public Int64 Get => _abstime;
        public Int64 Set => _abstime;
    }
    // ChanTimer is a cancellable event created by NewTimer.
    public interface IChanTimer
    {
        public Timer Timer { get; set; }
        // The channel returned by C receives a value when the timer expires.
        public Channel<AbsTime> C();
        // Reset reschedules the timer with a new timeout.
        // It should be invoked only on stopped or expired timers with drained channels.
        Task Reset(TimeSpan time);
    }
    // Timer is a cancellable event created by AfterFunc.
    public interface Timer {
        // Stop cancels the timer. It returns false if the timer has already
        // expired or been stopped.
        Task<bool> Stop();
    }
}
