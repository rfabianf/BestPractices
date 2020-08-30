using Autofac;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeEventSubscriptionsInterfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
            var ass = Assembly.GetExecutingAssembly();

            cb.RegisterAssemblyTypes(ass)
                .AsClosedTypesOf(typeof(ISend<>))
                .SingleInstance();

            cb.RegisterAssemblyTypes(ass)
                .Where(t => t.GetInterfaces()
                .Any(i =>
                i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IHandle<>)
                ))
                .OnActivated(act =>
                {
                    //IHandle<Foo>
                    var instanceType = act.Instance.GetType();
                    var interfaces = instanceType.GetInterfaces();

                    foreach (var item in interfaces)
                    {
                        if (item.IsGenericType && item.GetGenericTypeDefinition() == typeof(IHandle<>))
                        {
                            //IHandle<Foo>
                            var arg0 = item.GetGenericArguments()[0];
                            // ISend<Foo> construct!
                            var senderType = typeof(ISend<>).MakeGenericType(arg0);
                            // every single ISend<Foo> in container
                            // IEnumerable<IFoo> -> every instance of IFoo
                            var allSenderTypes = typeof(IEnumerable<>)
                            .MakeGenericType(senderType);
                            //IEnumerable<Isend<Foo>>
                            var allServices = act.Context.Resolve(allSenderTypes);

                            foreach (var service in (IEnumerable) allServices)
                            {
                                var eventInfo = service.GetType().GetEvent("Sender");
                                var handleMethod = instanceType.GetMethod("Handle");
                                var handler = Delegate.CreateDelegate(eventInfo.EventHandlerType,null,handleMethod);

                                eventInfo.AddEventHandler(service,handler);
                            }
                        }
                    }

                }).SingleInstance().AsSelf();

            var container = cb.Build();

            var button = container.Resolve<Button>();
            var logging = container.Resolve<Logging>();

            button.Fire(1);
            button.Fire(2);

        }
    }
}
