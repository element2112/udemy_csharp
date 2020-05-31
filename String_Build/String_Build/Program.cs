using System;
using System.Text;

namespace String_Build
{
    class Program
    {
        static void Main(string[] args)
        {
            // string builder is a mutable string

            var builder = new StringBuilder();
            var builder2 = new StringBuilder("Hello");

            // can chain methods bc the methods return a stringbuilder
            builder.Append('-', 10)
                    .AppendLine()
                    .Append("Header")
                    .AppendLine()
                    .Append('-', 10)
                    .Replace('-', '+')
                    .Remove(0, 10)
                    .Insert(0, new string('-', 10));



            Console.WriteLine(builder);
            Console.WriteLine(builder2);

            Console.WriteLine("Display char: " + builder2[0]);
        }
    }
}
