using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitDeepCopyInterface 
{
    public class Person: IPrototype<Person>
    {
        public string[] Names;
        public readonly Address Address;
        public int edad;
        public Person(string[] names,Address address, int edad)
        {
            this.Names = names;
            this.Address = address;
            this.edad = edad;
        }

        public Person(Person person)
        {
            this.Names = person.Names;
            this.Address = new Address(person.Address);
            this.edad = person.edad;
        }


        public override string ToString()
        {
            return $"{nameof(Names)}:{Names[0]},{nameof(Address)} :{Address},{nameof(edad)}:{edad}";
        }

        public Person DeepCopy()
        {
            return new Person(Names, Address.DeepCopy(), edad);
        }
    }
}
