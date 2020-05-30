using System;

namespace Reference_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // structures: value types : allocated on stack, mem allocation done automatically, immediately removed when out of scope
            // classes: reference types : manually allocate memory on heap, garbage collected by CLR

            // ref types vs val types

            var a = 10;
            var b = a;
            b++;
            // copying a value type doesn't chnage the original (value is copied)
            Console.WriteLine(String.Format("a: {0}, b: {1}", a, b));

            // an array is a class so its a ref type
            var array1 = new int[3] { 1, 2, 3 };

            var array2 = array1; // copying the memory address

            array2[0] = 0;

            foreach (int x in array1)
                Console.WriteLine(x);

        }
    }
}
