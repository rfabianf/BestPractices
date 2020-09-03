using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var cb = new ContainerBuilder();
            cb.RegisterType<BankAccount>();
            cb.RegisterType<NullLog>().As<ILog>();

            //var log = new ConsoleLog();
            //cb.Register(ctx => new BankAccount(log));

            using (var c = cb.Build())
            {
                var ba = c.Resolve<BankAccount>();
                ba.Deposit(400);
            }

                //var log = new ConsoleLog();
                //var ba = new BankAccount(log);
            //    var ba = new BankAccount(null);
            //ba.Deposit(100);
        }
    }
}
