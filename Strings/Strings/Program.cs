using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Test";
            string lastName = "Testing";

            string name = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(name);

            var nums = new int[3] { 1, 2, 3 };

            string list = string.Join(",", nums);

            Console.WriteLine(list);

            string names = "Mosh";
            // strings are immutable in csharp
            Console.WriteLine("\t" + names + "\\");

            // verbatim strings
            /*            string path = "c:\\projects\\project1\\folder1";*/

            // the above using verbatim strings
            string path = @"c:\projects\project1\folder1";

        }
    }
}
