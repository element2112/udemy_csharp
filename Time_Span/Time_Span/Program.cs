using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3); //1 hour 2 mins 3 secs

            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; // returns a time span
            Console.WriteLine("Duration: " + duration); // returns 2 mins in timespan format

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // adds hours/mins/secs into one value representing minutes

            // Add 
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // added 8mins to original timespan
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // subtracts 2mins to original timespan

            // ToString
            Console.WriteLine("ToString" + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // parses string into a timespan
        }
    }
}
