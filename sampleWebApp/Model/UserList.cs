using System.Collections.Generic;

namespace sampleWebApp.Model
{
    public class UserList
    {
        private List<User> UsersList { get; set; }

        public UserList()
        {
            this.UsersList = new List<User>();
        }

        public void Add(User user)
        {
            UsersList.Add(user);
        }

        public User this[string id]
        {
            get { return UsersList.Find(user => user.Id == id); }
        }
    }
}