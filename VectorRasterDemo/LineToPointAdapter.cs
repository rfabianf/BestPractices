using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VectorRasterDemo
{
    public class LineToPointAdapter : Collection<Point>
    {
        private static int Count;

        public LineToPointAdapter(Line line) 
        {
            Console.WriteLine($"{++Count}: Generating points for line [{line.start.X},{line.start.Y}]-[{line.end.X},{line.end.Y}] no Caching");

            int left = Math.Min(line.start.X, line.end.X);
            int right = Math.Max(line.start.X, line.end.X);
            int top = Math.Min(line.start.Y, line.end.Y);
            int bottom = Math.Max(line.start.Y, line.end.Y);
            int dx = right - left;
            int dy = line.end.Y - line.start.Y;

            if (dx == 0)
            {
                for (int y = top; y <= bottom; ++y)
                {
                    Add(new Point(left, y));
                }
            }
            else if (dy == 0)
            {
                for (int x = left; x <= right; ++x)
                {
                    Add(new Point(x, top));
                }
            }

        }
    }
}
