using System;
using System.Collections.Generic;
using System.Text;

namespace ICloneableBad
{
    public class Person : ICloneable
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


        public override string ToString()
        {
            return $"{nameof(Names)}:{Names[0]},{nameof(Address)} :{Address},{nameof(edad)}:{edad}";
        }

        public object Clone()
        {
            return new Person(Names,(Address) Address.Clone(),edad);
        }
    }
}
