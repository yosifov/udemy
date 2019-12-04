namespace UnitTestProject
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Text;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 5;
            var b = 10;
            Assert.AreEqual(15, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 1;
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod3()
        {
            int input = int.Parse(Console.ReadLine());

            if (input > 5)
            {
                throw new ArgumentException("Input cannot be higher than 5");
            }
        }
    }
}
