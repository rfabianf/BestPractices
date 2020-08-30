using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeEventSubscriptionsInterfaces
{
    public interface IHandle<TEvent> where TEvent : IEvent
    {
        void Handle(object sender, TEvent args);
    }
}
