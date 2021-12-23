using System.Diagnostics;

namespace ReactiveUIBug1
{
    public class SomeService
    {
        public void DoStuff()
        {
            Trace.WriteLine("Crash");
            Trace.WriteLine("Crash1");
            Trace.WriteLine("Crash2");
            Trace.WriteLine("Crash3");
            Trace.WriteLine("Crash4");
            Trace.WriteLine("Crash5");
            Trace.WriteLine("Crash6");

            var a = 99999;
        }
    }
}
