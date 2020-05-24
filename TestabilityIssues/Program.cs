using NUnit.Framework;
using System;

namespace TestabilityIssues
{
    class Program
    {
        static void main(string[] args)
        {
            var db = SingletonDatabase.Instance;

            var city = "Seoul";
            Console.WriteLine($"{city} has {db.GetPopulation("Seoul")} people");
        }
    }

}
