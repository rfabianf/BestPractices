using System;
using System.Collections.Generic;
using System.Text;

namespace SegregationPrinciple
{
    public class MultiCopyFunctional : IMultiCopyFunctional
    {
        private IPrint print;
        private IScan scan;
        private ICopy copy;

        public MultiCopyFunctional(IPrint print, IScan scan, ICopy copy)
        {
            print = print ?? throw new ArgumentNullException(nameof(print));
            scan = scan ?? throw new ArgumentNullException(nameof(scan));
            copy = copy ?? throw new ArgumentNullException(nameof(copy));


            this.print = print;
            this.scan = scan;
            this.copy = copy;
        }
        public void Copy(Document d)
        {
            copy.Copy(d);
        }

        public void Print(Document d)
        {
            print.Print(d);
        }

        public void Scan(Document d)
        {
            scan.Scan(d);
        }
    }
}
