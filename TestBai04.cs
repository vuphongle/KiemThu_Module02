using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai04
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.IsLeapYear(2024);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.IsLeapYear(2000);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.IsLeapYear(2021);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            //Assert.ThrowsException<Exception>(() => o.IsLeapYear(700));
            //Đặc tả chưa có xử lý cho năm <1582
        }

        [TestMethod]
        public void TestMethod5() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            bool result = o.IsLeapYear(1582);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            //Assert.ThrowsException<Exception>(() => o.IsLeapYear(1581));
            //Đặc tả chưa có xử lý cho năm <1582
        }
    }
}
