global using FastEndpoints;
global using FastEndpoints.Security;
//global using FastEndpoints.Validation;

using FastEndpoints.Swagger;
using Traveler.Minimal.Api.Data;
using Traveler.Minimal.Api.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.AddJWTBearerAuth("TokenSigningKey");
builder.Services.AddAuthentication();
builder.Services.SwaggerDocument(o =>
{
    o.DocumentSettings = s =>
    {
        s.DocumentName = "Initial Release";
        s.Title = "Traveler API";
        s.Version = "v0";
    };
});
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("JournalsDatabase"));
builder.Services.AddSingleton<JournalsService>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.UseFastEndpoints(f => f.Versioning.Prefix = "v");
app.UseSwaggerGen();
app.Run();
