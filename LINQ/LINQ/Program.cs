using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ query operators
            // always start with from and end with select
            var cheapBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            foreach (var book in cheapBooks)
                Console.WriteLine(book);

            var singleBook = books.SingleOrDefault(b => b.Title == "Book 2"); // if there is no book2 it will return the default which is null
            Console.WriteLine("Single book: " + singleBook.Title);

            var firstBook = books.FirstOrDefault(b => b.Title == "Book 3");
            Console.WriteLine("First book that has title Book 3: " + firstBook.Price); // default is null

            var lastBook = books.LastOrDefault(b => b.Title == "Book 3");
            Console.WriteLine("Last book that has title Book 3: " + lastBook.Price);

            var pages = books.Skip(2).Take(3); // skips the first 2 books and takes the next 3

            foreach(var pagedBook in pages)
                Console.WriteLine(pagedBook.Title);

            var count = books.Count();
            Console.WriteLine("Count: " + count);

            var maxPrice = books.Max(b => b.Price); // returns the book with the max price
            Console.WriteLine("Max: " + maxPrice);

            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine("Total: " + sumPrice);


                // LINQ Extension methods
                /*            var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);

                            foreach(var book in cheapBooks)
                                Console.WriteLine(book);*/

                // after using select for the title, book is now a string because it returns an
                // IEnumerable of just the title of the books. This can no longer be used
                /*            foreach(var book in cheapBooks)
                                Console.WriteLine(book.Title + " " + book.Price);*/

                // without LINQ
                /*            var cheapBooks = new List<Book>();
                            foreach(var book in books)
                            {
                                if (book.Price < 10)
                                {
                                    cheapBooks.Add(book);
                                    Console.WriteLine(book.Title + " " + book.Price);
                                }
                            }*/
        }
    }
}
