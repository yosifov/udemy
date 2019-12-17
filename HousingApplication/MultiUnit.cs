namespace HousingApplication
{
    using System.Text;

    public class MultiUnit : Housing, IUnits
    {
        private string complexName;
        private int numberOfUnits;
        private decimal rentAmountPerUnit;

        public MultiUnit(string address, string typeOfConstruction, int yearBuilt, string complexName, int numberOfUnits, decimal rentAmountPerUnit)
            : base(address, typeOfConstruction, yearBuilt)
        {
            this.ComplexName = complexName;
            this.NumberOfUnits = numberOfUnits;
            this.RentAmountPerUnit = rentAmountPerUnit;
        }

        public string ComplexName
        {
            get => this.complexName;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.ComplexName));
                this.complexName = value;
            }
        }

        public int NumberOfUnits
        {
            get => this.numberOfUnits;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.NumberOfUnits));
                this.numberOfUnits = value;
            }
        }

        public decimal RentAmountPerUnit
        {
            get => this.rentAmountPerUnit;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.RentAmountPerUnit));
                this.rentAmountPerUnit = value;
            }
        }

        public int GetNumUnits()
        {
            return this.NumberOfUnits;
        }

        public override decimal ProjectedRentalAmt()
        {
            return this.RentAmountPerUnit * this.NumberOfUnits * 12;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Complex name: {this.ComplexName}");
            sb.AppendLine($"Number of units: {this.NumberOfUnits}");
            sb.Append($"Rent amount per unit: {this.RentAmountPerUnit:C}");

            return sb.ToString();
        }
    }
}
