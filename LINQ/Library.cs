using System;
using System.Collections.Generic;
using LINQ;

namespace LINQ
{
    public class Library
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Harry Potter", Price = 5 },
                new Book() {Title = "Lord of the Rings", Price = 10},
                new Book() {Title = "Clean Code", Price = 25},
                new Book() {Title = "Jane Eyre", Price = 2},
                new Book() {Title = "To Kill a Mockingbird", Price = 4}
            };
        }
    }
}
