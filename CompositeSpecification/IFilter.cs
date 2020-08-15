using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSpecification
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> t, ISpecification<T> spec);
    }
}
