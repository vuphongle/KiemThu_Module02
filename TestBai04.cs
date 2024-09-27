using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai04
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod01()
        {
            bool result = o.IsLeapYear(2024);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod02() {
            bool result = o.IsLeapYear(2000);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod03()
        {
            bool result = o.IsLeapYear(2021);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod04()
        {
            bool result = o.IsLeapYear(1900);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod05()
        {
            //Assert.ThrowsException<Exception>(() => o.IsLeapYear(700));
            //Đặc tả chưa có xử lý cho năm <1582
        }

        [TestMethod]
        public void TestMethod06() {
            bool result = o.IsLeapYear(1582);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod07()
        {
            //Assert.ThrowsException<Exception>(() => o.IsLeapYear(1581));
            //Đặc tả chưa có xử lý cho năm <1582
        }
    }
}
