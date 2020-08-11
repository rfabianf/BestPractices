namespace EventBroker
{
    public class ActorEvent
    {
        public string Name { get; set; }
    }

    public class CoachSentOffEvent : ActorEvent
    {
        public string Reason { get; set; }
    }

    public class PlayerScoredEvent : ActorEvent
    {
        public int GoalsScored { get; set; }
    }
    public class PlayerSentOffEvent : ActorEvent
    {
        public string Reason { get; set; }
    }
}