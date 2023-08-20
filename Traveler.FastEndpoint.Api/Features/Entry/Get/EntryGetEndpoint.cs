using FastEndpoints;

namespace Traveler.Minimal.Api.Features.Entry.Get
{
    public class EntryCreateEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Post("/api/jounral/create");            
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new()
            {

            });
        }
    }
}
