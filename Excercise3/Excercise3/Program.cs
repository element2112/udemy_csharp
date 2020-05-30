using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Excercise3
{
    class Program
    {
        public static void Social()
        {
            string input;
            var list = new List<string>();

            do
            {
                Console.WriteLine("Enter a name: ");
                input = Console.ReadLine();

                if (input.Length == 0)
                    break;

                list.Add(input);
            }
            while (input.Length != 0);

            if (list.Count == 0)
                return;

            int n = list.Count;

            switch(n)
            {
                case 1:
                    Console.WriteLine("{0} likes your post", list[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post", list[0], list[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1}, and {2} others like your post", list[0], list[1], n-2);
                    break;
            }
        }

        public static void ReverseName()
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            var s = name.ToCharArray();
            Array.Reverse(s);

            Console.WriteLine("Reversed: ");
            foreach(var c in s)
                Console.Write(c);

            Console.WriteLine();

        }

        public static void Unique()
        {
            var numlist = new List<int>();
            var i = 5;

            do
            {
                Console.WriteLine("Enter a unique number: ");
                var temp = Convert.ToInt32(Console.ReadLine());
                if (numlist.Contains(temp))
                {
                    Console.WriteLine("Number already exists try again");
                    continue;
                }

                numlist.Add(temp);
                i--;
            }
            while (i != 0);

            numlist.Sort();

            Console.WriteLine();
            Console.WriteLine("List: ");
            foreach (var num in numlist)
                Console.WriteLine(num);
        }

        public static void EnterNum()
        {


            string input = null;

            var list = new List<int>();

            string temp = null;


            do
            {
                Console.WriteLine("Enter a number (type 'quit' to quit)");
                temp = Console.ReadLine();

                if (String.Compare(temp, "quit") == 0)
                    break;

                var temp2 = Convert.ToInt32(temp);

                if (list.Contains(temp2))
                {
                    continue;
                }

                list.Add(temp2);
            }
            while (String.Compare(temp, "quit") != 0);

            Console.WriteLine("\nList: ");

            for (var i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }

        public static void Commas()
        {
            var check = true;
            var list = new List<string>();

            string str = null;

            while (check)
            {
                Console.WriteLine("Provide list of comma seperated integers:");
                str = Console.ReadLine();

                var temp3 = str.Split(',');

                if (temp3.Length < 5)
                {
                    Console.WriteLine("invalid list. retry");
                    continue;
                }
                else
                {
                    break;
                }
            }

            var temp = str.Split(',');

            var numbers = new int[temp.Length];

            for (var i = 0; i < temp.Length; i++)
            {
                numbers[i] = Convert.ToInt32(temp[i]);
            }

            Array.Sort(numbers);

            Console.WriteLine("Smallest 3: ");

            for(var i = 0; i < 3; i++)
            {
                Console.Write(" {0} ", numbers[i]);
            }
        }

        static void Main(string[] args)
        {
            Social();
            ReverseName();
            Unique();
            EnterNum();
            Commas();

        }
    }
}
