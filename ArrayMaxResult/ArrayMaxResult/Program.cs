using System;

namespace ArrayMaxResult
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int score = 0;
            while (score == 0)
            {
                foreach (var number in numbers)
                {
                    if (selectedNumber == number)
                    {
                        score = (score + 1) * number;
                    }
                }

                if (score != 0)
                {
                    Console.WriteLine("Your score is {0}", score);
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("That was an invalid entry. Please select a number from [" + string.Join(", ", numbers) + "] for a score: ");
                    selectedNumber = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}