using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai09
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long output;
            o.Sum(-6, out output);
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long output;
            o.Sum(7, out output);
            Assert.AreEqual(4, output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long output;
            o.Sum(0, out output);
            Assert.AreEqual(1, output);
        }
    
}
}
