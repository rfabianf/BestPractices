﻿using System;
using System.Collections.Generic;
using System.Text;

namespace  SegregationPrinciple
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new System.NotImplementedException();
        }
    }


}
