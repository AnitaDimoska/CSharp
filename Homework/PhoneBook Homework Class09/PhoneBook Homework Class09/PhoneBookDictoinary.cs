using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhoneBookDictoinary
{
    public class PhoneBook
    {
        public PhoneBook(string name, string lastname, double phoneNum)
        {
            Name = name;
            Lastname = lastname;
            PhoneNum = phoneNum;
        }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public double PhoneNum { get; set; }

        public void FindNumber(List<PhoneBook> users)
        {
            Console.WriteLine("Please enter the name of the person:");
            var user = Console.ReadLine().ToLower();
            if (user == Name.ToLower())
            {
                Console.WriteLine($"The phone number of {Name} is {PhoneNum}");
            }
            else
            {
                Console.WriteLine("Sorry, we do not have a person with that name.");
            }
        }
    }
}
