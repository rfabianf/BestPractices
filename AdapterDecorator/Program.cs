using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringBuilder s = "hello ";
           
            s += "world";
            Console.WriteLine(s);
        }
    }
}
