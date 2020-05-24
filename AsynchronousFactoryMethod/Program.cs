using System;
using System.Threading.Tasks;

namespace AsynchronousFactoryMethod
{
    class Program
    {

        public static async Task Main(string[] args)
        {
            //var foo = new Foo();
            //await foo.InitAsync();

            Foo x = await Foo.CreateAsync();
        }
    }
}
