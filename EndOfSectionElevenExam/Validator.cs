namespace EndOfSectionElevenExam
{
    using System;

    public static class Validator
    {
        public static void ValidateNotNull(string text, string type)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException($"{type} cannot be null");
            }
        }

        public static void ValidateNotNegative(int number, string type)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }

        public static void ValidateNotNegative(decimal number, string type)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }

        public static void ValidateNotNegative(double number, string type)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }
    }
}
