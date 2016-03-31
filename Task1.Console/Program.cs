using Task1.Listeners;
using static System.Console;

namespace Task1.Console {
    class Program {
        static void Main(string[] args) {
            var timer = new Timer();
            var human = new Human();
            var cat = new Cat();
            human.Register(timer);
            cat.Register(timer);
            WriteLine("Put the timer for 30 seconds:");
            timer.SetTimer(30);
            cat.Unregister(timer);
            WriteLine("Cat go away. \nPut the timer for 30 seconds:");
            timer.SetTimer(30);
            ReadKey();
        }
    }
}
