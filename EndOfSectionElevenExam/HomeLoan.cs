namespace EndOfSectionElevenExam
{
    public class HomeLoan : Loan
    {
        private string address;
        private int yearBuild;
        private double squareFootage;

        public HomeLoan(int loanNumber, string customerFistName, string customerLastName, 
            double interestRate, decimal loanAmount, int yearsInTerm, string address, int yearBuild, double squareFootage) 
            : base(loanNumber, customerFistName, customerLastName, interestRate, loanAmount, yearsInTerm)
        {
            this.Address = address;
            this.YearBuild = yearBuild;
            this.SquareFootage = squareFootage;
        }

        public string Address
        {
            get => this.address;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Address));
                this.address = value;
            }
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

        public double SquareFootage
        {
            get => this.squareFootage;
            private set
            {
                Validator.ValidateNotNegative(value, nameof(this.SquareFootage));
                this.squareFootage = value;
            }
        }

        public override decimal CalculateInterest()
        {
            decimal result = (((decimal)this.InterestRate * 0.01M) / ((decimal)this.YearsInTerm / 12M)) * (this.LoanAmount + 5000);
            return result;
        }
    }
}
