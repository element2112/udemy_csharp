using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 15},
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // args => expression
            // number => number * number

            // <args, retval>
            Func<int, int> square = num => num * num;
            Console.WriteLine(square(5));

            // no args () => ...
            // x => ...
            // (x, y, z) => ...

            const int factor = 5;

            Func<int, int> mult = n => n * factor;

            Console.WriteLine(mult(10));

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach(var book in cheapBooks)
                Console.WriteLine(book.Title);
        }
    }
}
