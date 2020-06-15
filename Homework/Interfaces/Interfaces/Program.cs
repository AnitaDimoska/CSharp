using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher1 = new Teacher(1, "Ana", "AnaD", "123", "Math");
            var teacher2 = new Teacher(2, "Mia", "MiaS", "123", "English");
            var student1 = new Student(3, "Marko", "MarkoM", "123", new List<string> { "A, C, E" });
            var student2 = new Student(4, "Stefan", "Stef", "123", new List<string> { "A, A, B" });
            teacher1.PrintUser();
            teacher2.PrintUser();
            student1.PrintUser();
            student2.PrintUser();
            Console.ReadKey();
        }
    }
}
