using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithDefaultInterfaceMember
{
    public interface ILizard : ICreature
    {
        void Crawl();
        //{
        //    if(Age < 10)
        //        Console.WriteLine("I am crawling");
        //}
    }
}
