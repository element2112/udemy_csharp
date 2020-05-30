using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int[4];

            // all elements non intialized are
            //   auto initialized to 0
            numbers[0] = 1;

            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }

            var flags = new bool[3];

            flags[0] = true;

            // bools auto intialize to false
            foreach(bool c in flags)
                Console.WriteLine(c);

            var names = new string[3] { "Jack", "John", "Mary" };

            foreach(string s in names)
                Console.WriteLine(s);
        }
    }
}
