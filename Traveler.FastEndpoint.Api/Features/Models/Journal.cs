using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Traveler.Minimal.Api.Features.Models
{
    public class Journal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string JournalName { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Subject { get; set; } = null!;

        public string Author { get; set; } = null!;
        public DateTime CreatedDateTime { get; set; }

    }
}
