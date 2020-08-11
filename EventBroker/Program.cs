using Autofac;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace EventBroker
{

    static class Program
    {
        private static void Main()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<EventBroker>().SingleInstance();
            cb.RegisterType<FootballCoach>();

            cb.Register((c, pe) => new FootballCoach(
            c.Resolve<EventBroker>(), pe.Named<string>("name")
            ));

            cb.Register((c, pe) => new FootballPlayer(
                c.Resolve<EventBroker>(), pe.Named<string>("name")
                ));

            using (var c = cb.Build())
            {
                var coach = c.Resolve<FootballCoach>(new NamedParameter("name", "Pep"));
                var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Roberto"));
                var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Carlos"));

                player1.Score();
                player1.Score();
                player1.Score();

                player1.AssaultReferee();

                coach.AssaultReferee();

              
                player2.Score();

            }
        }
    }
}
