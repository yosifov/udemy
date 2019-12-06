namespace EndOfSectionEightExam
{
    using System;
    using System.Text;

    public class ItemPrice
    {
        private decimal wholesalePrice;

        public ItemPrice(decimal price)
        {
            this.WholesalePrice = price;
        }

        public decimal WholesalePrice
        {
            get => this.wholesalePrice;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }

                this.wholesalePrice = value;
            }
        }

        public string MarkUpPrice()
        {
            var sb = new StringBuilder();
            var percentage = 5;
            sb.AppendLine("Percentage\tWholesale Price\tNew Price");
            while (percentage <= 10)
            {
                var newSalesPrice = this.WholesalePrice + (this.WholesalePrice * percentage * 0.01M);
                sb.AppendLine($"{percentage}%\t\t{this.WholesalePrice:F2}\t\t{newSalesPrice:F2}");
                percentage++;
            }

            return sb.ToString();
        }
    }
}
