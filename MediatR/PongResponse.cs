using System;

namespace MediatR
{
    public class PongResponse
    {
        public DateTime Timestamp;
        public PongResponse(DateTime timestamp)
        {
            Timestamp = timestamp;
        }
    }
}