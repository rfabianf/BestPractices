using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("Hoy almorze");
            j.AddEntry("Mañana quien sabe");

            string fileName = @"C:\Bankinter\Roberto.txt";
            Persitence o = new Persitence();
            o.SaveToFile(j, fileName, true);


            Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });


        }
    }
}
