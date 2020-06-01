using System;
using System.Collections.Generic;

namespace Indexers_
{
    public class HttpCookie
    {
        // dictionary (hash table)
        private readonly Dictionary<string, string> _dict;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dict = new Dictionary<string, string>();
        }

        public string this[string key] // this is the indexer
        {
            get { return _dict[key]; }

            set { _dict[key] = value; }
        }
    }
}
