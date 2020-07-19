using System;
using System.IO;

namespace File_System
{
    class Program
    {
        public static string CalculateNumbers(int num1, int num2)
        {
            var result = $"{num1} + {num2} = " + (num1 + num2);
            var timestamp = DateTime.Now.ToFileTime();
            return result + " | " + timestamp;
        }

        static void Main(string[] args)
        {
            var directoryName = "Exercise";
            var filename = "calculations.txt";
            var appPath = $@"..\..\..\{directoryName}";
            var filePath = appPath + $@"\{filename}";

            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            Console.WriteLine("Enter num1");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            var num2 = int.Parse(Console.ReadLine());
            var res = CalculateNumbers(num1, num2);
            Console.WriteLine(CalculateNumbers(num1, num2));

            if (!File.Exists(appPath))
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(res);
                }
            }
        }
    }
}
