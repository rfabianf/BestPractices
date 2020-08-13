namespace Command
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;

        public void Deposit(int amount)
        {
            balance += amount;
            System.Console.WriteLine($"Deposite: {amount}, balance is now {balance}");
        }

        public void withDraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                System.Console.WriteLine($"Withdrew: {amount}, balance is now {balance}");
            }

        }
    }
}