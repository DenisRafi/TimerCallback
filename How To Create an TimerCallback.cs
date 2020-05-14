using System;
using System.Threading;

namespace CA
{
    class Program
    {
        static void Main()
        {
            Timer t = new Timer(TimerCallback, null, 0, 1000);         
            Console.ReadLine();
        }
        private static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            GC.Collect();
        }
    }
}

