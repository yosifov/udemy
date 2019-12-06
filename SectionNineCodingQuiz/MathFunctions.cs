namespace SectionNineCodingQuiz
{
    using System;

    public class MathFunctions
    {
        public static double SquareRoot(double number)
        {
            double result = Math.Sqrt(number);
            return result;
        }

        public static int Sum(int firstNumber, int secondNumber)
        {
            int resulst = firstNumber + secondNumber;
            return resulst;
        }

        public static double Sum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        public static decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber + secondNumber;
            return result;
        }
    }
}
