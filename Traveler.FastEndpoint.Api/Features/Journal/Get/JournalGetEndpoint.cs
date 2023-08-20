using FastEndpoints;

namespace Traveler.Minimal.Api.Features.Journal.Get
{
    public class JournalGetEndpoint : Endpoint<JournalGetRequest, JournalGetResponse>
    {
        public override void Configure()
        {
            Get("/api/journal/get");            
        }

        public override async Task HandleAsync(JournalGetRequest req, CancellationToken ct)
        {
            await SendAsync(new()
            {

            });
        }
    }
}
