namespace EndOfSectionNineExam
{
    using NUnit.Framework;
    using System;

    [Category("Property Tax Calculator")]
    public class PropertyTaxCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateThisYearAssessedValueTest()
        {
            var taxCalculator = new PropertyTaxCalculator("Gladston 4", 37100);
            decimal thisYearAssessedValue = taxCalculator.CalculateThisYearAssessedValue();
            Assert.AreEqual(38101.7, thisYearAssessedValue);
        }

        [Test]
        public void CalculateTaxableValueTest()
        {
            var taxCalculator = new PropertyTaxCalculator("Yavorov 16", 25400);
            decimal taxableValue = taxCalculator.CalculateTaxableValue();
            Assert.AreEqual(1085.8, taxableValue);
        }

        [Test]
        public void CalculateTaxesDueTest()
        {
            var taxCalculator = new PropertyTaxCalculator("Yavorov 16", 154340);
            decimal taxesDue = taxCalculator.CalculateTaxesDue();
            Assert.AreEqual(1339.08, Math.Round(taxesDue, 2));
        }

        [Test]
        public void ToStringTest()
        {
            var taxCalculator = new PropertyTaxCalculator("Yavorov 16", 54340);
            Console.WriteLine(taxCalculator);
        }
    }
}