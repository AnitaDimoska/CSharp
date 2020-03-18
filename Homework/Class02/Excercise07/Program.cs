using System;

namespace Excercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi broj od 1 do 3:");
            int userInput = int.Parse(Console.ReadLine());
            switch(userInput)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter number 1, 2 or 3!");
                    break;
            }
        }
    }
}
