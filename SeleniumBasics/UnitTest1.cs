namespace SeleniumBasics
{
    using System.IO;
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = this.GetChromeDriver();
        }

        [Test]
        public void SeleniumBaseTest()
        {
            this.driver.Navigate().GoToUrl("https://google.com");

            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Quit();
        }

        private IWebDriver GetChromeDriver()
        {
            var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return new ChromeDriver(outputDirectory);
        }
    }
}