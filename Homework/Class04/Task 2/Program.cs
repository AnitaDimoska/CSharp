using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime threeDaysFromNow = currentDateTime.AddDays(3);
            Console.WriteLine(threeDaysFromNow);

            DateTime oneMonthFromNow = currentDateTime.AddMonths(1);
            Console.WriteLine(oneMonthFromNow);

            DateTime monthAndThreeDays = oneMonthFromNow.AddDays(3);
            Console.WriteLine(monthAndThreeDays);

            DateTime oneYearAndTwoMonthsFromNow = currentDateTime.AddYears(-1).AddMonths(-2);
            Console.WriteLine(oneYearAndTwoMonthsFromNow);

            int month = currentDateTime.Month;
            Console.WriteLine(month);

            int year = currentDateTime.Year;
            Console.WriteLine(year);
        }
    }
}
