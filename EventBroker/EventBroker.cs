using System;
using System.Reactive.Subjects;

namespace EventBroker
{
    public class EventBroker : IObservable<ActorEvent>
    {
        private Subject<ActorEvent> subscriptions = new Subject<ActorEvent>();
        public IDisposable Subscribe(IObserver<ActorEvent> observer)
        {
            return subscriptions.Subscribe(observer);
        }

        public void Publish(ActorEvent pe)
        {
            subscriptions.OnNext(pe);
        }

        public string Reason { get; set; }
    }
}