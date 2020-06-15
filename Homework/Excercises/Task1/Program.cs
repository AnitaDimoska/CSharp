using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter names, when you want to stop enter X:");
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name:");
                var userInput = Console.ReadLine();
                names.Add(userInput);
                if (userInput.ToLower() == "x")
                {
                    break;
                }
            }
            Console.WriteLine("Enter a text:");
            var userInput1 = Console.ReadLine().ToLower();
            var counter = 0;
            Dictionary<string, int> namesCont = new Dictionary<string, int>();
            foreach (var item in names)
            {
                if (userInput1.Contains(item))
                {
                    counter++;
                    namesCont.Add(item, 1);
                }
            }
            Console.WriteLine($"The name is in text {counter} times.");
        }
    }
}
