using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_EventSourcing
{
    public class Person
    {
        private int age;
        EventBroker broker;

        public Person(EventBroker broker)
        {
            this.broker = broker;
            broker.Commands += BrokerOnCommands;
            broker.Queries += BrokerOnQuerys;
        }

        private void BrokerOnQuerys(object sender, Query query)
        {
            var ca = query as AgeQuery;
            if(ca != null && ca.target != null)
            {
                ca.Result = age;
            }
        }

        private void BrokerOnCommands(object sender, Command command)
        {
            var cac = command as ChangeAgeCommand;
            if(cac != null && cac.Target == this)
            {
                if(cac.Register)broker.AllEvents.Add(new AgeChangedEvent(this, age, cac.Age));
                age = cac.Age;
            }
        }
    }
}
