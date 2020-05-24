using System;
using System.Collections.Generic;
using System.Text;

namespace FacetedBuilder
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonAddressBuilder At(string streetAdress)
        {
            this.Person.StreetAdress = streetAdress;
            return this;
        }

        public PersonAddressBuilder WithPostCode(string postCode)
        {
            this.Person.PostCode = postCode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            this.Person.City = city;
            return this;
        }
    }   
}
