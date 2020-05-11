using System;
using System.Collections.Generic;

namespace FindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            static void FindNumber(Dictionary<string, double> users)
            {
                Console.WriteLine("Please enter the name of the person:");
                var userInput = Console.ReadLine().ToLower();
                foreach (var item in users)
                {
                    if (item.Key.ToLower().Contains(userInput))
                    {
                        Console.WriteLine($"The phone number of {item.Key} is {item.Value}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we do not have a person with that name.");
                        break;
                    }

                }
            }
            Dictionary<string, double> users = new Dictionary<string, double>();
            users.Add("Anita", 274524);
            users.Add("Maria", 278324);
            users.Add("Risto", 274524);
            users.Add("Sasho", 274524);
            users.Add("Martin", 274524);
            FindNumber(users);
            Console.ReadLine();
        }
    }
}
