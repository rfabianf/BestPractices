using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in a tea bag boil water, pour {amount} ml and lemon, enjoy");
            return new Tea();
        }
    }

    internal class CofeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml and cream and sugar, enjoy");
            return new Cofee();
        }
    }

    internal class ChocolateFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Peal Cacao's tablet and put on hot boil, pour {amount} ml and enjoy");
            return new Chocolate();
        }
    }
}
