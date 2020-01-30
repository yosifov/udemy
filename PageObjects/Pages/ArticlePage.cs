namespace PageObjects.Pages
{
    using System;

    using OpenQA.Selenium;

    public class ArticlePage : BasePage
    {
        public ArticlePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string Title => this.Driver.Title;

        public string Url { get; set; }

        public void Open()
        {
            if (this.Url == null)
            {
                throw new ArgumentNullException("Url for the page is not set");
            }

            this.Driver.Navigate().GoToUrl(this.Url);
        }
    }
}
