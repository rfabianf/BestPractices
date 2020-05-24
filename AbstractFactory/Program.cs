    using System;
using static AbstractFactory.HotDrinkMachine;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(AvailableDrink.Chocolate,300);
            drink.Consume();
        }
    }
}
