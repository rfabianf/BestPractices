using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeEventSubscriptionsInterfaces
{
    public interface ISend<TEvent> where TEvent : IEvent
    {
        event EventHandler<TEvent> Sender;
    }
}
