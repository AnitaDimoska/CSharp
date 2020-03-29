using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi go datumot na raganje");

            string dateInput = Console.ReadLine();
            DateTime birthDay = DateTime.Parse(dateInput);
            DateTime todaysDate = DateTime.Now;

            int yearsOld = todaysDate.Year - birthDay.Year;
            if (birthDay.Month == todaysDate.Month)
            {
                if (birthDay.Day > todaysDate.Day)
                {
                    Console.WriteLine($"Imas {yearsOld} godini i {birthDay.Day - todaysDate.Day} den");
                }
                else if (birthDay.Day == todaysDate.Day)
                {
                    Console.WriteLine($"Imas {yearsOld} godini i sreken rodenden");
                }
                else
                {
                    Console.WriteLine($"Za {todaysDate.Day - birthDay.Day} dena ke napolnis {yearsOld} godini");
                }
            }
            else if (todaysDate.Month > todaysDate.Month)
            {
                Console.WriteLine($"You are {yearsOld} years old i {birthDay.Month - todaysDate.Month} meseci");

            }
            else
            {
                Console.WriteLine($"Ke napolnis {yearsOld} za {birthDay.Month - todaysDate.Month} meseci");
            }
        }
    }
}
