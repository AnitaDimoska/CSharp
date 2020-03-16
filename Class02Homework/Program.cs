using System;

namespace Class02Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int userInput1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            int userInput2 = int.Parse(Console.ReadLine());

            if(operation == "/")
            {
                Console.WriteLine($"The result is:  {userInput1 / userInput2}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"The result is:  {userInput1 * userInput2}");
            }
            else if (operation == "+")
            {
                Console.WriteLine($"The result is:  {userInput1 + userInput2}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"The result is:  {userInput1 - userInput2}");
            }
            else
            {
                Console.WriteLine("Something you enter is wrong!");
            }
        }
    }
}
