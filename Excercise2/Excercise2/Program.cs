using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Excercise2
{
    class Program
    {
        public static void Count()
        {
            int div = 3;
            int res = 0;

            for (var i = 1; i < 100; i++)
            {
                if (i % div == 0)
                    res++;
            }

            Console.WriteLine("Result: {0}", res);
        }

        public static void Sum()
        {
            Console.WriteLine("Continue to enter numbers. Type 'ok' to stop");
            var check = true;
            var sum = 0;

            while(check)
            {
                var input = Console.ReadLine();

                if (string.Compare(input, "ok") == 0)
                    break;

                sum += Int32.Parse(input);
            }

            Console.WriteLine("Sum: {0}", sum);
        }

        public static int Fact(int num)
        {
            if (num <= 1)
                return 1;

            return num * Fact(num - 1);
        }

        public static void getRand()
        {
            var rand = new Random();
            int guesses = 4;
            var ans = 0;
            var correct = rand.Next(1, 10); ;

            for (var i = 0; i < guesses; i++)
            {
                Console.WriteLine("Guess the number: ");

                ans = Int32.Parse(Console.ReadLine());

                if (ans == correct)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("Answer: {0}", correct);
                    return;
                }

                Console.WriteLine("Wrong");

            }

            Console.WriteLine("Answer: {0}", correct);
            Console.WriteLine("You Lose");

        }

        public static void findMax()
        {
            Console.WriteLine("Enter comma seperated integers");
            var ans = Console.ReadLine();
/*            int n = ans.Length;*/
            var max = 0;

            var numbers = ans.Split(',');

            var n = numbers.Length;

            for (int i = 0; i < n; i++)
            {
                max = Math.Max(max, Convert.ToInt32(numbers[i]));
            }

            Console.WriteLine("Max: {0}", max);

        }

        static void Main(string[] args)
        {
            Count();
            Console.WriteLine();

            Sum();
            Console.WriteLine();

            Console.WriteLine("Enter a number");
            Console.WriteLine("Factorial: {0}", Fact(Int32.Parse(Console.ReadLine())));
            Console.WriteLine();

            getRand();
            Console.WriteLine();

            findMax();
            Console.WriteLine();

        }
    }
}
