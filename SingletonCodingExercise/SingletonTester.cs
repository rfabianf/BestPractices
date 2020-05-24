using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonCodingExercise
{
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var obj1 = func();
            var obj2 = func();
            
            return ReferenceEquals(obj1, obj2);
        }

    }

    [TestFixture]
    public class FirstTestSuite
    {
        [Test]
        public void Test()
        {
            var obj = new String("YO");
            decimal obj2 = 100;

            Assert.IsTrue(SingletonTester.IsSingleton(() => obj));
            Assert.IsFalse(SingletonTester.IsSingleton(() => obj2));
        }
    }
}
