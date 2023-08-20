namespace Traveler.Minimal.Api.Data
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string JournalsCollectionName { get; set; } = null!;
    }
}
