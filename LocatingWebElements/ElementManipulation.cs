namespace LocatingWebElements
{
    using System;
    using System.Data;
    using System.IO;
    using System.Reflection;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    [TestFixture]
    [Category("Element Manipulation")]
    public class ElementManipulation
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            this.driver = this.GetWebDriver();
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        public void FillOutFormWithMathCaptcha()
        {
            var input = this.driver.FindElement(By.Id("et_pb_contact_name_1"));
            input.Clear();
            input.SendKeys("Kamen Yosifov");

            var textarea = this.driver.FindElement(By.Id("et_pb_contact_message_1"));
            textarea.Clear();
            textarea.SendKeys("My message");

            var captchaQuestion = this.driver.FindElement(By.ClassName("et_pb_contact_captcha_question"));
            var table = new DataTable();
            int captchaResult = (int)table.Compute(captchaQuestion.Text, "");
            var captchaInput = this.driver.FindElement(By.XPath("//input[@class='input et_pb_contact_captcha']"));
            captchaInput.Clear();
            captchaInput.SendKeys(captchaResult.ToString());

            var submit = this.driver.FindElement(By.XPath(@"//div[contains(@class, 'et_pb_column_1_2 et_pb_column_1')]//button[@name='et_builder_submit_button']"));
            submit.Click();

            this.wait.Until(d => d.FindElement(By.XPath("//div[@class='et-pb-contact-message']//p")).Displayed);
            var submitMessage = this.driver.FindElement(By.XPath("//div[@class='et-pb-contact-message']//p"));

            Assert.AreEqual("Success", submitMessage.Text);
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
