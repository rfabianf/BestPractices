using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba,BankAccountCommand.Action.Deposit,100),
                new BankAccountCommand(ba, BankAccountCommand.Action.WithDraw, 50),
                new BankAccountCommand(ba, BankAccountCommand.Action.WithDraw, 20)
            };

            Console.WriteLine(ba);

            foreach (var c in commands)
                c.Call();
        }
    }
    
}
