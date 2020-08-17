using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ObservableCollections
{
    public class Market //: INotifyPropertyChanged //Observable
    {
        public BindingList<float> prices = new BindingList<float>();
        public void AddPrice(float price)
        {
            prices.Add(price);
            //PriceAdded?.Invoke(this, price);
        }

        //private float volatility;

        //public float Volatility
        //{
        //    get => volatility;
        //    set
        //    {
        //        if (value.Equals(volatility)) return;
        //        volatility = value;
        //        OnPropertyChanged ();
        //    }
        //}



        //public event EventHandler<float> PriceAdded;

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
