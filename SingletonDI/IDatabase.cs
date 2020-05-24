using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDI
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }
}
