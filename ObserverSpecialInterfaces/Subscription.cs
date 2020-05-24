using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSpecialInterfaces
{
    public class Subscription : IDisposable
    {
        private readonly Person person;
        public readonly IObserver<Event> Observer;
        public Subscription(Person person, IObserver<Event> observer)
        {
            this.person = person;
            Observer = observer;
        }
        public void Dispose()
        {
            person.subscriptions.Remove(this);
        }
    }
}
