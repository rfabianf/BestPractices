using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCodingExercise
{
    public class PersonaFactory
    {
        private int id = 0;
        public Person CreatePerson(string name)
        {
           Person person = new Person(name, id);
            id += 1;
            return person;
        }
    }
}
