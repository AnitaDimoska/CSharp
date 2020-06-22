using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DogStore
            var dog1 = new Dog("Riki", Type.Dog, 1, true, "meat");
            dog1.PrintInfo();
            var dog2 = new Dog("Marko", Type.Dog, 2, false, "bone");
            dog2.PrintInfo();
            var dogStore = new PetStore<Dog>();
            dogStore.Pets.Add(dog1);
            dogStore.Pets.Add(dog2);
            dogStore.PrintPets();
            dogStore.BuyPet(dog1);
            dogStore.PrintPets();
            #endregion
            #region CatStore
            var cat1 = new Cat("Mia", Type.Cat, 4, true, 5);
            var cat2 = new Cat("Tomas", Type.Cat, 2, false, 8);
            cat1.PrintInfo();
            var catStore = new PetStore<Cat>();
            catStore.Pets.Add(cat1);
            catStore.Pets.Add(cat2);
            catStore.PrintPets();
            catStore.BuyPet(cat1);
            catStore.PrintPets();
            #endregion
            #region FishStore
            var fish1 = new Fish("Nemo", Type.Fish, 1, "yellow", 1.3);
            var fish2 = new Fish("Jack", Type.Fish, 1, "blue", 1.5);
            fish2.PrintInfo();
            var fishStore = new PetStore<Fish>();
            fishStore.Pets.Add(fish1);
            fishStore.Pets.Add(fish2);
            fishStore.BuyPet(fish1);
            fishStore.PrintPets();
            #endregion
            Console.ReadKey();
        }
    }
}
