using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); // not good to create objects inside a class method of another class
            var rating = calculator.Calculate();

            Console.WriteLine("Promote logic change");
        }


    }
}
