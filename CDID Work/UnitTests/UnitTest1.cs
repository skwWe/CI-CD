using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayMethods;
using System;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class ArrayTests
    {
        public int[] array;
        public ArrayClass _arraytest;
        [TestInitialize]
        public void Setup()
        {
            array = new int[] { 9, 2, 7, 4, 5, 6, 1, 8, 3 };
            _arraytest = new ArrayClass();
            _arraytest.array = (int[])array.Clone();
        }
        [TestMethod]
        public void ArraySort_ShouldTestSort()
        {
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            _arraytest.ArraySort();
            CollectionAssert.AreEqual(expected, _arraytest.array);
        }

        [TestMethod]
        public void ArrayFilter_ShouldFilt()
        {
            int[] expected = new int[] { 3, 6, 9 };
            var result = _arraytest.ArrayFilter();
            CollectionAssert.AreEqual(expected, result);
        }

    }
}
