using System;

namespace Task_3
{
    class Program
    {
        public class Customer
        {
            public string Username { get; set; }
            public long CardNumber { get; set; }
            private int Pin { get; set; }
            public double Money { get; set; }

            public static Customer[] GetCustomers()
            {
                var customer1 = new Customer
                {
                    Username = "Anna",
                    CardNumber = 1232124312511251,
                    Pin = 1234,
                    Money = 200
                };
                var customer2 = new Customer
                {
                    Username = "Maria",
                    CardNumber = 1200124012501251,
                    Pin = 5678,
                    Money = 2000
                };
                var customer3 = new Customer
                {
                    Username = "Tom",
                    CardNumber = 1232120312511251,
                    Pin = 4321,
                    Money = 5
                };
                var customer4 = new Customer
                {
                    Username = "Bob",
                    CardNumber = 1232124312511251,
                    Pin = 9876,
                    Money = 500
                };
                Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
                return customers;

            }

            public void LogIn()
            {

                var customers = GetCustomers();
                Console.WriteLine("Please enter your name:");
                var username = Console.ReadLine();
                Console.WriteLine("Please enter a card number");
                var cardNum = Console.ReadLine();


                foreach (var item in customers)
                {
                    if (item.Username == username && item.CardNumber == MakeCardNumber(cardNum))
                    {
                        Console.WriteLine("Please enter your pin");
                        int pinNum = int.Parse(Console.ReadLine());

                        if (item.GetPin() == pinNum)
                        {
                            Console.WriteLine($"Welcome {item.Username}!");
                            while (true)
                            {
                                Console.WriteLine($"Choose an option:\n 1. Balance checking\n 2. Cash withdrawal\n 3. Cash deposition\n 4. Exit");
                                var userInput = Console.ReadLine();
                                if (userInput == "1")
                                {
                                    Console.WriteLine($"You have {item.CheckBalance()}$ on your bank account");
                                }
                                else if (userInput == "2")
                                {
                                    Console.WriteLine("How much money you want to withdrew?");
                                    var userwithdraw = int.Parse(Console.ReadLine());
                                    if (userwithdraw <= item.Money)
                                        Console.WriteLine($"You withdraw {userwithdraw}$, and now have {item.CashWithdrawal(userwithdraw)}$ left");
                                    else
                                    {
                                        Console.WriteLine("You do not have enough money on your account");
                                    }
                                }
                                else if (userInput == "3")
                                {
                                    Console.WriteLine("How much money you want to deposit?");
                                    var userdeposit = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"You deposit is {userdeposit}$, and now have {item.CashDeposit(userdeposit)}$");
                                }
                                else if (userInput == "4")
                                {
                                    Console.WriteLine("Bye!");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            private double CheckBalance()
            {
                return Money;
            }
            private int GetPin()
            {
                return Pin;
            }

            public double CashWithdrawal(double money)
            {
                return Money -= money;
            }

            public double CashDeposit(double money)
            {
                return Money += money;
            }
            public long MakeCardNumber(string cardNum)
            {
                var numberCard = string.Format("{0}{1}{2}{3}",
                    cardNum.Substring(0, 4),
                    cardNum.Substring(5, 4),
                    cardNum.Substring(10, 4),
                    cardNum.Substring(15, 4));

                return long.Parse(numberCard);
            }
        }
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.LogIn();
        }
    }
}
