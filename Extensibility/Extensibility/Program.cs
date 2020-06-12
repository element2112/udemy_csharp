using System;
using System.Net.Http.Headers;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\bs009\Desktop\udemy_csharp\Extensibility\Extensibility\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
