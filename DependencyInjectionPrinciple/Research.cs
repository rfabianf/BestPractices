using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionPrinciple
{
    public class Research
    {
        public Research()
        {
                
        }
        public Research(IRelationShipBrowser RelationShipBrowser)
        {
            var rel = RelationShipBrowser.GetChildrensOf("Willy Reid");
            foreach (var item in rel)
            {
                Console.WriteLine($" Willy es el papá de {item.name}");
            }

        }
        public Research(RelationShips relationShips)
        {
            //high - level: find all of john's children
            var rel = relationShips.Relations;
            foreach (var item in rel.Where(x => x.Item1.name == "Willy Reid" && x.Item2.Equals(RelationShip.Parent)))
            {
                Console.WriteLine($"Willy is parent of {item.Item3.name}");
            }
        }
    }
}
