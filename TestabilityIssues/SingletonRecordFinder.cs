using System;
using System.Collections.Generic;
using System.Text;

namespace TestabilityIssues
{
    public class SingletonRecordFinder
    {
        public int getTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach(var name in names)
                result += SingletonDatabase.Instance.GetPopulation(name);
                return result;
        }
    }
}
