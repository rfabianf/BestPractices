using System;
using System.Collections.Generic;
using MoreLinq;

namespace VectorRasterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw();
            Draw();
        }

        public static readonly List<VectorObject> vectorObjects = new List<VectorObject>()
        {
            new VectorRectangle(1,1,2,2),
            new VectorRectangle(3,3,6,6)
        };

        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }
    }
}
