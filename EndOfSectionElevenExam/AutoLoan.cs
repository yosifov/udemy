namespace EndOfSectionElevenExam
{
    public class AutoLoan : Loan
    {
        private int yearBuild;
        private string make;
        private string model;
        private string color;

        public AutoLoan(int loanNumber, string customerFistName, string customerLastName, double interestRate, 
            decimal loanAmount, int yearsInTerm, int yearBuild, string make, string model, string color) 
            : base(loanNumber, customerFistName, customerLastName, interestRate, loanAmount, yearsInTerm)
        {
            this.YearBuild = yearBuild;
            this.Make = make;
            this.Model = model;
            this.Color = color;
        }

        public int YearBuild
        {
            get => this.yearBuild;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.YearBuild));
                this.yearBuild = value;
            }
        }

        public string Make
        {
            get => this.make;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Make));
                this.make = value;
            }
        }

        public string Model
        {
            get => this.model;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Model));
                this.model = value;
            }
        }

        public string Color
        {
            get => this.color;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Color));
                this.color = value;
            }
        }

        public override decimal CalculateInterest()
        {
            decimal result = (((decimal)this.InterestRate * 0.01M) / ((decimal)this.YearsInTerm / 12M)) * (this.LoanAmount + 1000);
            return result;
        }

    }
}
