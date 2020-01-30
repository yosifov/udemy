namespace PageObjects.Tests
{
    using NUnit.Framework;

    using OpenQA.Selenium;

    using PageObjects.Core.Enums;
    using PageObjects.Core.Factories;
    using PageObjects.Pages;

    [TestFixture]
    [Category("Automation Search")]
    public class AutomationSearchTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = WebDriverFactory.Create(Browser.Chrome);
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        [TestCase("Complicated Page - Ultimate QA")]
        public void SearchShouldReturnCorrectResults(string expectedTitle)
        {
            var homePage = new HomePage(this.driver);
            homePage.Open();
            var searchPage = homePage.Search("complicated page");
            var articlePage = searchPage.OpenFirstResult();

            Assert.AreEqual(expectedTitle, articlePage.Title);
        }

        [Test]
        [TestCase("https://ultimateqa.com/complicated-page", "Complicated Page - Ultimate QA")]
        public void ComplicatedPageTest(string pageUrl, string pageTitle)
        {
            var complicatedPage = new ArticlePage(this.driver)
            {
                Url = pageUrl
            };

            complicatedPage.Open();

            Assert.AreEqual(pageTitle, complicatedPage.Title);
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Close();
            this.driver.Quit();
        }
    }
}
