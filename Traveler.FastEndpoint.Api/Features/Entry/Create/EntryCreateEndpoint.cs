using FastEndpoints;

namespace Traveler.Minimal.Api.Features.Entry.Create
{
    public class EntryCreateEndpoint : Endpoint<EntryCreateRequest, EntryCreateResponse>
    {
        public override void Configure()
        {
            Post("/api/journal/entry/create");            
        }

        public override async Task HandleAsync(EntryCreateRequest req, CancellationToken ct)
        {
            await SendAsync(new()
            {

            });
        }
    }
}
