using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class PetStore<T> where T : Pet
    {
        public PetStore()
        {
            Pets = new List<T>();
        }
        public List<T> Pets { get; set; }
        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void BuyPet(T pet)
        {
            var found = Pets.Find(x => x.Name == pet.Name);
            if (found != null)
            {
                Console.WriteLine($"The pet with name {found.Name} is in pet store.");
                Pets.Remove(found);
            }
            else
            {
                Console.WriteLine("The pet is not found in pet store.");
            }
        }
    }
}
