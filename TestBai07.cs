using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai07
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            float x1, x2;
            o.SolveQuadratic(0, 0, 0, out x1, out x2);
            Assert.IsTrue(float.IsNaN(x1) && float.IsNaN(x2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            float x1, x2;
            o.SolveQuadratic(0, 0, 5, out x1, out x2);
            Assert.IsTrue(float.IsNaN(x1) && float.IsNaN(x2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            float x1, x2;
            o.SolveQuadratic(4, 1, 4, out x1, out x2);
            Assert.IsTrue(float.IsNaN(x1) && float.IsNaN(x2));
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            float x1, x2;
            o.SolveQuadratic(0, 4, 4, out x1, out x2);
            Assert.AreEqual(-1, x1, 0.1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            float x1, x2;
            o.SolveQuadratic(1, 2, -3, out x1, out x2);
            Assert.AreEqual(-3, x1, 0.1);
            Assert.AreEqual(1, x2, 0.1);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            float x1, x2;
            o.SolveQuadratic(1, 4, 4, out x1, out x2);

            Assert.AreEqual(-2, x1, 0.1);
            Assert.AreEqual(-2, x2, 0.1);
        }
    }
}
