using System;

namespace PrototypeCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = new Line()
            {
                Start = new Point() { X = 1, Y = 2 },
                End = new Point() { X = 5, Y = 10 }
            };
            var line2 = line1.DeepCopy();

            line1.Start.X = line1.End.X = line1.Start.Y = line1.End.Y = 0;

            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
