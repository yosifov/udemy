namespace SectionNineCodingQuiz
{
    using NUnit.Framework;

    [Category("MathFunctions")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SquareRootTest()
        {
            Assert.AreEqual(3, MathFunctions.SquareRoot(9));
        }

        [Test]
        public void SumIntegers()
        {
            Assert.AreEqual(9, MathFunctions.Sum(5, 4));
        }

        [Test]
        public void SumDoubles()
        {
            Assert.AreEqual(13.12, MathFunctions.Sum(9.05, 4.07), 0.01);
        }

        [Test]
        public void SumDecimals()
        {
            Assert.AreEqual(10.45M, MathFunctions.Sum(5.40M, 5.05M));
        }
    }
}