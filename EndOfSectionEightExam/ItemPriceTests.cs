namespace EndOfSectionEightExam
{
    using NUnit.Framework;
    using System;

    [Category("ItemPrice")]
    public class ItemPriceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPrice()
        {
            var itemPrice = new ItemPrice(143.5M);
            Console.WriteLine(itemPrice.MarkUpPrice());
            Assert.NotNull(itemPrice.MarkUpPrice());
        }
    }
}