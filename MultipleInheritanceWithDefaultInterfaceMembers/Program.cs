using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dragon();
            d.Weight = 50;
            d.Fly();
            d.Craw();
            
        }
    }
}
