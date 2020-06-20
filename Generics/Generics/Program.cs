using System.Collections.Generic;

namespace Generics
{
    public class Book : Product
    {
        public string Isbn { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());


            // nullable is already apart of .net framework
            var number = new Nullable<int>(5);
            System.Console.WriteLine("Has Value? " + number.HasValue);
            System.Console.WriteLine("Value: " + number.GetValueOrDefault());
            

            var number2 = new Nullable<int>();
            System.Console.WriteLine("Has Value? " + number2.HasValue);
            System.Console.WriteLine("Value: " + number2.GetValueOrDefault());

        }
    }
}
