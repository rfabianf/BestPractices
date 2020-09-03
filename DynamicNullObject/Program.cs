using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicNullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Null<ILog>.Instance;
            log.Info("sfsdf");

           
            var ba = new BankAccount(log);
            ba.Deposit(1000);

        }
    }
}
