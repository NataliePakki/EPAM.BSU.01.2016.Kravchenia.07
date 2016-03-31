using System;

namespace Task1 {
    public class WaitEventArgs : EventArgs {
        private readonly int seconds;
        public WaitEventArgs(int seconds) {
            this.seconds = seconds;
        }
        public int Seconds => seconds;
    }
}

