namespace EndOfCourseExam
{
    using System;
    using NUnit.Framework;

    [Category("Page Exam")]
    public class ExamTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComplicatedPageTest()
        {
            var complicatedPage = new ComplicatedPage();
            Assert.AreEqual("Complicated page", complicatedPage.PageName);
        }

        [Test]
        public void SectionOfRandomStuffTest()
        {
            var sectionOfRandomStuff = new SectionOfRandomStuff();
            sectionOfRandomStuff.FillForm();
        }

        [Test]
        public void SectionOfButtonsTest()
        {
            try
            {
                var sectionOfButtons = new SectionOfButtons(new Element());
                sectionOfButtons.Button.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}