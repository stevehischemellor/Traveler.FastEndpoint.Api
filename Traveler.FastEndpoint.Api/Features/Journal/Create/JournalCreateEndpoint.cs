using FastEndpoints;

namespace Traveler.Minimal.Api.Features.Journal.Create
{
    public class JournalCreateEndpoint : Endpoint<JournalCreateRequest, JournalCreateResponse>
    {
        public override void Configure()
        {
            Post("/api/journal");
            AllowAnonymous();
        }

        public override async Task HandleAsync(JournalCreateRequest req, CancellationToken ct)
        {
            Logger.LogInformation("Create journal request received");

            ct.ThrowIfCancellationRequested();

            await SendAsync(new()
            {
                Result = "success"
            });
        }
    }
}
