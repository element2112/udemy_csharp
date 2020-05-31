using System;

namespace Constructors_
{

    class Program
    {
        static void Main(string[] args)
        {
            var cust = new Customer(1, "john");
            Console.WriteLine(cust.Id);
            Console.WriteLine(cust.Name);
            Console.WriteLine();

            var order = new Order();


        }
    }
}
