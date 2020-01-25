namespace LocatingWebElements
{
    using System.IO;
    using System.Reflection;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestFixture]
    [Category("Selenium Elements")]
    public class LocateElementTests
    {
        private IWebDriver driver;
        private IWebElement element;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [SetUp]
        public void SetUp()
        {
            this.driver = this.GetWebDriver();
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        public void LocateElementById()
        {
            this.element = this.driver.FindElement(By.Id("simpleElementsLink"));

            this.element.Click();

            Assert.AreEqual("Link success - Ultimate QA", this.driver.Title);
        }

        [Test]
        public void LocateElementByLinkText()
        {
            this.element = this.driver.FindElement(By.LinkText("Click this link"));

            this.element.Click();

            Assert.AreEqual("Link success - Ultimate QA", this.driver.Title);
        }

        [Test]
        public void LocateElementByName()
        {
            this.element = this.driver.FindElement(By.Name("clickableLink"));

            this.element.Click();

            Assert.AreEqual("Link success - Ultimate QA", this.driver.Title);
        }

        [Test]
        public void LocateElementByCssSelector()
        {
            this.element = this.driver.FindElement(By.CssSelector("#simpleElementsLink"));

            this.element.Click();

            Assert.AreEqual("Link success - Ultimate QA", this.driver.Title);
        }

        [Test]
        public void LocateElementByXPath()
        {
            this.element = this.driver.FindElements(By.XPath("//*[@id='button1'][contains(text(), 'Xpath Button 1')]"))[1];

            this.element.Click();

            Assert.AreEqual("Button success - Ultimate QA", this.driver.Title);
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Close();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
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