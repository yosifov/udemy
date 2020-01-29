namespace PageObjects.Pages
{
    using OpenQA.Selenium;

    public class ArticlePage : BasePage
    {
        public ArticlePage(IWebDriver driver) 
            : base(driver)
        {
        }

        public string Title => this.Driver.Title;
    }
}
