namespace EndOfSectionExam
{
    using NUnit.Framework;
    using System;

    [Category("Trip")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMilesPerGallonCalculation()
        {
            var trip = new Trip("Balchik", 38.5, 13, 5);
            Assert.AreEqual(7.7, trip.CalculateMilesPerGallon(), 0.01);
        }

        [Test]
        public void TestCostPerMileCalculation()
        {
            var trip = new Trip("Sofia", 489, 89.31, 39);
            Assert.AreEqual(0.18, trip.CalculateCostPerMile(), 0.01);
        }
    }
}