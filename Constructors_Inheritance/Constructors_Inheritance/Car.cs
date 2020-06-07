using System;

namespace Constructors_Inheritance
{
    public class Car : Vehicle
    {
        public Car(string reg_number) : base(reg_number)
        {
            Console.WriteLine("Car is being initialized: " + reg_number);
        }


    }
}
