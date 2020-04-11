using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string[] Messages { get; set; }
        }

        public static User[] GetAllUsers()
        {
            var user1 = new User
            {
                Id = 123,
                Username = "Anna",
                Password = "123",
                Messages = new string[] { "message 1", "message 2" }
            };
            var user2 = new User
            {
                Id = 123,
                Username = "Mia",
                Password = "456abv",
                Messages = new string[] { }
            };
            var user3 = new User
            {
                Id = 123,
                Username = "Jane",
                Password = "789abv",
                Messages = new string[] { "message 1" }
            };

            User[] users = new User[] { user1, user2, user3 };

            return users;
        }

        public static void ShowMessages(User user)
        {
            foreach (var item in user.Messages)
            {
                Console.WriteLine(item);
            }
        }

        public static void Login(string username, string password)
        {
            var users = GetAllUsers();
            foreach (var item in users)
            {
                if (username == item.Username && password == item.Password)
                {
                    Console.WriteLine($"Welcome {username}, here are your messages:\n");
                    ShowMessages(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong username or password");
                    break;
                }
            }
        }

        public static void Register(int id, string username, string password)
        {
            var users = GetAllUsers();
            foreach (var item in users)
            {
                if (username == item.Username)
                {
                    Console.WriteLine("There is already a user with that name!");
                    break;
                }
                else
                {
                    var user = new User() { Id = id, Username = username, Password = password };
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = user;
                    PrintUsers(users);
                    break;
                }
            }
        }

        private static void PrintUsers(User[] users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"Registration complete! Users:\n {item.Id}{item.Username}\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for login, 2 for register:");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Please enter you username:");
                string usernameInput = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string userPassword = Console.ReadLine();
                Login(usernameInput, userPassword);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Please enter your ID:");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your username:");
                string usernameInput = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string userPassword = Console.ReadLine();
                Register(id, usernameInput, userPassword);
            }
            else
            {
                Console.WriteLine("Please choose 1 or 2!");
            }
        }
    }
}
