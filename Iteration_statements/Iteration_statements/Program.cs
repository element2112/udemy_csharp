using System;

namespace Iteration_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            // next: returns a random integer
            // nextbytes: fills an array of bytes with random numbers
            // next double returns a random num between 0.0 and 1.0
            for (var i = 0; i < 10; i++)
                Console.WriteLine(rand.Next(1,10));            
            
            Console.WriteLine((int) 'a');

            // doing it the way below, cannot put result of loop into a string value bc strings are immutable
            for (var i = 0; i < 10; i++)
                Console.Write((char) ('a' + rand.Next(0, 26))); // random string (also could do rand.Next(97,122)
            Console.WriteLine();

            // here using a char array buffer we can overload string constructor
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < 10; i++)
                buffer[i] = (char)('a' + rand.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);

        }
    }
}
