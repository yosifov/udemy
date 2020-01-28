namespace LocatingWebElements
{
    using System;
    using System.IO;
    using System.Reflection;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

    [TestFixture]
    [Category("Proper Synchronization")]
    public class ProperSynchronizationQuiz
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            this.driver = this.GetWebDriver();
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/");
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        public void ProperSynchronizationTest()
        {
            this.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='post-212577']//img")));

            this.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='menu-item-587']//a"))).Click();

            this.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("logo")));

            this.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Big page with many elements"))).Click();

            this.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='tve_image wp-image-4039']")));

            Assert.AreEqual("Complicated Page - Ultimate QA", this.driver.Title);
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
