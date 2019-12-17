namespace HousingApplication
{
    using System.Text;

    public class SingleFamily : Housing
    {
        private decimal rentAmount;
        private double sizeInSqFeet;
        private int numberOfBedrooms;
        private int numberOfBathrooms;

        public SingleFamily(
            string address,
            string typeOfConstruction,
            int yearBuilt,
            decimal rentAmount,
            double sizeInSqFeet,
            int numberOfBedrooms,
            int numberOfBathrooms,
            bool hasPorch,
            bool hasGarage)
            : base(address, typeOfConstruction, yearBuilt)
        {
            this.RentAmount = rentAmount;
            this.SizeInSqFeet = sizeInSqFeet;
            this.NumberOfBedrooms = numberOfBedrooms;
            this.NumberOfBathrooms = numberOfBathrooms;
            this.HasPorch = hasPorch;
            this.HasGarage = hasGarage;
        }

        public decimal RentAmount
        {
            get => this.rentAmount;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.RentAmount));
                this.rentAmount = value;
            }
        }

        public double SizeInSqFeet
        {
            get => this.sizeInSqFeet;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.SizeInSqFeet));
                this.sizeInSqFeet = value;
            }
        }

        public int NumberOfBedrooms
        {
            get => this.numberOfBedrooms;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.NumberOfBedrooms));
                this.numberOfBedrooms = value;
            }
        }

        public int NumberOfBathrooms
        {
            get => this.numberOfBathrooms;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.NumberOfBathrooms));
                this.numberOfBathrooms = value;
            }
        }

        public bool HasPorch { get; private set; }

        public bool HasGarage { get; private set; }

        public override decimal ProjectedRentalAmt()
        {
            return this.RentAmount * 12;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Rent amount: {this.RentAmount:C}");
            sb.AppendLine($"Size in sq feet: {this.SizeInSqFeet}");
            sb.AppendLine($"Number of bedrooms: {this.NumberOfBedrooms}");
            sb.AppendLine($"Number of bathrooms: {this.NumberOfBathrooms}");
            sb.AppendLine($"Porch available: {this.HasPorch}");
            sb.AppendLine($"Garage available: {this.HasGarage}");

            return sb.ToString();
        }
    }
}
