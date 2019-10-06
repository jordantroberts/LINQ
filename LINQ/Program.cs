using System;
using LINQ;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new Library().GetBooks();

            var cheapBooks = new List<Book>();
            {
                foreach (var book in books)
            {
                    if (book.Price < 10)
                        cheapBooks.Add(book);
            }

                foreach (var book in cheapBooks)
                    Console.WriteLine(book.Title + " £" + book.Price);

            }
        }
    }
}
