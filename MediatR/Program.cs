using Autofac;
using JetBrains.Annotations;
using System;
using System.Threading.Tasks;

namespace MediatR
{
    public class Program
    {
         static async Task Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                .AsImplementedInterfaces();

            var container = builder.Build();
            var mediator = container.Resolve<IMediator>();
            var response = await mediator.Send(new PingCommand());
            Console.WriteLine($"We got a response at {response}");
        }
    }
}
