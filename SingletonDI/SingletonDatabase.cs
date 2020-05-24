using Autofac;
using MoreLinq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingletonDI
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;
        private static int instanteCount;
        public static int Count => instanteCount;
        private SingletonDatabase()
        {
            instanteCount++;
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
;       }

        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;
    }


    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void IsSingletonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;
            Assert.That(db, Is.SameAs(db2));
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }

        [Test]
        public void SingletonTotalPopulationTest()
        {
            var rf = new SingletonRecordFinder();
            var names = new[] { "Seoul", "Mexico City" };
            int tp = rf.getTotalPopulation(names);
            Assert.That(tp, Is.EqualTo(17500000 + 17400000));
        }

        [Test]
        public void ConfigurationPopulationTest()
        {
            //var rf = new ConfigurableRecordFinder(new DummyDatabase());
            var rf = new ConfigurableRecordFinder(SingletonDatabase.Instance);
            var names = new[] { "alpha", "gamma" };
            int tp = rf.getTotalPopulation(names);
            Assert.That(tp, Is.EqualTo(4));

        }

        [Test]
        public void DIPopulationTest()
        {
            var rf = new ConfigurableRecordFinder(new DummyDatabase());
            var names = new[] { "alpha", "gamma" };
            int tp = rf.getTotalPopulation(names);
            Assert.That(tp, Is.EqualTo(4));

        }

        [Test]
        public void DIContainerPopulationTest()
        {
            var cb = new ContainerBuilder();
            
            cb.RegisterType<DummyDatabase>().As<IDatabase>().SingleInstance();
            //cb.RegisterType<OrdinaryDatabase>().As<IDatabase>();
            cb.RegisterType<ConfigurableRecordFinder>();
            using (var c = cb.Build())
            {
                var rf = c.Resolve<IDatabase>();
                int alfa = rf.GetPopulation("alpha");
            }

        }
    }


}
