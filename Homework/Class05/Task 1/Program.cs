using System;

namespace Task_1
{
    class Program
    {
        class Dog
        {
            public Dog(string name, string race, string color)
            {
                Name = name;
                Race = race;
                Color = color;
            }
            public string Name { get; set; }
            public string Race { get; set; }
            public string Color { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating");
            }
            public void Play()
            {
                Console.WriteLine($"{Name} is now playing");
            }
            public void ChaseTail()
            {
                Console.WriteLine($"{Name} is now chasing its tail");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog's name:");
            string dogsName = Console.ReadLine();
            Console.WriteLine("Enter dog's race:");
            string dogsRace = Console.ReadLine();
            Console.WriteLine("Enter dog's color:");
            string dogsColor = Console.ReadLine();
            Dog dog = new Dog(dogsName, dogsRace, dogsColor);

            Console.WriteLine("Choose what dog to do");
            Console.WriteLine("1: Eat");
            Console.WriteLine("2: Play");
            Console.WriteLine("3: Chase Tail");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
                dog.Eat();
            else if (userChoice == "2")
                dog.Play();
            else if (userChoice == "3")
                dog.ChaseTail();
            else
                Console.WriteLine("Please choose an option from 1 to 3");
        }
    }
}
