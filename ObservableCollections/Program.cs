using System;
using System.ComponentModel;

namespace ObservableCollections
{
    internal class Program //Observador
    {
        static void Main(string[] args)
        {
            var market = new Market();

            market.PropertyChanged += (sender, EventArgs) =>
            {
                if (EventArgs.PropertyName.Equals("Volatility"))
                {
                    Console.Write("prueba");
                }
            };

            market.Volatility = 250;

            market.prices.ListChanged += (sender, eventArgs) =>
            {
                if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
                {
                    float price = ((BindingList<float>)sender)[eventArgs.NewIndex];
                    Console.WriteLine($"We got a price of {price}");
                }
            };

            market.AddPrice(200);


            //event Conventional
            market.PriceAdded += (sender, f) =>
            {
                Console.WriteLine($"We got a price of {f}");
            };
            market.AddPrice(100);

            market.prices.ListChanged += ListChangedTypes;
        }

        private static void ListChangedTypes(object sender, ListChangedEventArgs eventArgs)
        {
            if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
            {
                float price = ((BindingList<float>)sender)[eventArgs.NewIndex];
                Console.WriteLine($"We got a price of {price}");
            }
        }

    }
}
