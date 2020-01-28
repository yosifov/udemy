namespace UserInteractions
{
    using System;
    using System.IO;
    using System.Reflection;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;

    using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

    [TestFixture]
    [Category("Interactions")]
    public class Interactions
    {
        private IWebDriver driver;
        private Actions actions;
        private IWait<IWebDriver> wait;

        [SetUp]
        public void Setup()
        {
            this.driver = this.GetWebDriver();
            this.actions = new Actions(this.driver);
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        public void DragAndDropTest()
        {
            this.driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            this.wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

            var sourceElement = this.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("draggable")));
            var targetElement = this.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("droppable")));

            this.actions.DragAndDrop(sourceElement, targetElement).Perform();

            Assert.AreEqual("Dropped!", targetElement.Text);
        }

        [Test]
        public void DragAndDropWithBuildTest()
        {
            this.driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            this.wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

            var sourceElement = this.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("draggable")));
            var targetElement = this.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("droppable")));

            var drag = this.actions
                .ClickAndHold(sourceElement)
                .MoveToElement(targetElement)
                .Release(targetElement)
                .Build();

            drag.Perform();

            Assert.AreEqual("Dropped!", targetElement.Text);
        }

        [Test]
        public void DragAndDropQuiz()
        {
            this.driver.Navigate().GoToUrl("http://www.pureexample.com/jquery-ui/basic-droppable.html");
            this.wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.Id("ExampleFrame-94")));

            this.ScrollToElement(this.driver.FindElement(By.Id("form1")));

            var sourceElement = this.driver.FindElement(By.XPath("//*[@class='square ui-draggable']"));
            var targetElement = this.driver.FindElement(By.XPath("//*[@class='squaredotted ui-droppable']"));

            this.actions.DragAndDrop(sourceElement, targetElement).Perform();

            var successMessage = this.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("info")));

            Assert.AreEqual("dropped!", successMessage.Text);
        }

        [Test]
        public void KeysTest()
        {
            this.driver.Navigate().GoToUrl("https://google.com");

            this.actions.KeyDown(Keys.Control).KeyDown(Keys.Shift).SendKeys("j").Perform();
            this.actions.KeyUp(Keys.Control).KeyUp(Keys.Shift).Perform();
        }

        [Test]
        public void DragAndDropWithHtmlFiveQuiz()
        {
            this.driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/drag_and_drop");
            var boxA = this.driver.FindElement(By.Id("column-a"));
            var boxB = this.driver.FindElement(By.Id("column-b"));

            this.DragDropHtmlFive("$('#column-a').simulateDragDrop({ dropTarget: '#column-b' });");

            Assert.AreEqual("A", boxB.Text);
            Assert.AreEqual("B", boxA.Text);
        }

        [Test]
        public void DrawOnACanvasTest()
        {
            this.driver.Navigate().GoToUrl("http://compendiumdev.co.uk/selenium/gui_user_interactions.html");
            var canvas = this.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("canvas")));

            this.actions.ClickAndHold(canvas)
                .MoveByOffset(1, 1)
                .MoveByOffset(1, 0)
                .MoveByOffset(0, 1)
                .MoveByOffset(2, 1)
                .MoveByOffset(1, 2)
                .MoveByOffset(2, 2)
                .MoveByOffset(1, 1)
                .MoveByOffset(1, 0)
                .MoveByOffset(0, 1)
                .MoveByOffset(2, 1)
                .MoveByOffset(1, 2)
                .MoveByOffset(2, 2)
                .MoveByOffset(1, 1)
                .MoveByOffset(1, 0)
                .MoveByOffset(0, 1)
                .MoveByOffset(2, 1)
                .MoveByOffset(1, 2)
                .MoveByOffset(2, 2)
                .MoveByOffset(1, 1)
                .MoveByOffset(1, 0)
                .MoveByOffset(0, 1)
                .MoveByOffset(2, 1)
                .MoveByOffset(1, 2)
                .MoveByOffset(2, 2)
                .Release()
                .Perform();

            var keyeventslist = this.driver
                .FindElement(By.Id("keyeventslist"))
                .FindElements(By.TagName("li"));

            Assert.AreEqual(24, keyeventslist.Count);
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Close();
            this.driver.Quit();
        }

        private IWebDriver GetWebDriver()
        {
            var pathToDriver = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return new ChromeDriver(pathToDriver);
        }

        private void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)this.driver).ExecuteScript(@"arguments[0].scrollIntoView(true);", element);
        }

        private void DragDropHtmlFive(string locatorsFromTo)
        {
            var pathToJs = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dragScript = File.ReadAllText(pathToJs + @"\drag.js");

            IJavaScriptExecutor js = (IJavaScriptExecutor)this.driver;
            js.ExecuteScript(dragScript + locatorsFromTo);
        }
    }
}