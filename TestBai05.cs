using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai05
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            long result = o.BinToDec("10101010");

            Assert.AreEqual(170, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            // Ném ra FormatException
            Assert.ThrowsException<FormatException>(() => o.BinToDec("A1010101"));

        }

        [TestMethod]
        public void TestMethod3() {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            // Ném ra FormatException
            Assert.ThrowsException<FormatException>(() => o.BinToDec(""));
        }
    }
}
