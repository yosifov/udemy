namespace EndOfSectionElevenExam
{
    using NUnit.Framework;
    using System;

    [Category("Loans")]
    public class LoanTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAutoLoan()
        {
            var autoLoan = new AutoLoan(1, "Kamen", "Yosifov", 7.5, 12000, 4, 2000, "Opel", "Astra", "Silver");
            Console.WriteLine(autoLoan);
            Assert.AreEqual(2925, autoLoan.CalculateInterest());
        }

        [Test]
        public void TestHomeLoan()
        {
            var homeLoan = new HomeLoan(2, "Ivan", "Ivanov", 3.5, 210000, 30, "My Example Address", 2005, 98.5);
            Console.WriteLine(homeLoan);
            Assert.AreEqual(3010, homeLoan.CalculateInterest());
        }
    }
}