using System;

namespace Command
{
    public class BankAccountCommand : ICommand
    {
        BankAccount account;
        public enum Action
        {
            Deposit, WithDraw
        }

        private Action action;
        private int amount;

        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            if (account == null)
            {
                throw new ArgumentNullException(paramName: nameof(account));
            }

            this.account = account;
            this.action = action;
            this.amount = amount;

        }
        public void Call()
        {
            switch (action)
            {
                case Action.Deposit:
                    account.Deposit(amount);
                    break;
                case Action.WithDraw:
                    account.withDraw(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}