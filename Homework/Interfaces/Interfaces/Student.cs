using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
   public class Student: User, IStudent
    {
        public Student(int id, string name, string username, string password, List<string> grades): base(id, name, username, password)
        {
            Grades = grades;
        }
        List<string> Grades { get; set; }
        public override void PrintUser()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine($"Grades of student {Name} are: {grade}");
            }
        }
    }
}
