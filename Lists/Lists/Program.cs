using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            
            foreach(var x in numbers)
                Console.WriteLine(x); // 1 2 3 4 1 5 6 7

            Console.WriteLine();

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);


            // can't modify collections in foreach blocks
/*            foreach (var x in numbers)
            {
                if (x == 1)
                    numbers.Remove(x);
            }*/

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var x in numbers)
                Console.WriteLine(x);

            Console.WriteLine();

            numbers.Clear();
            Console.WriteLine("Count after clear: " + numbers.Count);

        }
    }
}
