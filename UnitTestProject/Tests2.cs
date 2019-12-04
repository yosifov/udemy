namespace UnitTestProject
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [TestCategory("Quiz")]
    public class Tests2
    {
        [TestMethod]
        public void FirstTest()
        {
            int a = 1;
            int b = 1;
            Assert.AreEqual(2, a + b);
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.Fail("This test automaticaly fails");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ThirdTest()
        {
            int a = 10;
            int b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}
