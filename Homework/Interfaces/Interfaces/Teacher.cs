using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Teacher : User, ITeacher
    {
        public Teacher(int id, string name, string username, string password, string subject) : base(id, name, username, password)
        {
            Subject = subject;
        }
        string Subject { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"{Name} is {Subject} teacher.");
        }
    }
}
