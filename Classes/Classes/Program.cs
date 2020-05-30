
using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            Calculator calc = new Calculator();

            var res = calc.Add(1, 2);
            Console.WriteLine("result: " + res);

        }
    }
}
