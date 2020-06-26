using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime date = null; does not work bc DateTime is a value type
            // Nullable<DateTime> date = null; one way

            // more common way for nullable type
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault()); // gets the value and if it's null returns default DateTime
            Console.WriteLine("HasValue: " + date.HasValue); // returned false because it's null and has no value
            // Console.WriteLine("Value: " + date.Value); // value is null so causes an exception

            DateTime? date2 = new DateTime(2014, 1, 1);
            // DateTime date3 = dat2; will not work because date2 is nullable and date 3 is not
            DateTime date3 = date2.GetValueOrDefault();
            Console.WriteLine("Date2: {0} | Date3: {1}", date2, date3);

            // value type can be easily converted to a nullable
            DateTime? date4 = date3;
            Console.WriteLine("Date4: " + date4.GetValueOrDefault());


            // Null Coalescing Operator
            DateTime? theDate = null;
            
            // this is the same as the commented code below (kind of like ternary operator)
            DateTime theDate2 = theDate ?? DateTime.Today;

            /*if (theDate != null)
                theDate2 = date.GetValueOrDefault();
            else
                theDate2 = DateTime.Today;*/

            Console.WriteLine("TheDate: " + theDate2);
                
        }
    }
}
