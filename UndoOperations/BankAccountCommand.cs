using System;

namespace UndoOperations
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
        private bool succeeded;

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
                    succeeded = true;
                    break;
                case Action.WithDraw:
                    succeeded = account.withDraw(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            if (!succeeded) return;
            switch (action)
            {
                case Action.Deposit:
                    account.withDraw(amount);
                    break;
                case Action.WithDraw:
                    account.Deposit(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}