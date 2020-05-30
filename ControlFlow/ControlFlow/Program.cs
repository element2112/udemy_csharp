using System;

namespace ControlFlow
{

    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer");
                    break;
                default:
                    Console.WriteLine("I don't know that season");
                    break;
            }

            // wanting to duplicate code in case statements
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion!");
                    break;
                default:
                    Console.WriteLine("I don't know that season");
                    break;
            }
        }
    }
}
