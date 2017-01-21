using MongoDB.Driver;

namespace GEH.Infrastructure.Mongo
{
    public interface IMongoContext {

        IMongoDatabase Database { get; }

    }
    
}
