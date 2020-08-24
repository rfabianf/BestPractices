using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDependencies
{
    class Program
    {
        public static void Main(string[] args)
        {
            var p = new Person();
            p.PropertyChanged += (sender, EventArgs) =>
             {
                 Console.WriteLine($"{EventArgs.PropertyName} changed");
             };
            p.Age = 15;
            p.Citizen = true;
            p.Sex = "M";
        }
    }
}
