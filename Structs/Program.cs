using System;

namespace Structs
{
    public struct RgbColor
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var val = new RgbColor();

            val.Red = 1;
            val.Green = 0;
            val.Blue = 1;

            Console.WriteLine("Red: {0} Blue: {1} Green: {2}", 
                val.Red, val.Blue, val.Green);
        }
    }
}
