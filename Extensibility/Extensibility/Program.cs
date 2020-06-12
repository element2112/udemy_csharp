using System;
using System.Net.Http.Headers;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\torchgirl\Desktop\udemy_csharp\udemy_csharp\Extensibility\Extensibility"));
            dbMigrator.Migrate();
        }
    }
}
