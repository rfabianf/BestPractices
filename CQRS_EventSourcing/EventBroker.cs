﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_EventSourcing
{
    public class EventBroker
    {
        //1. Todos los eventos que han ocurrido
        public IList<Event> AllEvents = new List<Event>();
        //2. Command
        public event EventHandler<Command> Commands;
        //3. Query
        public event EventHandler<Query> Queries;

        public  void Command(Command c)
        {
            Commands?.Invoke(this,c);
        }

        public T Query<T>(Query q)
        {
            Queries?.Invoke(this, q);
            return (T)q.Result;

        }

        public void UndoLast()
        {
            var e = AllEvents.LastOrDefault();
            var ac = e as AgeChangedEvent;
            if(ac != null)
            {
                Command(new ChangeAgeCommand(ac.Target, ac.OldValue) { Register = false});
                AllEvents.Remove(e);
            }
        }
    }
}