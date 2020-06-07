using System;

namespace Constructors_Inheritance
{
    public class Vehicle
    {
        private readonly string reg_Num;

/*        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");
        }*/

        public Vehicle(string reg_num)
        {
            reg_Num = reg_num;
            Console.WriteLine("Vehicle is being intialized: " + reg_num);
        }
    }
}
