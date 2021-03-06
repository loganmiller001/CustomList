﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class OverloadPlusTest
    {
        [TestMethod]
        public void AddNewInstance_OverLoadPlus_TwoInstances()
        {
            MadeUpList<string> myList = new MadeUpList<string>();
            string[] newList = new[] { "bob", "dole" };
            string expected1 = "bob" + "brian";
            string expected2 = "dole" + "mono";
            string actual1;
            string actual2;

            string[] anotherList = new[] {"brian", "mono" };
            actual1 = newList[0] + anotherList[0];
            actual2 = newList[1] + anotherList[1];

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void AddNewInstance_OperatorOverLoad_AddNewIntInstance()
        {
            MadeUpList<int> aList = new MadeUpList<int>();
            int[] list1 = new[] { 1, 2 };
            int[] list2 = new[] { 3, 4 };
            int expectedValue = (list1[0] + list1[1]) + (list2[0] + list2[1]);
            int actualValue;

            actualValue = expectedValue;

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
