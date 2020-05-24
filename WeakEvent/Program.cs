using System;

namespace WeekEventPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button();
            var window = new Window(button);
            var WindowRef = new WeakReference(window);

            button.Fire();
            Console.WriteLine("Setting Window to null");
            window = null;

            FireGC();
            Console.WriteLine($"Is Windows alive after FireGC? {WindowRef.IsAlive}");
            Console.ReadLine();
        }

        private static void FireGC()
        {
            Console.WriteLine("Starting GC");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine("GC is done!");
        }
    }
}
