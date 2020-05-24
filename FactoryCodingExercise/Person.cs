using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCodingExercise
{
    public class Person
    {
        public int id { set; get; }
        public string name { set; get; }

        public Person(string name,int id)
        {
            this.id = id;
            this.name = name;
        }
    }
}
