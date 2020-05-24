using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPrinciple
{
    public interface IRelationShipBrowser
    {
       IEnumerable<Person> GetChildrensOf(string name);
    }
}
