using System;
using System.Collections.Generic;
using Domain;

namespace QuizzApp
{
   class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Anita", "anita1"));
            students.Add(new Student("Maja", "maja1"));
            students.Add(new Student("Bojan", "bojan1"));
            students.Add(new Student("Zlatko", "zlatko1"));
            students.Add(new Student("Biljana", "biljana1"));
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Mirko", "mirko10"));
            teachers.Add(new Teacher("Snezana", "snezana10"));
            teachers.Add(new Teacher("Toni", "toni10");
            Console.ReadLine();
        }
    }
}
