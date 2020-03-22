using System;

namespace HomeworkClass03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer: ");
            int userNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer: ");
            int userNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third integer: ");
            int userNum3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter forth integer: ");
            int userNum4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fifth integer: ");
            int userNum5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter sixth integer: ");
            int userNum6 = int.Parse(Console.ReadLine());

            int[] arrayOfInputs = { userNum1, userNum2, userNum3, userNum4, userNum5, userNum6 };
            int sum = 0;
            for (int i = 0; i < arrayOfInputs.Length; i++)
            {
                if (arrayOfInputs[i] % 2 == 0)
                {
                    sum += arrayOfInputs[i];
                }

            }

            Console.WriteLine($"The sum of even numbers from inputs is {sum}");
        }
    }
}
