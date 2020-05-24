using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDI
{
    public class ConfigurableRecordFinder
    {
        private IDatabase database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            this.database = database ?? throw new ArgumentNullException(paramName: nameof(database));
        }

        public int getTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
                //result += SingletonDatabase.Instance.GetPopulation(name);//Reemplazamos esta referencia a una instancia
                result += database.GetPopulation(name);
            return result;
        }
    }
}
