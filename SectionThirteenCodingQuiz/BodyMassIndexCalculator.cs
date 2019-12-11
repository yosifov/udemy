namespace SectionThirteenCodingQuiz
{
    using System;

    public class BodyMassIndexCalculator
    {
        private int weight;
        private int heightInFeet;
        private int heightInInches;

        public BodyMassIndexCalculator(int weight, int heightInFeet, int heightInInches)
        {
            this.Weight = weight;
            this.HeightInFeet = heightInFeet;
            this.HeightInInches = heightInInches;
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                ValidateNotNegative(value, nameof(this.Weight));
                this.weight = value;
            }
        }

        public int HeightInFeet
        {
            get => this.heightInFeet;
            private set
            {
                ValidateNotNegative(value, nameof(this.HeightInFeet));
                this.heightInFeet = value;
            }
        }

        public int HeightInInches
        {
            get => this.heightInInches;
            private set
            {
                ValidateNotNegative(value, nameof(this.HeightInInches));
                this.heightInInches = value;
            }
        }

        public double CalculateBMI()
        {
            return (this.Weight * 703) / (Math.Pow((this.HeightInFeet * 12 + this.HeightInInches), 2));
        }

        public override string ToString()
        {
            return $"BMI: {this.CalculateBMI().ToString("F2")}";
        }

        private void ValidateNotNegative(int number, string type)
        {
            if (number < 0)
            {
                throw new Exception($"{type} cannot be negative");
            }
        }
    }
}