using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPhil.Data
{
    public class UserManager
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Resources\\res\\Users.txt");

        public static List<User> users = new List<User>();

        public UserManager()
        {
            // loading the data when the object is created
            populateUsers();
        }

        private void populateUsers()
        {
            User user;

            foreach(string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(',');
                int id = int.Parse(parts[0]);
                string email = parts[1];
                string course = parts[2];

                // user object
                user = new User(id, email, course);

                // add user object into the list 'users'
                users.Add(user);
            }
        }

        public static List<User> GetUsers()
        {
            // return users list
            return users;
        }

    }
}
