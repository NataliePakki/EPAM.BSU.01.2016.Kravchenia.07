using System;
using System.Threading;

namespace Task1 {
    public class Timer {
        public event EventHandler<WaitEventArgs> Wait = delegate { };
        protected virtual void OnWait(WaitEventArgs e) {
            EventHandler<WaitEventArgs> temp = Wait;
            temp?.Invoke(this, e);
        }
        public void SetTimer(int seconds) {
            Thread.Sleep(seconds * 1000);
            OnWait(new WaitEventArgs(seconds));
        }
    }
}
