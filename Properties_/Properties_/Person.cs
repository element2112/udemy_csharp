using System;

namespace Properties_
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; } // private set accessor, meaning its read only

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        // since we need some logic here, can't do 
        // syntactic sugar for get/set
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
