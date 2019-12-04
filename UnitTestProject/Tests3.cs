using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Part3")]
    public class Tests3
    {
        private int a;
        private int b;

        [TestInitialize]
        public void RunBeforeEverytest()
        {
            a = 1;
            b = 2;
        }

        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(3, a + b);
        }
    }
}
