namespace HousingApplication
{
    using System;

    public static class Validator
    {
        public static void ValidateNotNull(string name, string type)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"{type} cannot be null");
            }
        }

        public static void ValidateNotNegative(int value, string type)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }

        public static void ValidateNotNegative(decimal value, string type)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }

        public static void ValidateNotNegative(double value, string type)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }
    }
}
