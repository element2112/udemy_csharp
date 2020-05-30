using System;

namespace Val_vs_Rref
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number); // passed by value automatically so number in this scope does not change
            Console.WriteLine(number);

            var person = new Person() { Age = 10 };
            MakeOld(person); // passed by reference automatically so person in this scope does change
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
