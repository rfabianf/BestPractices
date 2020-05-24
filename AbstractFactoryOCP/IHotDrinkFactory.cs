using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryOCP
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
