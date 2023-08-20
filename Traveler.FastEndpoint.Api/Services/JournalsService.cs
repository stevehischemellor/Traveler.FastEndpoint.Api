using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Traveler.Minimal.Api.Data;
using Traveler.Minimal.Api.Features.Models;

namespace Traveler.Minimal.Api.Services
{
    public class JournalsService
    {
        private readonly IMongoCollection<Journal> _journalsCollection;

        public JournalsService(
            IOptions<DatabaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(
                databaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                databaseSettings.Value.DatabaseName);

            _journalsCollection = mongoDatabase.GetCollection<Journal>(
                databaseSettings.Value.JournalsCollectionName);
        }

        public async Task<List<Journal>> GetAsync() =>
            await _journalsCollection.Find(_ => true).ToListAsync();

        public async Task<Journal?> GetAsync(string id) =>
            await _journalsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Journal newJournal) =>
            await _journalsCollection.InsertOneAsync(newJournal);

        public async Task UpdateAsync(string id, Journal updatedBook) =>
            await _journalsCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _journalsCollection.DeleteOneAsync(x => x.Id == id);
    }
}
