using System;

namespace Task1
{
    class Program
    {
        public static void NumberStats()
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            double userInput;
            if (double.TryParse(input, out userInput))
            {
                Console.WriteLine($"Stats for number: {userInput}");
                if (userInput >= 0 && userInput % 2 == 0 && userInput % 1 == 0)
                    Console.WriteLine("Positive \nInteger \nEven");
                else if (userInput >= 0 && userInput % 2 != 0 && userInput % 1 == 0)
                    Console.WriteLine("Positive \nInteger \nOdd");
                else if (userInput >= 0 && userInput % 1 != 0)
                    Console.WriteLine("Positive \nDecimal");
                else if (userInput <= 0 && userInput % 1 != 0)
                    Console.WriteLine("Negative \nDecimal");
                else if (userInput < 0 && userInput % 2 == 0 && userInput % 1 == 0)
                    Console.WriteLine("Negative \nInteger \nEven");
                else if (userInput < 0 && userInput % 2 != 0 && userInput % 1 == 0)
                    Console.WriteLine("Negative \nInteger \nOdd");
            }
            else Console.WriteLine("You must enter a number:");
        }

        public static void CheckAgain()
        {
            while (true)
            {
                Console.WriteLine("If you want to check number again press Y, if not, press X");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "x")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                if (userInput.ToLower() == "y")
                {
                    NumberStats();
                }
            }
        }
        static void Main(string[] args)
        {
            NumberStats();
            CheckAgain();
        }
    }
}
