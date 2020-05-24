using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_EventSourcing
{
    public class AgeQuery : Query
    {
        public Person target;
    }
}
