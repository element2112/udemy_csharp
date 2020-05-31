using System;

namespace Strings_More
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1234;

            string s = i.ToString(); // "1234"

            string t = i.ToString("C"); // "C" is a format string (currency) so prints "$1,234.00"

            string u = i.ToString("C0"); // "C0" is a format string prints "$1,234"

            var fullName = "Brittanie S  ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // trims white space at end

            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1); // from the space until the end of the string

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var rep1 = fullName.Replace("Brittanie", "torchgirl");
            var rep2 = fullName.Replace('a', 'A');
            var rep3 = fullName.Replace(' ', '$');

            Console.WriteLine("rep1: {0} rep2: {1} rep3: {2}", rep1, rep2, rep3);

            // validation
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age: " + age);

            float price = 29.95f;

            Console.WriteLine("price: " + price.ToString("C"));
        }
    }
}
