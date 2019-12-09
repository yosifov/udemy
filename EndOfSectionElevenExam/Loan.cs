using System.Text;

namespace EndOfSectionElevenExam
{
    public abstract class Loan
    {
        private int loanNumber;
        private string customerFirstName;
        private string customerLastName;
        private double interestRate;
        private decimal loanAmount;
        private int yearsInTerm;

        public Loan(int loanNumber, string customerFistName, string customerLastName, double interestRate, decimal loanAmount,
            int yearsInTerm)
        {
            this.LoanNumber = loanNumber;
            this.CustomerFirstName = customerFistName;
            this.CustomerLastName = customerLastName;
            this.InterestRate = interestRate;
            this.LoanAmount = loanAmount;
            this.YearsInTerm = yearsInTerm;
        }

        public int LoanNumber
        {
            get => this.loanNumber;
            protected set
            {
                Validator.ValidateNotNegative(value, nameof(this.LoanNumber));
                this.loanNumber = value;
            }
        }

        public string CustomerFirstName
        {
            get => this.customerFirstName;
            protected set
            {
                Validator.ValidateNotNull(value, nameof(this.CustomerFirstName));
                this.customerFirstName = value;
            }
        }

        public string CustomerLastName
        {
            get => this.customerLastName;
            protected set
            {
                Validator.ValidateNotNull(value, nameof(this.CustomerLastName));
                this.customerLastName = value;
            }
        }

        public double InterestRate
        {
            get => this.interestRate;
            protected set
            {
                Validator.ValidateNotNegative(value, nameof(this.InterestRate));
                this.interestRate = value;
            }
        }

        public decimal LoanAmount
        {
            get => this.loanAmount;
            protected set
            {
                Validator.ValidateNotNegative(value, nameof(this.LoanAmount));
                this.loanAmount = value;
            }
        }

        public int YearsInTerm
        {
            get => this.yearsInTerm;
            protected set
            {
                Validator.ValidateNotNegative(value, nameof(this.YearsInTerm));
                this.yearsInTerm = value;
            }
        }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Loan number: {this.LoanNumber}");
            sb.AppendLine($"Customer: {this.CustomerFirstName} {this.CustomerLastName}");
            sb.AppendLine($"Loan amount: {this.LoanAmount:C}");
            sb.Append($"Loan interest: {this.CalculateInterest():C}");
            return sb.ToString();
        }
    }
}
