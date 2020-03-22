using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] studentsG1 = { "Ivana", "Petar", "Maja", "Goran", "Lile" };
            string[] studentsG2 = { "Mila", "Goce", "Bojan", "Ana", "Viktor" };

            Console.WriteLine("Please enter student group, 1 or 2:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("The students in G1 are:");
                for(int i = 0; i<studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }
            if (userInput == 2)
            {
                Console.WriteLine("The students in G2 are:");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
        }
    }
}
