using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortner.Core
{
    public class UrlDetails
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string urllong { get; set; }
        public string urlshort { get; set; }
        public int count { get; set; }
    }
}
