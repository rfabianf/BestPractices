using System;
using System.Collections.Generic;
using System.Text;

namespace InnerFactory
{
    public class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)} : {x} , {nameof(y)} : {y}";
        }

        public static Point Origen = new Point(0,0);
        public static Point Origen2 => new Point(0, 0);
        //public static PointFactory Factory => new PointFactory();
        public static class Factory 
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), Math.Sin(theta));
            }
        }
    }
}
