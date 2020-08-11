using System;
using System.Reactive.Linq;

namespace EventBroker
{

    public class FootballCoach : Actor
    {
        public string Name { get; set; }

        public void AssaultReferee()
        {
            broker.Publish(new CoachSentOffEvent { Name = Name, Reason = "Reclamo" });
        }
        public FootballCoach(EventBroker broker, string name) : base(broker)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }

            Name = name;
            broker.OfType<PlayerScoredEvent>()
                .Subscribe(pe =>
                {
                    if (pe.GoalsScored < 3)
                        Console.WriteLine($"Coach: well done, {pe.Name}!");
                });

            broker.OfType<PlayerSentOffEvent>()
                .Subscribe(pe =>
                {
                    if (pe.Reason == "Violencia")
                        Console.WriteLine($"Coach: How Could you,{pe.Name}");
                });
        }
    }
}