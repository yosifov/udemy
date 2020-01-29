namespace PageObjects.Pages
{
    using OpenQA.Selenium;

    using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string Url => "https://ultimateqa.com/";

        public IWebElement SearchButton => this.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("et_top_search")));

        public IWebElement SearchInput => this.Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("et-search-field")));

        public void Open()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
        }

        public SearchPage Search(string searchString)
        {
            this.SearchButton.Click();
            this.SearchInput.SendKeys(searchString);
            this.SearchInput.Submit();

            return new SearchPage(this.Driver);
        }
    }
}
