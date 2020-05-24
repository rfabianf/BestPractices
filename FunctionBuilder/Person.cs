using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionBuilder
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }

    //public sealed class PersonBuilder
    //{
    //    private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();

    //    public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));

    //    public PersonBuilder Called(string name) => Do(p => p.Name = name);
    //    public PersonBuilder Do(Action<Person> action) => AddAction(action);

    //    private PersonBuilder AddAction(Action<Person> action)
    //    {
    //        actions.Add(p => { action(p);
    //            return p;
    //        });
    //        return this;    
    //    }
    //}


}
