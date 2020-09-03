using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class BankAccount
    {
        private ILog log;
        private int balance;

        public BankAccount([CanBeNull]ILog log)
        {
            this.log = log ?? throw new ArgumentNullException(paramName: nameof(log));
        }

        public void Deposit(int amount)
        {
            balance += amount;
            log?.Info($"Deposited {amount}, balance is now {balance}");
        }
    }
}
