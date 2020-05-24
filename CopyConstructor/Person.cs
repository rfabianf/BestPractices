using System;
using System.Collections.Generic;
using System.Text;

namespace CopyConstructor
{
    public class Person
    {
        public string[] Names;
        public readonly Address Address;
        public int edad;
        public Person(string[] names,Address address, int edad)
        {
            this.Names = names;
            this.Address = address;
            this.edad = edad + 2;

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

    }
}
