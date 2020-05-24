using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionPrinciple
{
    //low level
    public class RelationShips : IRelationShipBrowser
    {
        private List<(Person, RelationShip, Person)> relations = new List<(Person, RelationShip, Person)>();

       
        public void AddParentAndChilds(Person parent, Person child)
        {
            relations.Add((parent,RelationShip.Parent,child));
            relations.Add((child, RelationShip.Child, parent));
        }

        public IEnumerable<Person> GetChildrensOf(string name)
        {
            foreach (var item in relations.Where(x => x.Item1.name.Equals(name) && x.Item2.Equals(RelationShip.Parent)))
            {
                yield return item.Item3;
            }
        }

        public List<(Person, RelationShip, Person)> Relations => relations;
    }
}
