using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSpecification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
