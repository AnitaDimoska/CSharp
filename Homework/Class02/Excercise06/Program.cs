using System;

namespace Excercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int userInput1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double userInput2 = int.Parse(Console.ReadLine());

            if (userInput1 > userInput2)
            {
                Console.WriteLine($"Number {userInput1} is larger");
                if (userInput1 % 2 == 0)
                    Console.WriteLine($"Number {userInput1} is even");
                else
                    Console.WriteLine($"Number {userInput1} is odd");
            }
            else if (userInput1 < userInput2)
            {
                Console.WriteLine($"Number {userInput2} is larger");
                if (userInput2 % 2 == 0)
                    Console.WriteLine($"Number {userInput2} is even");
                else
                    Console.WriteLine($"Number {userInput2} is odd");
            }
            else if (userInput1 == userInput2)
            {
                if (userInput1 % 2 == 0)
                    Console.WriteLine("Numbers are equal and even");
                else
                    Console.WriteLine("Numbers are equal and odd");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
