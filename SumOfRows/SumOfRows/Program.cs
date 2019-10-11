using System;

namespace SumOfRows
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

            Console.WriteLine("{" + string.Join(",", AddRows(myArray)) + "}");
        }

        private static int[] AddRows(int[,] arr)
        {
            int[] sums = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i , j];
                }
                sums[i] = sum;
            }
            return sums;
        }
    }
}
