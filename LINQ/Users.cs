using System;
using System.Collections.Generic;

namespace LINQ
{
    public class Users
    {
        public IEnumerable<User> GetUsers()
            {
            return new List<User> {
                new User() { Name = "Jordan", City = "London", Age = 26 },
                new User() { Name = "Amy", City = "Brighton", Age = 24 },
                new User() { Name = "Graham", City = "Manchester", Age = 56 },
                new User() { Name = "Ben", City = "London", Age = 30 },
                new User() { Name = "Hannah", City = "Tokyo", Age = 25 },
                new User() { Name = "Ralph", City = "Brighton", Age = 4},
                new User() { Name = "Christina", City = "Tokyo", Age = 30}

            };
        }
    }

    public class User
    {
        private string _name { get; set; }
        private string _city { get; set; }
        private int _age { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value;  }
        }
    }

   
}
