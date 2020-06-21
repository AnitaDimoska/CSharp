using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
      
        public void Bark()
        {
            Console.WriteLine("Bark, bark!");
        }
        public static void Validate(Dog dog)
        {
            if(dog.Id > 0 && dog.Name.Length >= 2 && dog.Color != null )
            {
                Console.WriteLine($"The dog {dog.Name} has valid info.");
            }
            else
            {
                Console.WriteLine($"Info for the dog {dog.Name} is not valid.");
            }
        }
    }
}
