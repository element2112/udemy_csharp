using System;
using System.Net.Http.Headers;

namespace Methods_2
{
    partial class Program
    {
        public class Calculator
        {
            public int Add(params int[] numbers)
            {
                var sum = 0;

                foreach (var num in numbers)
                    sum += num;

                return sum;
            }
        }
        static void Main(string[] args)
        {
            // public int Add(params int[] numbers) {}
            // var res = calc.Add(1,2,3,4)
            // allows you to pass multiple parameters to a method as an array
            //  to avoid unnecessary overloading

            // publi void Doweird(ref int a)
            //  passing a by reference. i guess this is a code smell in c#

            // public void mymethod(out int result)
            // myclass.mymethod(out a) // out allows you to return multiple results to caller? also a code smell for c#?

            /* var number = int.Parse("abc");*/

            int number;

            var result = int.TryParse("123", out number); // trys to parse "abc" if and returns bool, if successful, also returns the proper int val in number
            
            if (result)
            {
                Console.WriteLine("number: " + number);
            }
            else
                Console.WriteLine("conversion failed");

        }

        static void Useparams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine(calc.Add(1, 2, 3));
            Console.WriteLine(calc.Add(1, 2, 3, 4));
            Console.WriteLine(calc.Add(1, 2, 3, 4, 5));

            Console.WriteLine(calc.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));

                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(null);

                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred");
            }
        }
    }
}
