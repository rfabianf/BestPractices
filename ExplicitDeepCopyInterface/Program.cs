using System;

namespace ExplicitDeepCopyInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var jhon = new Person(new[] { "Jhon", "Smith" }, new Address("San Isidro", 41), 40);
            Person jane = jhon.DeepCopy();

            jane.edad = 26;
            jane.Address.HouseNumber = 39;
            jane.Names = new[] { "Jane", "Mary" };

            Person domingo = jane.DeepCopy();
            domingo.edad = 60;
            domingo.Names = new[] { "Placido","Domingo" };

            Console.WriteLine(jhon);
            Console.WriteLine(jane);
            Console.WriteLine(domingo);
        }
    }
}
