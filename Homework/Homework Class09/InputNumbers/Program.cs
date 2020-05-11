using System;
using System.Collections.Generic;
using System.Collections;

namespace InputNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> phoneNumbers = new Queue<double>();
            {
                while (true)
                {
                    Console.WriteLine("Please enter the number:");
                    var userInput = Console.ReadLine();
                    double userInput1;
                    if (double.TryParse(userInput, out userInput1))
                    {
                        phoneNumbers.Enqueue(userInput1);
                        while (true)
                        {
                            Console.WriteLine("Do you want to enter another number? Please type 'Y' for yes, or 'N' for no.");
                            var userInput2 = Console.ReadLine();
                            if (userInput2.ToLower() == "y")
                            {
                                Console.WriteLine("Enter the number:");
                                var userInput3 = Console.ReadLine();
                                double userInput4;
                                if (double.TryParse(userInput3, out userInput4))
                                {
                                    phoneNumbers.Enqueue(userInput4);
                                }
                            }
                            else if (userInput2.ToLower() == "n")
                            {
                                Console.WriteLine("You enter these numbers:");
                                foreach (var item in phoneNumbers)
                                {
                                    Console.WriteLine(item);
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You can only enter numbers.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
