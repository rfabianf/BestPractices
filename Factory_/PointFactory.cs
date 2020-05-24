﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_
{
    public static class PointFactory
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

