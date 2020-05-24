using System;
using System.Linq;

namespace DependencyInjectionPrinciple
{
    public class Program
    {
        public Program()
        {

        }


        static void Main(string[] args)
        {
            var child1 = new Person() { name = "John Reid" };
            var parent = new Person() { name = "Willy Reid" };
            var child2 = new Person() { name = "Mily Reid" };

            RelationShips relationShips = new RelationShips();
            relationShips.AddParentAndChilds(parent, child1);
            relationShips.AddParentAndChilds(parent, child2);

            new Research(relationShips);
        }
    }
}
