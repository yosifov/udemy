using System;

namespace CodingQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int left = 0;

            while (left <= 2)
            {
                int right = 10;

                while (right >= 6)
                {
                    Console.Write($"Outer: {left}");
                    Console.Write("\t");
                    Console.WriteLine($"Inner: {right}");

                    right--;
                }

                left++;
            }
        }
    }
}
