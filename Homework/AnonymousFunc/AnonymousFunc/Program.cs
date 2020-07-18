using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousFunc
{
    class Program
    {
        public static void FindNamesWithR(List<Person> people)
        {
            var startingWithR = from elements in people
                                where elements.FirstName.StartsWith("R")
                                select elements;
            var rNamesByAge = startingWithR.OrderByDescending(x => x.Age);

            Console.WriteLine("These are the names starting with R, ordered by age:");
            foreach (var item in rNamesByAge)
            {
                Console.WriteLine($"{ item.FirstName}");
            }
        }

        public static void BrownDogs(List<Dog> dogs)
        {
            var brownDogs = from elements in dogs
                            where elements.Color == "Brown"
                            select elements;
            var brownDogsOlderThan3 = brownDogs.OrderBy(x => x.Age);
            Console.WriteLine($"These are all brown dogs older than 3 years:");
            foreach (var item in brownDogsOlderThan3)
            {
                Console.WriteLine($"{ item.Name}");
            }
        }

        public static void PeopleWithMoreThanTwoDogs(List<Person> people)
        {
            var moreThantwoDogs = from elements in people
                                  where elements.Dogs.Count > 2
                                  select elements;
            moreThantwoDogs.OrderByDescending(x => x.FirstName);
            Console.WriteLine("These are the names of people with more than 2 dogs:");
            foreach (var item in moreThantwoDogs)
            {
                Console.WriteLine($"{ item.FirstName}");
            }
        }

        public static void FreddyDogsOlderThan1(List<Dog> dogs)
        {
            var freddyDogs = from elements in dogs
                             where elements.Age > 1
                             select elements;
            Console.WriteLine("These are the names of Freddy dogs older than 1 year:");
            foreach (var item in freddyDogs)
            {
                Console.WriteLine($"{ item.Name}");
            }
        }

            static void Main(string[] args)
        {
            Dog riki = new Dog("Riki", "Brown", 2, "Anita");
            List<Dog> anitaDogs = new List<Dog>() { riki };
            Person anita = new Person("Anita", 30, anitaDogs);

            Dog luna = new Dog("Luna", "White", 2, "Radmila");
            List<Dog> radaDogs = new List<Dog>() { luna };
            Dog ria = new Dog("Lisa", "White", 1, "Radica");
            List<Dog> racaDogs = new List<Dog>() { ria };
            Person rada = new Person("Radmila", 25, radaDogs);
            Person raca = new Person("Radica", 28, racaDogs);

            Dog miki = new Dog("Miki", "Brown", 4, "Christofer");
            List<Dog> christoferDogs = new List<Dog>() { miki };
            Person christofer = new Person("Christofer", 18, christoferDogs);

            Dog ciki = new Dog("Ciki", "White", 4, "Freddy");
            Dog piki = new Dog("Piki", "White", 1, "Freddy");
            Dog liki = new Dog("Liki", "White", 2, "Freddy");
            List<Dog> freddyDogs = new List<Dog>() { ciki, piki, liki };
            Person freddy = new Person("Freddy", 20, freddyDogs);

            Dog mini = new Dog("Mini", "White", 1, "Freddy");
            Dog lisa = new Dog("Lisa", "brown", 3, "Nathen");
            List<Dog> nathenDogs = new List<Dog>() { mini, lisa };
            Person nathen = new Person("Nathen", 40, nathenDogs);

            Dog nia = new Dog("Nia", "White", 5, "Amelia");
            List<Dog> ameliaDogs = new List<Dog>() { nia };
            Person amelia = new Person("Amelia", 15, ameliaDogs);

            Dog lia = new Dog("Lia", "White", 2, "Erin");
            Dog lion = new Dog("Lion", "Brown", 3, "Erin");
            List<Dog> erinDogs = new List<Dog>() { lia };
            Person erin = new Person("Erin", 50, erinDogs);

            List<Person> people = new List<Person>() { rada, raca, anita, christofer, freddy, nathen, amelia, erin };
            FindNamesWithR(people);

            List<Dog> dogs = new List<Dog>() { riki, luna, ria, miki, ciki, piki, liki, mini, lisa, nia, lia, lion };
            BrownDogs(dogs);

            PeopleWithMoreThanTwoDogs(people);
            FreddyDogsOlderThan1(freddyDogs);

            var firstNathenDog = nathenDogs.First();
            Console.WriteLine($"Nathen first dog is: {firstNathenDog.Name}");

            List<Person> peopleWithWhiteDogs = new List<Person>() { christofer, freddy, amelia, erin };
            var whiteDogs = peopleWithWhiteDogs
                .SelectMany(x => x.Dogs)
                .Where(x => x.Color == "White")
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList();

            Console.WriteLine($"These are white dogs from Christofer, Freddy, Amelia and Erin:");
            foreach (var item in whiteDogs)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadKey();
        }
    }
}
