namespace LocatingWebElements
{
    using System.IO;
    using System.Reflection;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestFixture]
    [Category("Navigation Quiz")]
    public class NavigationQuiz
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = this.GetWebDriver();
        }

        [Test]
        public void GoToHomePage()
        {
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/");

            Assert.AreEqual("Home - Ultimate QA", this.driver.Title);
        }

        [Test]
        public void GoToAutomationPage()
        {
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/automation");

            Assert.AreEqual("Automation Practice - Ultimate QA", this.driver.Title);
        }

        [Test]
        public void GoToComplicatedPage()
        {
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/automation");

            var element = this.driver.FindElement(By.XPath("//a[contains(@href, '/complicated-page')]"));
            element.Click();

            Assert.AreEqual("Complicated Page - Ultimate QA", this.driver.Title);

            this.driver.Navigate().Back();

            Assert.AreEqual("Automation Practice - Ultimate QA", this.driver.Title);
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Quit();
        }

        private IWebDriver GetWebDriver()
        {
            var pathToDriver = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return new ChromeDriver(pathToDriver);
        }
    }
}
