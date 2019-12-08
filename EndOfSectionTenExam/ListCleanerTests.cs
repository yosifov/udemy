namespace EndOfSectionTenExam
{
    using NUnit.Framework;
    using System.Collections;

    [Category("List Cleaner")]
    public class ListCleanerTests
    {
        private ArrayList currentList;

        [SetUp]
        public void Setup()
        {
            this.currentList = new ArrayList()
            {
                "Someday",
                2,
                "app",
                13.5,
                "red",
                8,
                99,
                "6",
                "Meatball soup",
                18M,
                "pieces",
                "14"
            };
        }

        [Test]
        public void TestGetNumericalListSum()
        {
            var listCleaner = new ListCleaner(this.currentList);
            listCleaner.CleanList();
            Assert.AreEqual(147, listCleaner.GetNumericalListSum());
        }
    }
}