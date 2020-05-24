using System;

namespace AbstractFactoryOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var factory = machine.MakeDrink();
            
        }
    }
}
