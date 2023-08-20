using FastEndpoints;

namespace Traveler.Minimal.Api.Features.Entry.Delete
{
    public class EntryDeleteEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Delete("/api/journal/entry/delete");            
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new()
            {

            });
        }
    }
}
