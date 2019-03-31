using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class User
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string first;

        public string First
        {
            get { return first; }
            set { first = value; }
        }
        private string last;

        public string Last
        {
            get { return last; }
            set { last = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User()
        {
            Id = 0;
            Username = "";
            Password = "";
            Email = "";
            First = "";
            Last = "";
            
        }
    }
}
