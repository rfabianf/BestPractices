﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public enum CoordinateSystem
    {
        Cartesian,Polar
    }
    public class Point
    {
        private double x, y;

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), Math.Sin(theta));
        }
        private Point(double x, double y)
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
