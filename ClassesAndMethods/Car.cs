namespace ClassesAndMethods
{
    using System;

    public class Car
    {
        private string color;
        int numberOfDoors;

        public Car(string color, int numberOfDoors, bool convertable)
        {
            this.Color = color;
            this.NumberOfDoors = numberOfDoors;
            this.IsConvertible = convertable;
        }

        public string Color
        {
            get => this.color;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Car color cannot be null");
                }

                this.color = value;
            }
        }

        public int NumberOfDoors
        {
            get => this.numberOfDoors;
            private set
            {
                if (value > 4)
                {
                    throw new ArgumentException("Car cannot have more than 4 doors");
                }

                this.numberOfDoors = value;
            }
        }

        public bool IsConvertible { get; private set; }
    }
}
