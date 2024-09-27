using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai03
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.primeCheck(11);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.primeCheck(70);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            Assert.ThrowsException<Exception>(() => o.primeCheck(-700));
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            Assert.ThrowsException<Exception>(() => o.primeCheck(1200));
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.primeCheck(0);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.primeCheck(1000);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            Assert.ThrowsException<Exception>(() => o.primeCheck(-1));
        }

        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            Assert.ThrowsException<Exception>(() => o.primeCheck(1001));
        }
    }
}
