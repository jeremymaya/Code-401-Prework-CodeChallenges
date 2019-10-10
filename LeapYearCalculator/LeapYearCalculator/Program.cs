using System;

namespace LeapYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a year to evaluate if it is a leap in the format of YYYY: ");
            int year = int.Parse(Console.ReadLine());

            string result = ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 400 == 0)) ? $"Year {year} is a leap year!" : $"Year {year} is a NOT leap year.";
            
            Console.WriteLine(result);
        }
    }
}
