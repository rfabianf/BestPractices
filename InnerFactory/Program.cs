using System;

namespace InnerFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = Point.Factory.NewCartesianPoint(1, Math.PI / 2);
            Console.WriteLine(point);

            Point point2 = Point.Factory.NewPolarPoint(1, Math.PI / 2);
            Console.WriteLine(point2);
        }
    }
}
