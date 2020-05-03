using Services;
using System;
using Domain;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //var anita = new Employee(1, "Anita", "Dimoska", Role.Sales, 1000, 00);
            //var marija = new Employee(2, "Marija", "Stojanovska", Role.Finance, 800, 00);
            //var jovan = new Employee(4, "Jovan", "Jovanoski", Role.Worker, 600, 00);
            Manager bojan = new Manager();
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            Worker[] workers = new Worker[] { worker1, worker2 };
            Manager ivan = new Manager(20, "Ivan", "Ivanovski", Role.Menager, 8, 1400, workers, DepartmentType.Development);
            
            //Worker pero = new Worker(3, "Petar", "Petkovski", Role.Worker, 40, 500, bojan);
            //Worker slavko = new Worker(5, "Slavko", "Stojanovski", Role.Worker, 40, 700, bojan);
            //EmployeeServices empSer = new EmployeeServices();
            //Role newRole = Role.Menager;
            //Employee[] employeesByRole = empSer.GetEmployeesByRole(employees, newRole);

            //foreach (var employee in employeesByRole)
            //{
            //    Console.WriteLine(employee.PrintInfo());
            //}

            ProductServices productService = new ProductServices();
            Product[] products = new Product[]
            {
               productService.CreateFood(4,"orange",ProductType.Food, 100.00, Taste.Sweet, 50 ),
               productService.CreateFood(3,"meat",ProductType.Food, 180.00, Taste.Salty, 500 ),
               productService.CreateDrink(1,"beer",ProductType.Drink, 100.00, 1.5 ),
               productService.CreateDrink(2,"water",ProductType.Drink, 10.00, 2.5 ),
            };

            var drinks = productService.GetproductsByType(products, ProductType.Drink);
            foreach (var item in drinks)
            {
                Console.WriteLine(item.Name);
            }

            var food = productService.GetproductsByType(products, ProductType.Food);
            foreach (var item in food)
            {
                Console.WriteLine(item.Name);
            }
            var anita = new SalesPerson(1, "Anita", "Dimoska", Role.Sales, 8, 2500);
            anita.AddSuccessRevenue(10.00);
            Console.WriteLine(anita.GetSalary());
            var marina = new ManagerBonus(10, "Marina", "Radevska", Role.Menager, 6, 2000);
            marina.AddBonus(150);
            Console.WriteLine(marina.GetSalary());
            var marko = new Contractor(11, "Marko", "Markovski", Role.Worker, 7, 1200, 8, 70, ivan);
            Console.WriteLine(marko.GetSalary());
            Console.WriteLine(marko.CurrentPosition());
        }
    }
}
