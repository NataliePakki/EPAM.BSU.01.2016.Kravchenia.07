using System;

namespace Task1.Listeners {
    public class Cat {
        public void Register(Timer timer) => timer.Wait += CatMsg;
        public void Unregister(Timer timer) => timer.Wait -= CatMsg;

        private void CatMsg(Object sender, WaitEventArgs eventArgs) {
            Console.WriteLine("Cat say:");
            Console.WriteLine("meoew-meow-meoew!");
        }
    }
}
