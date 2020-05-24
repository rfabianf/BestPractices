using System;
using System.Collections.Generic;
using System.Text;

namespace WeekEventPattern
{
    public  class Button
    {
        public event EventHandler clicked;

        public void Fire()
        {
            clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
