using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionBuilder
{
    public sealed class PersonBuilder : FunctionalBuider<Person,PersonBuilder>
    {
        public PersonBuilder Called(string name)
            => Do(p => p.Name = name);

    }
}
