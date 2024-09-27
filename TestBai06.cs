using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai06
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(4, 4, 4);

            Assert.AreEqual("Equilateral", result);
        }

        [TestMethod]
        public void TestMethod2() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(4, 4, 5);

            Assert.AreEqual("Isosceles", result);
        }

        [TestMethod]
        public void TestMethod3() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(4, 5, 4);

            Assert.AreEqual("Isosceles", result);
        }

        [TestMethod]
        public void TestMethod4() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(5, 4, 4);

            Assert.AreEqual("Isosceles", result);
        }

        [TestMethod]
        public void TestMethod5() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(7, 8, 9);

            Assert.AreEqual("Scalene", result);
        }

        [TestMethod]
        public void TestMethod6() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(-4, 5, 6);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(50, 20, 7);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(20, -5, 15);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(20, 50, 20);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(20, 20, -44);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            String result = o.Triangle(20, 20, 50);

            Assert.AreEqual("", result);
        }

    }
}
