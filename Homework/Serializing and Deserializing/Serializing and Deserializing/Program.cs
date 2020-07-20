using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Serializing_and_Deserializing
{
    class Program
    {
        private static FileFolderService _fileFolderService { get; set; } = new FileFolderService();
        public static void PrintDogs(List<Dog> dogs)
        {
            foreach (Dog item in dogs)
            {
                Console.WriteLine($"{ item.Name} { item.Age } { item.Color}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dogs name, age and color:");
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var color = Console.ReadLine();

            var dog1 = new Dog(name, age, color);
            _fileFolderService.InsertToJSON(dog1);

            List<Dog> dogs = _fileFolderService.ReadJSON<Dog>().ToList();
            PrintDogs(dogs);
        }
    }
}
