using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithDefaultInterfaceMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon d = new Dragon { Age = 5 };

            if (d is IBird bird)
                bird.Fly();

            if (d is ILizard lizard)
                lizard.Crawl();
        }
    }
}
