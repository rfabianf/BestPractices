using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    public class AndSpecification<Persona> : ISpecification<Persona>
    {
        ISpecification<Persona> first, second;

        public AndSpecification(ISpecification<Persona> first, ISpecification<Persona>  second)
        {
            this.first = first ?? throw new ArgumentNullException(nameof(first));
            this.second = second ?? throw new ArgumentNullException(nameof(second));
        }
        public bool IsSatisfied(Persona t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}
