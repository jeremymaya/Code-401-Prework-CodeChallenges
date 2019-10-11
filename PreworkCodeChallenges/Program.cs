using System;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Array Max Result");
            Console.WriteLine("2) Leap Year Calculator");
            Console.WriteLine("3) Perfect Sequence");
            Console.WriteLine("4) Sum of Rows");
            Console.WriteLine("5) Exit");
            Console.Write("Choose an option: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                CodeChallenge1();
                return true;
            }
            else if (result == "2")
            {
                CodeChallenge2();
                Console.ReadLine();
                return true;
            }
            else if (result == "3")
            {
                Console.Clear();

                int[] arr0 = { 2, 2 };
                int[] arr1 = { 1, 3, 2 };
                int[] arr2 = { 0, 0, 0, 0 };
                int[] arr3 = { 4, 5, 6 };
                int[] arr4 = { 0, 2, -2 };

                CodeChallenge3(arr0);
                CodeChallenge3(arr1);
                CodeChallenge3(arr2);
                CodeChallenge3(arr3);
                CodeChallenge3(arr4);
                Console.ReadLine();
                return true;
            }
            else if (result == "4")
            {
                int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

                CodeChallenge4(myArray);
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void CodeChallenge1()
        {
            Console.Clear();
            int[] numbers = new int[5];

            int counter = 0;
            while (counter < 5)
            {
                counter = GetNumbers(counter, numbers);
            }

            ShowResult(numbers);
        }

        private static int GetNumbers(int counter, int[] numbers)
        {
            Console.Clear();
            Console.Write("Please choose a number between 1 to 10. Same number can be chosen multiple times. ({0}/5): ", counter);
            string numberInput = Console.ReadLine();

            if (int.TryParse(numberInput, out int number) && 0 < number && number < 10)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        numbers[i] = number;
                        break;
                    }
                }
                counter++;

                if (counter < 5)
                {
                    Console.Clear();
                    Console.WriteLine("You have entered '{0}'. Press 'Enter' to choose another number. ({1}/5).", number, counter);
                    Console.ReadLine();
                    return counter;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have entered '{0}'. Press 'Enter' to continue. ({1}/5).", number, counter);
                    Console.ReadLine();
                    return counter;
                }
            }
            else
            {
                Console.WriteLine("That was an invalid entry. Press 'Enter' to try again.");
                Console.ReadLine();
                return counter;
            }
        }

        private static void ShowResult(int[] numbers)
        {
            Console.Clear();
            Console.Write("You have entered [" + string.Join(", ", numbers) + "]. Please select a number from the list for a score: ");
            int selectedNumber = int.Parse(Console.ReadLine());

            bool check = true;
            while (check)
            {
                int score = 1;
                bool one = false;
                foreach (var number in numbers)
                {
                    if (selectedNumber == number)
                    {
                        score = score * number;
                        one = true;
                    }
                }

                if (one)
                {
                    Console.WriteLine("Your score is {0}", score);
                    Console.ReadLine();
                    check = false;
                }
                else
                {
                    Console.Write("That was an invalid entry. Please select a number from [" + string.Join(", ", numbers) + "] for a score: ");
                    selectedNumber = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void CodeChallenge2()
        {
            Console.Clear();
            Console.Write("Please enter a year to evaluate if it is a leap in the format of YYYY: ");
            int year = int.Parse(Console.ReadLine());

            string result = ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 400 == 0)) ? $"Year {year} is a leap year!" : $"Year {year} is a NOT leap year.";

            Console.WriteLine(result);
        }

        private static void CodeChallenge3(int[] arr)
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

            Console.WriteLine("INPUT: [" + string.Join(", ", arr) + "]");
            Console.WriteLine("OUTPUT: " + result);
        }

        private static void CodeChallenge4(int[,] arr)
        {
            Console.Clear();
            int[] sums = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                sums[i] = sum;
            }
            Console.WriteLine("INPUT: int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } }");
            Console.WriteLine("OUTPUT: {" + string.Join(",", sums) + "}");
        }
    }
}