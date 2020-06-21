using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        public static void PrintAll(List<Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog.Id} {dog.Name} {dog.Color}");
            }
        }
    }
}
