using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSort;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBaseSort()
        {
            int[] arr = { 5, 3, 2, 4, 1 };
            QuickSort<int> qsort = new QuickSort<int>();
            qsort.Sort(arr, 0, 4);
            int[] expArr = { 1, 2, 3, 4, 5};
            CollectionAssert.AreEqual(arr, expArr);
        }
        [TestMethod]
        public void TestDoubNum()
        {
            double[] arr = { 5.2, 3.1, 2, 4.9, 1 };
            QuickSort<double> qsort = new QuickSort<double>();
            qsort.Sort(arr, 0, 4);
            double[] expArr = { 1, 2, 3.1, 4.9, 5.2 };
            CollectionAssert.AreEqual(arr, expArr);
        }
        [TestMethod]
        public void TestLetNum()
        {
            string[] arr = { "a", "c", "d", "e", "b" };
            QuickSort<string> qsort = new QuickSort<string>();
            qsort.Sort(arr, 0, 4);
            string[] expArr = { "a", "b", "c", "d", "e" }; ;
            CollectionAssert.AreEqual(arr, expArr);
        }
    }
}
