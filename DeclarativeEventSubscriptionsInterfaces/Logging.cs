using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeEventSubscriptionsInterfaces
{
    public class Logging : IHandle<ButtonPressedEvent>
    {
        public void Handle(object sender, ButtonPressedEvent args)
        {
            Console.WriteLine($"Button clicked {args.NumberOfClicks} times");
        }
    }
}
