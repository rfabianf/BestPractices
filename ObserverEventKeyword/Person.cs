using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEventKeyword
{
    public class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this,new FallsIllEventArgs() { Nombre = "Jorge Perez Perez",Address = "Urb Colonial 123"});
        }

        public event EventHandler<FallsIllEventArgs> FallsIll;

    }
}
