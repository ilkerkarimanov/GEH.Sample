using MongoDB.Driver;

namespace GEH.Infrastructure.Mongo
{
    public class MongoContext<TConn> : IMongoContext
        where TConn : IMongoConnection
    {
        private IMongoClient _client { get; set; }
        private IMongoDatabase _database { get; set; }
        IMongoDatabase IMongoContext.Database
        {
            get
            {
                return _database;
            }
        }

        public MongoContext(TConn conn)
        {
            this.Create(conn);
        }

        private void Create(IMongoConnection mongoConn)
        {
            var url = new MongoUrl(mongoConn.LoggingStore());
            this._client = new MongoClient(url.Url);
            this._database = this._client.GetDatabase(url.DatabaseName);
        }
    }
}
