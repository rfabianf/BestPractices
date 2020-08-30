using System;

namespace DeclarativeEventSubscriptionsInterfaces
{
    public class Button : ISend<ButtonPressedEvent>
    {
        public event EventHandler<ButtonPressedEvent> Sender;
        //private readonly EventBroker _broker { get; set; }
        //public Button(EventBroker broker)
        //{
        //    _broker = broker;
        //}

        public void Fire(int clicks)
        {
            //_broker.Publish(....)
            Sender?.Invoke(this, new ButtonPressedEvent
            {
                NumberOfClicks = clicks
            });
        }
    }
}
