using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Substrings()
            {
                string mainString = "Hello from SEDC Codecademy v7.0";
                int stringLength = mainString.Length;

                Console.WriteLine("Please enter number:");
                int userInput = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (userInput <= stringLength)
                    {
                        string newString = mainString.Substring(0, userInput);
                        Console.WriteLine(newString);
                        Console.WriteLine(newString.Length);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number smaller than {stringLength}");
                    }
                    break;
                }
            }
            Substrings();
        }
    }
}
