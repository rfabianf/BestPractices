using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSpecification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        protected readonly ISpecification<T>[] items;
        protected CompositeSpecification(params ISpecification<T>[] items)
        {
            this.items = items;
        }
        public abstract bool IsSatisfied(T t);
    }
}
