using System;

namespace ArrayMaxResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int[] numbers = new int[5];
            while (counter < 5)
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
                    Console.Clear();
                    Console.WriteLine("You have entered '{0}'. Press 'Enter' to choose another number. ({1}/5).", number, counter);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That was an invalid entry. Press 'Enter' to try again.");
                    Console.ReadLine();
                }
            }

            // Source: https://www.codeproject.com/Questions/1202570/Why-this-source-code-giving-output-system-int-inst
            Console.Clear();
            Console.Write("You have entered [" + string.Join(", ", numbers) + "]. Please select a number from the list for a score: ");
            int selectedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(selectedNumber);
            Console.ReadLine();
        }
    }
}