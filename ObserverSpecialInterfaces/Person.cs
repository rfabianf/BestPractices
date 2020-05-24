using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSpecialInterfaces
{
    public class Person :IObservable<Event>
    {
        public readonly HashSet<Subscription> subscriptions = new HashSet<Subscription>();

        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            subscriptions.Add(subscription);
            return subscription;
        }

        public void FallsIll()
        {
            foreach (var item in subscriptions)
            {
                item.Observer.OnNext(new FallsIllEvent { Address = "Urb San Isidro Mzna W lote 41" });
            }
        }

        
    }
}
