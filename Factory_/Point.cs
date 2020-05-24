using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_
{
    public enum CoordinateSystem
    {
        Cartesian,Polar
    }
    public class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)} : {x} , {nameof(y)} : {y}";
        }
    }
}
