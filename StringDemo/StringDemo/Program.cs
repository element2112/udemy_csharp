using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";

            // using string class
            // must import
            // essentially the same
            String lastName = "Smith";
            string myName = "Mosh";

            // essentially the same
            Int32 i;
            int j;

            var fN = "Mosh";
            var lN = "Smith";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
