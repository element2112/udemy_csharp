using System;

namespace ArrayStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2d rectangular array
/*            var matrix = new int[3, 5];*/
            var matrix = new int[3, 5]
            {
                { 1,2,3, 4, 5},
                {6,7,8, 9, 10},
                {9,10,11,12,13}
            };

            int x = matrix[2, 3]; // row 2 col 3

            // jagged array
            var array = new int[3][];

            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            // jagged: var array = new int[1][2]
            // rectangular: var array = new int[1,2]

            var nums = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + nums.Length);

            // IndexOf()
            var index = Array.IndexOf(nums, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(nums, 0, 2); // start and end index
            // for bool array sets items to false
            // for string arrays and others sets items to null

            Console.WriteLine("Effect of Clear()");
            foreach(var n in nums)
                Console.WriteLine(n);

            var anotherArr = new int[3];

            // Copy()
            Array.Copy(nums, anotherArr, 3); // copies the first 3 numbers into anotherArr
            Console.WriteLine("Effect of Copy()");
            foreach (var n in anotherArr)
                Console.WriteLine(n);

            // Sort()
            Console.WriteLine("Effect of Sort()");
            Array.Sort(nums);
            foreach(var n in nums)
                Console.WriteLine(n);

            // Reverse()
            Console.WriteLine("Effect of Reverse()");
            Array.Reverse(nums);
            foreach (var n in nums)
                Console.WriteLine(n);


        }
    }
}
