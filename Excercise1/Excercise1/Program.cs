using System;
using System.Dynamic;

namespace Excercise1
{
    class Program
    {
        public static void Validation()
        {
            Console.WriteLine("Enter a number between 1 and 10. (-1 to quit)");

            var input = 0;

            while (input != -1)
            {
                input = Int32.Parse(Console.ReadLine());

                if (input > 1 && input < 10)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("invalid");
            }
        }

        public static int FindMax()
        {
            Console.WriteLine("Enter two numbers");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            return (a >= b) ? a : b; 
        }

        public static string Landscape()
        {
            Console.WriteLine("Enter width and then height");
            int width = Int32.Parse(Console.ReadLine());
            int height = Int32.Parse(Console.ReadLine());
            return (width > height) ? "landscape" : "portrait";
        }

        public static void Speed()
        {
            Console.WriteLine("Enter a speed limit");
            int limit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of a car");
            int cspeed = Int32.Parse(Console.ReadLine());
            int diff = cspeed - limit;
            int demerit = 0;

            for (int i = diff; i > 0; i -= 5)
            {
                demerit++;
            }

            if (demerit > 12)
            {
                Console.WriteLine("License Suspended");
                return;
            }


            Console.WriteLine("Demerits: {0}", demerit);
        }

        static void Main(string[] args)
        {

            Validation();
            Console.WriteLine("Max: {0}\n", FindMax());
            Console.WriteLine(Landscape());
            Speed();
            
        }
    }
}
