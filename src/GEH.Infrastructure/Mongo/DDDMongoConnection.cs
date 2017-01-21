using Microsoft.Extensions.Configuration;
using System;

namespace GEH.Infrastructure.Mongo
{
    public class MongoMongoConnection : IMongoConnection
    {
        private IConfiguration _configuration;

        public MongoMongoConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string LoggingStore() => loggingStore();

        private string loggingStore(string name = "LoggingStore")
        {
            if (_configuration == null) throw new ArgumentNullException(nameof(_configuration));

            return _configuration[$"connectionStrings:{name}"];
        }

    }
}
