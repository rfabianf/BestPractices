using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
