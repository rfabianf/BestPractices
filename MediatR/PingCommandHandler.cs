using JetBrains.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR
{
    [UsedImplicitly]
    public class PingCommandHandler : IRequestHandler<PingCommand, PongResponse>
    {
        public async Task<PongResponse> Handle(PingCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new PongResponse(DateTime.UtcNow))
                .ConfigureAwait(continueOnCapturedContext: false);
        }
    }
}
