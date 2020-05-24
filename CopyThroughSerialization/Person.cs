using System;
using System.Collections.Generic;
using System.Text;

namespace CopyThroughSerialization
{
    //[Serializable]//Se utiliza para serializar binario
    public class Person
    {
        public string[] Names;
        public  Address Address;
        public int edad;
        public Person(string[] names,Address address, int edad)
        {
            this.Names = names;
            this.Address = address;
            this.edad = edad;
        }

        public Person()
        {

        }

        public Person(Person person)
        {
            this.Names = person.Names;
            this.Address = person.Address.DeepCopyXml();
            this.edad = person.edad;
        }


        public override string ToString()
        {
            return $"{nameof(Names)}:{Names[0]},{nameof(Address)} :{Address},{nameof(edad)}:{edad}";
        }

    }
}
