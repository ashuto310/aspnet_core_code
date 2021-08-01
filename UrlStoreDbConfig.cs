using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortner.Core
{
    public class UrlStoreDbConfig
    {
        public string DATABASE_NAME { get; set; }
        public string URL_COLLECTION_NAME { get; set; }
        public string CONNECTION_STRING { get; set; }
    }
}
