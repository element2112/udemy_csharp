using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // datetime objects are immutable

            var dateTime = new DateTime(2015,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1); // returns tomorrows date
            var yesterday = now.AddDays(-1); // yesterday's date


            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString()); // date and time

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); // look up datetime format specifiers for more format strings
        }
    }
}
