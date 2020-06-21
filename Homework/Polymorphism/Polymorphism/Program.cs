using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog() { Id = 0, Name = "Riki", Color = "black" };
            Dog dog2 = new Dog() { Id = 2, Name = "Marko", Color = "White" };
            Dog dog3 = new Dog() { Id = 3, Name = "Nola", Color = "Brown" };

            Dog.Validate(dog1);
            Dog.Validate(dog2);
            Dog.Validate(dog3);

            //dog2.Bark();

            List<Dog> dogs = new List<Dog>() { dog1, dog2, dog3 };
            DogShelter.PrintAll(dogs);

            Console.ReadLine();
        }
    }
}
