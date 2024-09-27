using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai12
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int act = o.Largest(new int[] { 1, 2, 3, 4, 11 });
            int exp = 11;
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int act = o.Largest(new int[] { });
            int exp = ((Int32)Math.Pow(2, 31)) - 1;
            Assert.AreEqual(exp, act);
        }

    }
}
