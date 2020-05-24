using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionBuilder
{
    public abstract class FunctionalBuider<TSubject,TSelf> 
        where TSelf : FunctionalBuider<TSubject, TSelf>
        where TSubject: new ()
    {
        private readonly List<Func<TSubject, TSubject>> actions = new List<Func<TSubject, TSubject>>();

        //public TSelf Called(string name) => Do(p => p.Name = name);
        public TSelf Do(Action<TSubject> action) => AddAction(action);

        public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));
        private TSelf AddAction(Action<TSubject> action)
        {
            actions.Add(p => {
                action(p);
                return p;
            });
            return (TSelf) this;
        }
    }
}
