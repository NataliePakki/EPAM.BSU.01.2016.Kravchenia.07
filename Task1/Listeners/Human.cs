using System;

namespace Task1.Listeners {
    public class Human {
        public void Register(Timer timer) => timer.Wait += HumanMsg;
        public void Unregister(Timer timer) => timer.Wait -= HumanMsg;

        private void HumanMsg(Object sender, WaitEventArgs eventArgs) {
            Console.WriteLine("Human say:");
            Console.WriteLine($"I was waiting {eventArgs.Seconds} seconds!");
        }
    }
}
