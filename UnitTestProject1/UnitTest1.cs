namespace UnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ClassLibrary1;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 6;
            Assert.AreEqual(a + b, 11);
        }

        [TestMethod]
        public void TestSum()
        {
            int result = Startup.SumIntegers(5, 10);
            Assert.AreEqual(result, 14);
        }
    }
}
