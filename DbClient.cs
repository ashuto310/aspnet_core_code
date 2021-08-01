using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortner.Core
{
    public class DbClient 
    {
        public readonly IMongoDatabase _database = null;
        public DbClient(IOptions<UrlStoreDbConfig> urlstoredbconfig)
        {
            var client = new MongoClient(urlstoredbconfig.Value.CONNECTION_STRING);
            _database = client.GetDatabase(urlstoredbconfig.Value.DATABASE_NAME);
        }
        public IMongoCollection<UrlDetails> urls
        {
            get
            {
                return _database.GetCollection<UrlDetails>("URLS");
            }
        }
    }
}
