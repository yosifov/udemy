namespace SectionElevenCodingQuiz
{
    using System;
    using System.Text;

    public abstract class Ticket
    {
        private string number;
        private decimal price;
        private int seatNumber;

        public Ticket(string number, decimal price, int seatNumber)
        {
            this.Number = number;
            this.Price = price;
            this.SeatNumber = seatNumber;
        }

        public string Number
        {
            get => this.number;
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Ticket number cannot be empty");
                }

                this.number = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            protected set
            {
                ValidateNotNegative(value, nameof(this.Price));
                this.price = value;
            }
        }

        public int SeatNumber
        {
            get => this.seatNumber;
            protected set
            {
                ValidateNotNegative(value, nameof(this.SeatNumber));
                this.seatNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Ticket number: {this.Number}");
            sb.AppendLine($"Ticket price: {this.Price:C}");
            sb.Append($"Ticket seat number: {this.SeatNumber}");
            return sb.ToString();
        }

        private static void ValidateNotNegative(int number, string type)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }

        private static void ValidateNotNegative(decimal number, string type)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }
    }
}
