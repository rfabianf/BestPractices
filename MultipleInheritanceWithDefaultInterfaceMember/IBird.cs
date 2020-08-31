using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithDefaultInterfaceMember
{
    public interface IBird : ICreature
    {
        void Fly();
        //{
        //    if(Age>=10)
        //        Console.WriteLine("I'm flying");
        //}
    }
}
