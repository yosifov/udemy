namespace EndOfSectionTwelveExam
{
    using NUnit.Framework;

    [Category("Page Objects")]
    public class PageObjectTests
    {
        [Test]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual(pageObject1.PageName, "Page Name 1");
        }

        [Test]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual(pageObject2.PageName, "Page Name 2");
        }
    }
}