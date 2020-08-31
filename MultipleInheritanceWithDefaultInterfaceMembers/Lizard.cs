using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithInterfaces
{
    public class Lizard : ILizard
    {
        public int Weight { get; set; }
        public void Craw()
        {
            Console.WriteLine($"Crawling in the dirt with weight {Weight}");
        }
    }
}
