using System;

namespace Classes_Intro
{
    public class Person
    {
        public string Name;

        public void Introducce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            var p = Person.Parse("John");

            p.Introducce("Sally");

            person.Name = "John";

            person.Introducce("Britt");
        }
    }
}
