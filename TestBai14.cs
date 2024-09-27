using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Module02_Test
{
    [TestClass]
    public class TestBai14
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            o.QuickSort(a, 1, 3);
            int[] exp = { 5, 1, 2, 7, 9, 3 };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            o.QuickSort(a, 3, 1);
            int[] exp = { 5, 7, 1, 2, 9, 3 };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { };
            o.QuickSort(a, 0, 0);
            int[] exp = { };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, -5, 3));

        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, 20, 3));
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, 1, -5));
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, 1, 20));
        }

        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            o.QuickSort(a, 0, 4);
            int[] exp = { 1, 2, 5, 7, 9, 3 };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            o.QuickSort(a, 5, 5);
            int[] exp = { 5, 7, 1, 2, 9, 3 };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            o.QuickSort(a, 0, 0);
            int[] exp = { 5, 7, 1, 2, 9, 3 };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            o.QuickSort(a, 0, 5);
            int[] exp = { 1, 2, 3, 5, 7, 9 };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            o.QuickSort(a, 3, 3);
            int[] exp = { 5, 7, 1, 2, 9, 3 };
            CollectionAssert.AreEqual(exp, a);
        }

        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, -1, 3));

        }
        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, 6, 3));
        }

        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, 3, -1));
        }

        [TestMethod]
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] a = { 5, 7, 1, 2, 9, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => o.QuickSort(a, 3, 6));
        }

    }
}
