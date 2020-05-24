using System;
using System.Collections.Generic;
using System.Text;

namespace WeekEventPattern
{
    public class Window
    {
        public Window(Button button)
        {
            button.clicked += ButtonOnClicked;

        }

        private void ButtonOnClicked(object sender,EventArgs eventArgs)
        {
            Console.WriteLine("Button clicked(Window Handler)");
        }
    }
}
