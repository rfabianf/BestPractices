using System;

namespace Factory_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point point = PointFactory.NewCartesianPoint(1, Math.PI / 2);
            Console.WriteLine(point);

            Point point2 = PointFactory.NewPolarPoint(1, Math.PI / 2);
            Console.WriteLine(point2);
        }
    }
}
