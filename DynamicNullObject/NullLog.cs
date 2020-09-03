using ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicNullObject
{
    public class NullLog : ILog
    {
        public void Info(string msg)
        {
           
        }

        public void warn(string msg)
        {

        }
    }

    public class Null<TInterface>:DynamicObject where TInterface : class
    {
        public static TInterface Instance => new Null<TInterface>().ActLike<TInterface>();

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            result = Activator.CreateInstance(binder.ReturnType);
            return true;
        }
    }
}
