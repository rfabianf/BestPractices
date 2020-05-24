using System;
using System.Collections.Generic;
using System.Text;

namespace TestabilityIssues
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }
}
