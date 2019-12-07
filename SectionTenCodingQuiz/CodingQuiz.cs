namespace SectionTenCodingQuiz
{
    using System;
    using System.Linq;
    using System.Text;

    public class CodingQuiz
    {
        public static void Execute()
        {
            Console.Write("Enter a number between 0 and 10 (type end to quit): ");
            string input = Console.ReadLine();
            int[] validNumbers = new int[11];
            int invalidCounter = 0;
            int numbersOutsideOfBoundary = 0;

            while (input != "end")
            {
                if (!input.All(char.IsDigit) || string.IsNullOrEmpty(input))
                {
                    numbersOutsideOfBoundary++;
                    Console.Write("Invalid input! Enter a number between 0 and 10 (type end to quit): ");
                }
                else
                {
                    var number = int.Parse(input);
                    if (number >= 0 && number <= 10)
                    {
                        validNumbers[number]++;
                        Console.Write("Enter a number between 0 and 10 (type end to quit): ");
                    }
                    else
                    {
                        invalidCounter++;
                        Console.Write("Invalid number! Enter a number between 0 and 10 (type end to quit): ");
                    }
                }

                input = Console.ReadLine();
            }

            PrintValidNumbers(validNumbers);
            Console.WriteLine($"Valid inputs: {validNumbers.Sum()}");
            Console.WriteLine($"Invalid inputs: {invalidCounter}");
            Console.WriteLine($"Numbers outside of boundary: {numbersOutsideOfBoundary}");
            Console.WriteLine($"Total number of inputs: {validNumbers.Sum() + invalidCounter + numbersOutsideOfBoundary}");
        }

        public static void PrintValidNumbers(int[] numbers)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Number\tCount");
            for (int i = 0; i <= 10; i++)
            {
                if (numbers[i] > 0)
                {
                    sb.AppendLine($"{i}\t{numbers[i]}");
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
