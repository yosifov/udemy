namespace MathOperators
{
    using NUnit.Framework;
    using System;

    [Category("Math Operations")]
    public class Tests
    {
        private double tempInFahrenheit;
        private double tempInCelsium;

        [SetUp]
        public void Setup()
        {
            tempInFahrenheit = 57;
            tempInCelsium = 12.5;
        }

        [Test]
        public void ConvertFahrenheitToCelsium()
        {
            tempInCelsium = (tempInFahrenheit - 32) / 1.8;
            Console.WriteLine($"The temp in F {tempInFahrenheit} is {tempInCelsium} in C");
            Assert.AreEqual(13.889, tempInCelsium, 0.001);
        }

        [Test]
        public void ConvertCelsiumTOFahrenheit()
        {
            tempInFahrenheit = (tempInCelsium * 1.8) + 32;
            Console.WriteLine($"The temp in C {tempInCelsium} is {tempInFahrenheit} in F");
            Assert.AreEqual(54.5, tempInFahrenheit);
        }
    }
}