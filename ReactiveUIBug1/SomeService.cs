using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIBug1
{
    public class SomeService
    {
        public void DoStuff()
        {
            Console.WriteLine("Crash");
            Console.WriteLine("Crash");
            Console.WriteLine("Crash");
            Console.WriteLine("Crash");
            Console.WriteLine("Crash");
            Console.WriteLine("Crash");
            Console.WriteLine("Crash");

            var a = 99999;
        }
    }
}
