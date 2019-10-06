using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new Library().GetBooks();

            var cheapBooks = books
                .Where(book => book.Price < 10)
                .OrderBy(book => book.Title);

            Console.WriteLine("Books that are less than £10");
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " £" + book.Price);


            var users = new Users().GetUsers();
            var usersGroupedByCity = users.GroupBy(user => user.City);

            foreach (var group in usersGroupedByCity)
            {
                Console.WriteLine("Users from " + group.Key + ":");

                foreach (var user in group)
                {
                    Console.WriteLine("* " + user.Name);
                }

            }
            
        }
    }
}
