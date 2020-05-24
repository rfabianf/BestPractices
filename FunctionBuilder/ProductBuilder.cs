using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionBuilder
{
    public sealed class ProductBuilder : FunctionalBuider<Product,ProductBuilder>
    {
        public string Person;
        public ProductBuilder(string person)
        {
            this.Person = person;
        }

        public ProductBuilder AddField(string Name, string _string)
        {
            return this;
        }
        public ProductBuilder Called(string name) => Do(p => p.Category = name);
    }
}
