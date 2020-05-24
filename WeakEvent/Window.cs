using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WeekEventPattern
{
    public class Window
    {
        public Window(Button button)
        {
            //button.clicked += ButtonOnClicked;
            WeakEventManager<Button, EventArgs>.AddHandler(button, "clicked", ButtonOnClicked);

        }

        private void ButtonOnClicked(object sender,EventArgs eventArgs)
        {
            Console.WriteLine("Button clicked(Window Handler)");
        }
    }
}
