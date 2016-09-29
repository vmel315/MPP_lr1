using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSort;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSorting()
        {
            int[] arr = { 5, 3, 2, 4, 1 };
            QuickSort<int> qsort = new QuickSort<int>();
            qsort.Sort(arr, 0, 4);
            int[] expArr = { 1, 2, 3, 4, 5};
            CollectionAssert.AreEqual(arr, expArr);
        }
    }
}
