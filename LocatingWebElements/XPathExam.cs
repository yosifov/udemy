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
    [Category("XPath Exam")]
    public class XPathExam
    {
        private IWebDriver driver;
        private IWebElement element;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            this.driver = this.GetWebDriver();
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            this.driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        public void ClickAnyRadioButton()
        {
            this.element = this.driver.FindElement(By.XPath("//input[@type='radio'][@name='gender'][@value='male']"));

            this.element.Click();

            Assert.That(this.element.Selected);
        }

        [Test]
        public void ClickOneCheckbox()
        {
            this.element = this.driver.FindElement(By.XPath("//input[@type='checkbox'][@name='vehicle'][@value='Bike']"));
            var checkBoxes = this.driver.FindElements(By.XPath("//input[@type='checkbox'][@name='vehicle']"));

            this.element.Click();

            int checkedCounter = 0;
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Selected)
                {
                    checkedCounter++;
                }
            }

            Assert.That(this.element.Selected);
            Assert.AreEqual(1, checkedCounter);
        }

        [Test]
        public void SelectAudiFromDropDown()
        {
            SelectElement select = new SelectElement(this.driver.FindElement(By.XPath("//select")));
            string selectValue = "audi";
            select.SelectByValue(selectValue);

            Assert.AreEqual("Audi", select.SelectedOption.Text);
        }

        [Test]
        public void OpenTabTwo()
        {
            this.element = this.driver.FindElement(By.XPath("//li[@class='et_pb_tab_1']//a"));
            this.element.Click();
            IWebElement tabActiveArea = this.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(@class, 'et_pb_tab et_pb_tab_1')]")));

            Assert.That(tabActiveArea.Displayed);
        }

        [Test]
        public void GetTableCellValue()
        {
            this.element = this.driver.FindElement(By.XPath("//table[@id='htmlTableId']//tr[2]//td[3]"));
            this.ScrollToElement(this.element);
            this.HighlightElement(this.element);
            Assert.AreEqual("$150,000+", this.element.Text);
        }

        [Test]
        public void HighlightElement()
        {
            this.element = this.driver.FindElement(By.XPath("//*[@class='et_pb_column et_pb_column_1_3 et_pb_column_10  et_pb_css_mix_blend_mode_passthrough']//h4"));
            this.ScrollToElement(this.element);
            this.HighlightElement(this.element);

            Assert.AreEqual("Highlight me", this.element.Text);
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
    }
}
