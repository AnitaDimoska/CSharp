using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Teacher
    {
        public Teacher(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
