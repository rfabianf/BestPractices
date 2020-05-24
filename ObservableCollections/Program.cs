using System;
using System.ComponentModel;

namespace ObservableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();
            //market.PriceAdded += (sender, f) =>
            //{
            //    Console.WriteLine($"We got a price of {f}");
            //};
            //market.prices.ListChanged += (sender, eventArgs) =>
            //{
            //    if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
            //    {
            //        float price = ((BindingList<float>)sender)[eventArgs.NewIndex];
            //        Console.WriteLine($"We got a price of {price}");
            //    }
            //};

            market.prices.ListChanged += ListChangedTypes;

            market.AddPrice(200);
            market.AddPrice(100);

            market.AddPrice(400);
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
