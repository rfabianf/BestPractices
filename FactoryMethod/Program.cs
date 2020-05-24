using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = Point.NewCartesianPoint(1,Math.PI / 2);
            Console.WriteLine( point);

            Point point2 = Point.NewPolarPoint(1, Math.PI / 2);
            Console.WriteLine(point2);
        }
    }
}
