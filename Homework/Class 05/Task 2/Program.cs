using System;

namespace Task_2
{
    class Program
    {
        public class Driver
        {
            public Driver(string name, int skill)
            {
                Name = name;
                Skill = skill;
            }

            public string Name { get; set; }
            public int Skill { get; set; }
        }

        public class Car
        {
            public Car(string model, int speed, Driver driver)
            {
                Model = model;
                Speed = speed;
                Driver = driver;
            }
            public string Model { get; set; }
            public int Speed { get; set; }
            public Driver Driver { get; set; }

            public int CalculateSpeed(Driver driver)
            {
                return driver.Skill * Speed;
            }
        }
        public static void ChooseCar(string car1Input)
        {
            String[] cars = new string[] { "Hyndai", "Mazda", "Ferrari", "Porsche" };
            foreach (var item in cars)
            {
                if (car1Input.ToLower() != item.ToLower())
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void ChooseDriver(string driver1Input)
        {
            String[] drivers = new string[] { "Bob", "Greg", "Jill", "Anne" };
            foreach (var item in drivers)
            {
                if (driver1Input.ToLower() != item.ToLower())
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void RaceCars(Car car1, Car car2, Driver driver1, Driver driver2)
        {
            if (car1.CalculateSpeed(driver1) > car2.CalculateSpeed(driver2))
                Console.WriteLine($"{car1.Driver.Name} is faster, drove {car1.Model} with {car1.Speed} km/h");
            else if (car1.CalculateSpeed(driver1) < car2.CalculateSpeed(driver2))
                Console.WriteLine($"{car2.Driver.Name} is faster, drove {car2.Model} with {car2.Speed} km/h");
            else
                Console.WriteLine("Both drivers drive equal");
        }

        public static void Race()
        {
            Console.WriteLine("Please choose first car from the list:");
            ChooseCar("");
            string car1Input = Console.ReadLine();

            Console.WriteLine("Please choose first driver from the list:");
            ChooseDriver("");
            string driver1Input = Console.ReadLine();

            Console.WriteLine("Please choose second car from the list:");
            ChooseCar(car1Input);
            string car2Input = Console.ReadLine();

            Console.WriteLine("Please choose second driver from the list:");
            ChooseDriver(driver1Input);
            string driver2Input = Console.ReadLine();

            Driver driver1 = new Driver(driver1Input, 3);
            Driver driver2 = new Driver(driver2Input, 2);
            Car car1 = new Car(car1Input, 120, driver1);
            Car car2 = new Car(car2Input, 130, driver2);
            RaceCars(car1, car2, driver1, driver2);
        }

        public static void RaceAgain()
        {
            Console.WriteLine("Do you want to race again? \n Yes \n No");
            string userChoise = Console.ReadLine().ToLower();
            if (userChoise == "yes")
                Race();
            else
                Console.WriteLine("Bye!");
        }

        static void Main(string[] args)
        {
            Race();
            RaceAgain();
        }
    }
}
