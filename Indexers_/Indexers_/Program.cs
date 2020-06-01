using System;

namespace Indexers_
{
    class Program
    {
        static void Main(string[] args)
        {
            // array["name"] = "Britt";
            // var name = array["name"];
            // an indexer is a property
            var cookie = new HttpCookie();
            cookie["name"] = "Britt";
            Console.WriteLine(cookie["name"]);
        }
    }
}
