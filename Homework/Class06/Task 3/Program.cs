using System;

namespace Task_3
{
    class Program
    {
        public class Customer
        {
            public string Username { get; set; }
            public string CardNumber { get; set; }
            public int Pin { get; set; }
            public double Money { get; set; }
        }

        public static Customer[] GetCustomers()
        {
            var customer1 = new Customer
            {
                Username = "Anna",
                CardNumber = "123 - 124 - 125",
                Pin = 1234,
                Money = 200
            };
            var customer2 = new Customer
            {
                Username = "Maria",
                CardNumber = "120 - 124 - 125",
                Pin = 5678,
                Money = 2000
            };
            var customer3 = new Customer
            {
                Username = "Tom",
                CardNumber = "223 - 224 - 225",
                Pin = 4321,
                Money = 5
            };
            var customer4 = new Customer
            {
                Username = "Bob",
                CardNumber = "321 - 124 - 125",
                Pin = 9876,
                Money = 500
            };
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            return customers;

        }
        public static void LogIn()
        {
            var customers = GetCustomers();
            Console.WriteLine("Please enter your name:");
            var username = Console.ReadLine();
            Console.WriteLine("Please enter a card number");
            var cardNum = Console.ReadLine();

            foreach (var item in customers)
            {
                if (item.Username == username)
                {
                    Console.WriteLine("Please enter your pin");
                    int pinNum = int.Parse(Console.ReadLine());
                    if (item.Pin == pinNum)
                    {
                        Console.WriteLine($"Welcome {item.Username}! Choose an option:\n 1. Balance checking\n 2. Cash withdrawal\n 3. Cash deposition");
                        var userInput = Console.ReadLine();
                        if (userInput == "1")
                        {
                            Console.WriteLine($"You have {item.Money}$ on your account.");
                        }
                        else if (userInput == "2")
                        {
                            CashWithdrawal(item.Money);
                        }
                        else if (userInput == "3")
                        {
                            CashDeposit(item.Money);
                        }
                    }
                }
            }
        }
        public static void CashWithdrawal(double money)
        {
            Console.WriteLine("How much money you want to withdrew?");
            var userwithdraw = int.Parse(Console.ReadLine());
            if (userwithdraw <= money)
            {
                Console.WriteLine($"You withdraw {userwithdraw}$, and now have {money - userwithdraw}$ left");
            }
            else
            {
                Console.WriteLine("You do not have enough money on your account");
            }
        }

        public static void CashDeposit(double money)
        {
            Console.WriteLine("How much money you want to pay on your account?");
            var userDeposit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Now you have {userDeposit + money}$ on your account");
        }

        static void Main(string[] args)
        {
            LogIn();
        }
    }
}
