using System;

namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var jhon = new Person(new[] { "Jhon", "Smith" }, new Address("San Isidro", 41), 40);
            Person jane = new Person(jhon);
            jane.edad = 26;
            jane.Address.HouseNumber = 39;
            jane.Names = new[] { "Jane", "Mary" };
            Console.WriteLine(jhon);
            Console.WriteLine(jane);
        }
    }
}
