using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class OverLoadMinusOperator
    {
        [TestMethod]
        public void SubtractInstance_OverLoadOperator_OneInstance()
        {
            MadeUpList<int> aList = new MadeUpList<int>();
            int[] list1 = new[] { 1, 2 };
            int[] list2 = new[] { 3, 4 };
            int testList = (list1[0] + list1[1]) + (list2[0] + list2[1]);
            int expected = (list1[0] + list1[1]);
            int actual;

            actual = testList - (list2[0] + list2[1]);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractInstance_OverLoadOperator_TwoInstaces()
        {
            MadeUpList<int> aList = new MadeUpList<int>();
            int[] list1 = new[] { 1, 2 };
            int[] list2 = new[] { 3, 4 };
            int[] list3 = new[] { 5, 6 };
            int testList = (list1[0] + list1[1]) + (list2[0] + list2[1]) + (list3[0] + list3[1]);
            int expected = (list2[0] + list2[1]);
            int actual;

            actual = testList - (((list1[0]) + (list1[1])) + ((list3[0]) + list3[1]));

            Assert.AreEqual(expected, actual);
            
        }
    }
}
