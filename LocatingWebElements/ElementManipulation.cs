namespace LocatingWebElements
{
    using System;
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

            var captchaData = this.driver
                .FindElement(By.XPath("//span[@class='et_pb_contact_captcha_question']"))
                .Text
                .Split();

            int captchaResult = this.GetCaptchaResult(captchaData);

            var captchaInput = this.driver.FindElement(By.XPath("//input[@class='input et_pb_contact_captcha']"));

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

        private void HighlightElement(IWebElement element)
        {
            var js = (IJavaScriptExecutor)this.driver;
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: dashed; border-color: red;"";";
            js.ExecuteScript(highlightJavascript, new object[] { element });
        }

        private void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)this.driver).ExecuteScript(@"arguments[0].scrollIntoView(true);", element);
        }

        private int GetCaptchaResult(params string[] captchaData)
        {
            int firstNumber = int.Parse(captchaData[0]);
            int secondNumber = int.Parse(captchaData[2]);
            string @operator = captchaData[1];

            return @operator switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                _ => throw new ArgumentException("Invalid operator"),
            };
        }
    }
}
