namespace MidtermExam
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Receipt
    {
        private int number;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerName;
        private string customerAddress;
        private string customerPhoneNumber;
        private int itemNumber;
        private string itemDescription;
        private decimal unitPrice;
        private int quantityPurchased;

        public Receipt(int receiptNumber, 
            string dateOfPurchase, 
            int customerNumber, 
            string customerName, 
            string customerAddress, 
            string customerPhoneNumber, 
            int itemNumber, 
            string itemDescription, 
            decimal unitPrice, 
            int quantityPurchased)
        {
            this.Number = receiptNumber;
            this.DateOfPurchase = dateOfPurchase;
            this.CustomerNumber = customerNumber;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.CustomerPhoneNumber = customerPhoneNumber;
            this.ItemNumber = itemNumber;
            this.ItemDescription = itemDescription;
            this.UnitPrice = unitPrice;
            this.QuantityPurchased = quantityPurchased;
        }

        public int Number
        {
            get => this.number;
            private set
            {
                ValidateGreaterThanZero(value, nameof(this.Number));
                this.number = value;
            }
        }

        public string DateOfPurchase
        {
            get => this.dateOfPurchase;
            private set
            {
                ValidateNotNull(value, nameof(this.DateOfPurchase));
                this.dateOfPurchase = value;
            }
        }

        public int CustomerNumber
        {
            get => this.customerNumber;
            private set
            {
                ValidateGreaterThanZero(value, nameof(this.CustomerNumber));
                this.customerNumber = value;
            }
        }

        public string CustomerName
        {
            get => this.customerName;
            private set
            {
                ValidateNotNull(value, nameof(this.CustomerName));
                this.customerName = value;
            }
        }

        public string CustomerAddress
        {
            get => this.customerAddress;
            private set
            {
                ValidateNotNull(value, nameof(this.CustomerAddress));
                this.customerAddress = value;
            }
        }

        public string CustomerPhoneNumber
        {
            get => this.customerPhoneNumber;
            private set
            {
                ValidateNotNull(value, nameof(this.CustomerPhoneNumber));
                this.customerPhoneNumber = value;
            }
        }

        public int ItemNumber
        {
            get => this.itemNumber;
            private set
            {
                if (value <= 0 || value > 9999)
                {
                    throw new ArgumentException("Item number should be between 0 and 10000");
                }

                this.itemNumber = value;
            }
        }

        public string ItemDescription
        {
            get => this.itemDescription;
            private set
            {
                ValidateNotNull(value, nameof(this.ItemDescription));
                this.ItemDescription = value;
            }
        }

        public decimal UnitPrice
        {
            get => this.unitPrice;
            private set
            {
                if (value <= 0 || value > 9999)
                {
                    throw new ArgumentException("Unit price should be between 0 and 10000");
                }

                this.unitPrice = value;
            }
        }

        public int QuantityPurchased
        {
            get => this.quantityPurchased;
            private set
            {
                ValidateGreaterThanZero(value, nameof(this.QuantityPurchased));
                this.quantityPurchased = value;
            }
        }

        public decimal CalculateTotalCost()
        {
            return this.QuantityPurchased * this.UnitPrice;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Customer {this.CustomerName}");
            sb.AppendLine($"Phone: {this.CustomerPhoneNumber}");
            sb.AppendLine($"Total purchases: {this.CalculateTotalCost().ToString("F2")} BGN");
            return sb.ToString();
        }

        private static void ValidateGreaterThanZero(int number, string type)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{type} cannot be less than or equal to zero");
            }
        }

        private static void ValidateNotNull(string text, string type)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException($"{type} cannot be empty");
            }
        }
    }
}
