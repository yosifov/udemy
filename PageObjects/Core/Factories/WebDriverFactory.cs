namespace PageObjects.Core.Factories
{
    using System;
    using System.IO;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    using PageObjects.Core.Enums;

    public class WebDriverFactory
    {
        public static IWebDriver Create(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    return new ChromeDriver(Directory.GetCurrentDirectory() + @"\Core\Drivers");
                default:
                    throw new ArgumentException("Invalid browser");
            }
        }
    }
}