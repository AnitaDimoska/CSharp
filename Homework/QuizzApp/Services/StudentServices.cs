using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class StudentServices
    {
        public void CheckStudentUsername(List<Student> students)
        {
            Console.WriteLine("Please enter the username:");
            var studentUsername = Console.ReadLine();
   
            Console.WriteLine("Please enter the password:");
            var studentpassword = Console.ReadLine();
           
        }

    }
}
