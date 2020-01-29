namespace PageObjects
{
    using NUnit.Framework;

    [TestFixture]
    [Category("Page Objects")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Order(1)]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}