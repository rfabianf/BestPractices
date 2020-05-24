using System;
using System.Collections.Generic;
using System.Text;

namespace FacetedBuilder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            this.Person.Company = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            this.Person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int annualIncome)
        {
            this.Person.AnnualIncome = annualIncome;
            return this;
        }
    }
}
