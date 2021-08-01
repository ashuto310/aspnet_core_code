using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortner.Core
{
    public interface IDbClient
    {
        IMongoCollection<UrlDetails> urls();
    }
}
