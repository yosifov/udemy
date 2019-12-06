namespace MidtermExam
{
    using NUnit.Framework;
    using System;

    [Category("Receipt")]
    public class ReceiptTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReceiptNumberPositiveTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 2919, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 13, "Smart Watch", 98.50M, 1);
                Assert.AreEqual(5, receipt.Number);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void ReceiptNumberNegativeTest()
        {
            try
            {
                var receipt = new Receipt(-10, "10.12.2019", 2919, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 13, "Smart Watch", 98.50M, 1);
                Assert.Fail($"Receipt number validation didn't pass! Receipt number stored: {receipt.Number}");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Number cannot be less than or equal to zero", ex.Message);
            }
        }

        [Test]
        public void CustomerNumberPositiveTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 2, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 13, "Smart Watch", 98.50M, 1);
                Assert.AreEqual(2, receipt.CustomerNumber);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void CustomerNumberNegativeTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 0, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 13, "Smart Watch", 98.50M, 1);
                Assert.Fail($"Customer number validation didn't pass! Customer number stored: {receipt.CustomerNumber}");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("CustomerNumber cannot be less than or equal to zero", ex.Message);
            }
        }

        [Test]
        public void ItemNumberPositiveTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 2, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 2, "Smart Watch", 98.50M, 1);
                Assert.AreEqual(2, receipt.ItemNumber);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void ItemNumberNegativeTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 3, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", -3, "Smart Watch", 98.50M, 1);
                Assert.Fail($"Item number validation didn't pass! Item number stored: {receipt.ItemNumber}");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Item number should be between 0 and 10000", ex.Message);
            }
        }

        [Test]
        public void UnitPricePositiveTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 4, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 13, "Smart Watch", 1198.50M, 1);
                Assert.AreEqual(1198.50M, receipt.UnitPrice);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void UnitPriceNegativeTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 5, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 14, "Smart Watch", 11198.50M, 1);
                Assert.Fail($"Unit price validation didn't pass! Unit price stored: {receipt.UnitPrice}");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Unit price should be between 0 and 10000", ex.Message);
            }
        }

        [Test]
        public void QuantityPurchasedPositiveTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 6, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 15, "Smart Watch", 98.50M, 2);
                Assert.AreEqual(2, receipt.QuantityPurchased);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void QuantityPurchasedNegativeTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 7, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 16, "Smart Watch", 98.50M, 0);
                Assert.Fail($"Quantity purchased validation didn't pass! Quantity purchased stored: {receipt.QuantityPurchased}");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("QuantityPurchased cannot be less than or equal to zero", ex.Message);
            }
        }
    }
}