using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSpecification
{
    public class BetterFilter : IFilter<Persona>
    {
        public IEnumerable<Persona> Filter(IEnumerable<Persona> t, ISpecification<Persona> spec)
        {
            foreach (var item in t)
                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }
}
