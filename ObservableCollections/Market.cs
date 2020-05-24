using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ObservableCollections
{
    public class Market
    {
        public BindingList<float> prices = new BindingList<float>();

        public void AddPrice(float price)
        {
            prices.Add(price);
            //PriceAdded?.Invoke(this, price);
        }

        public event EventHandler<float> PriceAdded;
    }
}
