using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingletonLazy
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;
        private SingletonDatabase()
        {
            Console.WriteLine("Initializing database");

            capitals = File.ReadAllLines("capitals.txt")
                .Batch(2)
                .ToDictionary(
                   list => list.ElementAt(0).Trim(),
                   list => int.Parse(list.ElementAt(1).Trim())
                );
        }
        public int GetPopulation(string name)
        {
            return capitals[name];
;        }

        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;
    }
}
