using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace BidirectionalObserver
{
    public sealed class BidirectionalBinding : IDisposable
    {
        private bool disposed;

        public BidirectionalBinding(
            INotifyPropertyChanged first,
            Expression<Func<object>> firstProperty,
            INotifyPropertyChanged second,
            Expression<Func<object>> secondProperty
            )
        {
            // xxxProperty is MemberExpression
            //Member ||| PropertyInfo
            if(firstProperty.Body is MemberExpression firstExpr &&
                secondProperty.Body is MemberExpression secondExpr)
            {
                if(firstExpr.Member is PropertyInfo firstProp &&
                    secondExpr.Member is PropertyInfo secondProp)
                {
                    first.PropertyChanged += (sender, args) =>
                     {
                         if (!disposed)
                             secondProp.SetValue(second, firstProp.GetValue(first));
                     };

                    second.PropertyChanged += (sender, args) =>
                    {
                        if (!disposed)
                            firstProp.SetValue(first, secondProp.GetValue(second));
                    };
                }
            }

        }
        public void Dispose()
        {
            disposed = true;
        }
    }
}
