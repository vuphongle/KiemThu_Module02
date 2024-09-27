using System;
using System.Net.Mime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai08
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod01()
        {
            double result = o.TinhTienDien(100, 130);

            Assert.AreEqual(48972, result, 0.1);
        }

        [TestMethod]
        public void TestMethod02()
        {
            double result = o.TinhTienDien(100, 180);

            Assert.AreEqual(132209, result, 0.1);
        }

        [TestMethod]
        public void TestMethod03() {
            double result = o.TinhTienDien(100, 280);

            Assert.AreEqual(323103, result, 0.1);
        }

        [TestMethod]
        public void TestMethod04() {
            double result = o.TinhTienDien(100, 380);

            Assert.AreEqual(559691, result, 0.1);
        }

        [TestMethod]
        public void TestMethod05()
        {
            double result = o.TinhTienDien(100, 480);

            Assert.AreEqual(829279, result, 0.1);
        }

        [TestMethod]
        public void TestMethod06()
        {
            double result = o.TinhTienDien(100, 580);

            Assert.AreEqual(1112001, result, 0.1);
        }

        [TestMethod]
        public void TestMethod07()
        {
            double result = o.TinhTienDien(-10, 130);
            Assert.AreEqual(-1, result, 0.1);
        }

        [TestMethod]
        public void TestMethod08()
        {
            double result = o.TinhTienDien(100, -10);
            Assert.AreEqual(-1, result, 0.1);
        }

        [TestMethod]
        public void TestMethod09()
        {
            double result = o.TinhTienDien(100, 50);
            Assert.AreEqual(-1, result, 0.1);
        }

        [TestMethod]
        public void TestMethod10()
        {
            double result = o.TinhTienDien(0, 80);
            Assert.AreEqual(132209, result, 1);
        }

        [TestMethod]
        public void TestMethod11()
        {
            double result = o.TinhTienDien(0, 0);
            Assert.AreEqual(0, result, 0.1);
        }

        [TestMethod]
        public void TestMethod12()
        {
            double result = o.TinhTienDien(50, 100);
            Assert.AreEqual(81620, result, 0.1);
        }

        [TestMethod]
        public void TestMethod13()
        {
            double result = o.TinhTienDien(50, 101);
            Assert.AreEqual(83306, result, 1);
        }

        [TestMethod]
        public void TestMethod14()
        {
            double result = o.TinhTienDien(50, 150);
            Assert.AreEqual(165935, result, 0.1);
        }

        [TestMethod]
        public void TestMethod15()
        {
            double result = o.TinhTienDien(50, 151);
            Assert.AreEqual(167900, result, 1);
        }

        [TestMethod]
        public void TestMethod16()
        {
            double result = o.TinhTienDien(50, 250);
            Assert.AreEqual(362395, result, 1);
        }

        [TestMethod]
        public void TestMethod17()
        {
            double result = o.TinhTienDien(50, 251);
            Assert.AreEqual(364861, result, 1);
        }

        [TestMethod]
        public void TestMethod18()
        {
            double result = o.TinhTienDien(50, 350);
            Assert.AreEqual(609015, result, 0.1);
        }

        [TestMethod]
        public void TestMethod19()
        {
            double result = o.TinhTienDien(50, 351);
            Assert.AreEqual(611768, result, 1);
        }

        [TestMethod]
        public void TestMethod20()
        {
            double result = o.TinhTienDien(50, 450);
            Assert.AreEqual(884345, result, 1);
        }

        [TestMethod]
        public void TestMethod21()
        {
            double result = o.TinhTienDien(50, 451);
            Assert.AreEqual(887191, result, 1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            double result = o.TinhTienDien(-1, 451);
            Assert.AreEqual(-1, result, 1);
        }

        [TestMethod]
        public void TestMethod23()
        {
            double result = o.TinhTienDien(50, -1);
            Assert.AreEqual(-1, result, 1);
        }

        [TestMethod]
        public void TestMethod24()
        {
            double result = o.TinhTienDien(50, 49);
            Assert.AreEqual(-1, result, 1);
        }
    }
}
