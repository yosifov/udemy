namespace LocatingWebElements
{
    using System.IO;
    using System.Reflection;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestFixture]
    [Category("Element Interrogation")]
    public class ElementInterrogationQuiz
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = this.GetWebDriver();
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        public void ElementInterogation()
        {
            var button = this.driver.FindElement(By.XPath("//div[@class='et_pb_row et_pb_row_0']//button[@id='button1']"));

            Assert.AreEqual("submit", button.GetAttribute("type"));

            Assert.AreEqual("normal", button.GetCssValue("letter-spacing"));

            Assert.That(button.Displayed);

            Assert.That(button.Enabled);

            Assert.That(!button.Selected);

            Assert.AreEqual("Click Me!", button.Text);

            Assert.AreEqual("button", button.TagName);

            Assert.AreEqual(24, button.Size.Height);

            Assert.That(button.Location.X == 135 && button.Location.Y == 242);
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
