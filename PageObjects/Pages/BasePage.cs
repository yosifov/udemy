namespace PageObjects.Pages
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;

    public abstract class BasePage
    {
        private const int ExplicitWaitTime = 5;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(ExplicitWaitTime));
            this.Actions = new Actions(this.Driver);
        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; protected set; }

        public Actions Actions { get; }
    }
}
