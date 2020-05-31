using System;

namespace Object_Initializer_
{
    public class Person
    {
        public string FirstName;
        public string lastName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { FirstName = "Britt", lastName = "S" }; // similar to cpp
        }
    }
}
