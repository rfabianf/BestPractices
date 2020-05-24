using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
