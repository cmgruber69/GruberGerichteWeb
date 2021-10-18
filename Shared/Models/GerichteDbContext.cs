using MongoDB.Driver;

namespace GruberGerichteWeb.Shared.Models
{
    public class GerichteDbContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public GerichteDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("GerichteDB");
        }
        public IMongoCollection<Gerichte> GerichteRecords
        {
            get
            {
                return _mongoDatabase.GetCollection<Gerichte>("Gerichte");
            }
        }
        
    }
}
