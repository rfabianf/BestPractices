using System;
using System.Collections.Generic;
using System.Text;

namespace PointExample
{
    public enum CoordinateSystem
    {
        Cartesian,Polar
    }
    public class Point
    {
        private double a, b;
        public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            switch (system)
            {
                case CoordinateSystem.Cartesian:
                    this.a = a;
                    this.b = b;
            break;

                case CoordinateSystem.Polar:
                    this.a = a * Math.Cos(b);
                    this.b = b * Math.Sin(a);
                    break;

            }
        }
    }
}
