using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeSpecification
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(params ISpecification<T>[] items) : base(items)
        {

        }
        public override bool IsSatisfied(T t)
        {
            //Any -> OrSpecification
            return items.All(i => i.IsSatisfied(t));
        }
    }
}
