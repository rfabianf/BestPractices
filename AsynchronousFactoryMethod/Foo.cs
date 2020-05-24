using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousFactoryMethod
{
    public class Foo
    {
        private Foo()
        {
            
        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(2000);
            return this;
        }

        public static Task<Foo> CreateAsync()
        {
            //await this.InitAsync();
            //return this;
            var result = new Foo();
            return result.InitAsync();
        }

    }
}
