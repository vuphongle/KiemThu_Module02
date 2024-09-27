using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai03
    {

        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod01()
        {
            bool result = o.primeCheck(11);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod02()
        {
            bool result = o.primeCheck(70);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod03()
        {
            Assert.ThrowsException<Exception>(() => o.primeCheck(-700));
        }

        [TestMethod]
        public void TestMethod04()
        {
            Assert.ThrowsException<Exception>(() => o.primeCheck(1200));
        }

        [TestMethod]
        public void TestMethod05()
        {
            bool result = o.primeCheck(0);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod06()
        {
            bool result = o.primeCheck(1000);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod07()
        {
            Assert.ThrowsException<Exception>(() => o.primeCheck(-1));
        }

        [TestMethod]
        public void TestMethod08()
        {
            Assert.ThrowsException<Exception>(() => o.primeCheck(1001));
        }
    }
}
