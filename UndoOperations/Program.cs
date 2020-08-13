using System;
using System.Collections.Generic;
using System.Linq;

namespace UndoOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba,BankAccountCommand.Action.Deposit,100),
                new BankAccountCommand(ba, BankAccountCommand.Action.WithDraw, 1000),
                new BankAccountCommand(ba, BankAccountCommand.Action.WithDraw, 10)
            };

            Console.WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            Console.WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            Console.WriteLine(ba);
        }
    }
}
