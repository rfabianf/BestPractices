using System;

namespace CQRS_EventSourcing
{
    public class Command : EventArgs
    {
        public bool Register = true;
    }
}