using System;

namespace SingletonLazy
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = SingletonDatabase.Instance;


            var city = "Seoul";
            Console.WriteLine($"{city} has {db.GetPopulation("Seoul")} people");
        }
    }
}
