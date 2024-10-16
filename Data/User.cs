using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPhil.Data
{
    public class User
    {
        // id, email, course
        int id;
        string email;
        string course;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Course { get => course; set => course = value; }

        public User(int id, string email, string course)
        {
            this.id = id;
            this.email = email;
            this.course = course;
        }
    }
}
