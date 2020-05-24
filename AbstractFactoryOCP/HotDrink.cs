using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryOCP
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine($"This tea is nice but i'd prefer it  with Milk");
        }
    }

    internal class Cofee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine($"This coffe is sensational");
        }
    }

    internal class Chocolate : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine($"This coffe is so tasty");
        }
    }


}
