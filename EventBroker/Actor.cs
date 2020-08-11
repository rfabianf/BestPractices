using System;

namespace EventBroker
{
    public class Actor
    {
        public EventBroker broker;

        public Actor(EventBroker broker)
        {
            this.broker = broker ?? throw new ArgumentNullException(paramName: nameof(broker));
        }

    }
}