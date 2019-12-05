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
                Assert.Pass();
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
                Assert.Pass(ex.Message);
            }
        }

        [Test]
        public void CustomerNumberPositiveTest()
        {
            try
            {
                var receipt = new Receipt(5, "10.12.2019", 2919, "Kamen Yosifov", "Varna, Bulgaria", "0888112233", 13, "Smart Watch", 98.50M, 1);
                Assert.Pass();
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
                Assert.Pass(ex.Message);
            }
        }
    }
}