using System;
using System.Collections.Generic;
using System.Linq;
using PhoneBookDictoinary;

namespace PhoneBookDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhoneBook> users = new List<PhoneBook>
            {
                new PhoneBook("Anita", "Dimoska", 274524),
                new PhoneBook("Maria", "Stojanoska", 278324),
                new PhoneBook("Risto", "Ristoski", 274524),
                new PhoneBook("Sasho", "Delev", 274524),
                new PhoneBook("Martin", "Kostovski", 274524)
            };
            FindNumber(users);
            Console.ReadLine();
        }
    }
}
