namespace PageObjects.Pages
{
    using System.Collections.Generic;
    using System.Linq;

    using OpenQA.Selenium;

    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver)
            : base(driver)
        {
        }

        public IReadOnlyCollection<IWebElement> Results => this.Driver.FindElements(By.TagName("article"));

        public ArticlePage OpenFirstResult()
        {
            if (this.Results.Count < 1)
            {
                throw new NoSuchElementException("There is no search results");
            }

            this.Results.FirstOrDefault(a => a.Displayed).Click();

            return new ArticlePage(this.Driver);
        }
    }
}
