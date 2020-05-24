using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonLazy
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }
}
