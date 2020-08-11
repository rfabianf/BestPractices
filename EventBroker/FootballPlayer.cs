using System;
using System.Reactive.Linq;

namespace EventBroker
{
    public class FootballPlayer : Actor
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; } = 0;
        public void Score()
        {
            GoalsScored++;
            broker.Publish(new PlayerScoredEvent { Name = Name, GoalsScored = GoalsScored });
        }

        public void AssaultReferee()
        {

            broker.Publish(new PlayerSentOffEvent { Name = Name, Reason = "Violencia" });
        }

        public FootballPlayer(EventBroker broker, string name) : base(broker)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }

            Name = name;

            broker.OfType<PlayerScoredEvent>()
                .Where(ps => !ps.Name.Equals(name))
                .Subscribe(
                ps => Console.WriteLine($"{name}: Nicely done, {ps.Name}! It's your {ps.GoalsScored} goal")
                );

            broker.OfType<PlayerSentOffEvent>()
           .Where(ps => !ps.Name.Equals(name))
           .Subscribe(ps => Console.WriteLine($"{name}: See you in the lockers, {ps.Name} ")
                );

            broker.OfType<CoachSentOffEvent>()
           .Where(ps => !ps.Name.Equals(name))
           .Subscribe(ps => Console.WriteLine($"{name}: See you Mr. {ps.Name} "));
        }
    }
}