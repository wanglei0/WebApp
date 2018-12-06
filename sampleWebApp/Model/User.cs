using System;
using System.Collections.Generic;
using System.Linq;

namespace sampleWebApp.Model
{
    public class User
    {
        public string Id;
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public List<Book> Books { get; set; }

        public static User CreateUser(string name, int phoneNumber, Book book, UserList users)
        {

            var user = new User {Id = Guid.NewGuid().ToString(), Name = name, PhoneNumber = phoneNumber, Books = new List<Book>{book}};
            users.Add(user);
            return user;
        }

    }
}
