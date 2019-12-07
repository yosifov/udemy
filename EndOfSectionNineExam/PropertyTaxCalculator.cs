namespace EndOfSectionNineExam
{
    using System;
    using System.Text;

    public class PropertyTaxCalculator
    {
        private const double IncreasePercentage = 2.7;
        private const double MillageRate = 10.03;
        private const double Exemption = 25000;
        private string propertyAddress;
        private decimal lastYearAssessedValue;

        public PropertyTaxCalculator(string address, decimal lastYearAssessedValue)
        {
            this.PropertyAddress = address;
            this.LastYearAssessedValue = lastYearAssessedValue;
        }

        public string PropertyAddress
        {
            get => this.propertyAddress;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Property address cannot be empty");
                }

                this.propertyAddress = value;
            }
        }

        public decimal LastYearAssessedValue
        {
            get => this.lastYearAssessedValue;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Property Assessed Value cannot be negative or zero");
                }

                this.lastYearAssessedValue = value;
            }
        }

        public decimal CalculateThisYearAssessedValue()
        {
            decimal result = this.LastYearAssessedValue + (this.LastYearAssessedValue * (decimal)IncreasePercentage * 0.01M);
            return result;
        }

        public decimal CalculateTaxableValue()
        {
            decimal result = this.CalculateThisYearAssessedValue() - (decimal)Exemption;
            if (result > 0)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculateTaxesDue()
        {
            decimal taxableValue = this.CalculateTaxableValue();
            return (taxableValue / 1000) * (decimal)MillageRate;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Property Address: {this.PropertyAddress}");
            sb.AppendLine($"Last Year Assessed Value: {this.LastYearAssessedValue:C}");
            sb.AppendLine($"Current Assessed Value: {this.CalculateThisYearAssessedValue():C}");
            sb.AppendLine($"Exemption: {Exemption:C}");
            sb.AppendLine($"Taxable Value: {this.CalculateTaxableValue():C}");
            sb.AppendLine($"Millage Rate(per $1000): {MillageRate:C}");
            sb.Append($"Taxes Due: {this.CalculateTaxesDue():C}");
            return sb.ToString();
        }
    }
}
