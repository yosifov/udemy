namespace HousingApplication
{
    using System.Text;

    public class Housing
    {
        private string address;
        private string typeOfConstruction;
        private int yearBuilt;

        public Housing(string address, string typeOfConstruction, int yearBuilt)
        {
            this.Address = address;
            this.TypeOfConstruction = typeOfConstruction;
            this.YearBuilt = yearBuilt;
        }

        public string Address
        {
            get => this.address;
            protected set
            {
                Validator.ValidateNotNull(value, nameof(this.Address));

                this.address = value;
            }
        }

        public string TypeOfConstruction
        {
            get => this.typeOfConstruction;
            protected set
            {
                Validator.ValidateNotNull(value, nameof(this.TypeOfConstruction));

                this.typeOfConstruction = value;
            }
        }

        public int YearBuilt
        {
            get => this.yearBuilt;
            protected set
            {
                Validator.ValidateNotNegative(value, nameof(this.YearBuilt));

                this.yearBuilt = value;
            }
        }

        public virtual decimal ProjectedRentalAmt()
        {
            return 0;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Address: {this.Address}");
            sb.AppendLine($"Type of construction: {this.TypeOfConstruction}");
            sb.AppendLine($"Year built: {this.YearBuilt}");
            sb.Append($"Protected Rental Amount: {this.ProjectedRentalAmt():C}");

            return sb.ToString();
        }
    }
}
