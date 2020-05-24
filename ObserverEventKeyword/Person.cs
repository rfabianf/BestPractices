using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEventKeyword
{
    public class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this, new FallsIllEventArgs() { Address = "Urb San Isidro Mzna W Lote 41"});
        }
        public event EventHandler<FallsIllEventArgs> FallsIll;

    }
}
