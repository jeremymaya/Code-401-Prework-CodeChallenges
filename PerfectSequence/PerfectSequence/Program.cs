using System;

namespace PerfectSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr0 = { 2, 2 };
            int[] arr1 = { 1, 3, 2 };
            int[] arr2 = { 0, 0, 0, 0 };
            int[] arr3 = { 4, 5, 6 };
            int[] arr4 = { 0, 2, -2 };

            EvaluateSequence(arr0);
            EvaluateSequence(arr1);
            EvaluateSequence(arr2);
            EvaluateSequence(arr3);
            EvaluateSequence(arr4);
            Console.ReadLine();
        }

        private static void EvaluateSequence(int[] arr)
        {
            int product = 1;
            int sum = 0;
            foreach (var number in arr)
            {
                if (number >= 0)
                {
                    product = product * number;
                    sum += number;
                }
            }
            string result = (product == sum) ? "Yes" : "No";

            Console.WriteLine(result);
        }
    }
}
