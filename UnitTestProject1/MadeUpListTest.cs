using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class MadeUpListTest
    {
        [TestMethod]
        public void AddOneElement_Add_IndexZero()
        {
            MadeUpListTest myList = new MadeUpListTest();
            int expectedValue = 16;
            int actualValue;

            myList.Add(expectedValue);
            actualValue = myList[0];

            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void AddTwoElements_Add_IndexZeroToOne()
        {
            MadeUpListTest myList = new MadeUpListTest();
            int expectedValue1 = 16;
            int expectedValue2 = 15;
            int actualValue;

            myList.Add(expectedValue1, expectedValue2);
            actualValue = myList[0, 1];

            Assert.AreEqual(expectedValue1, expectedValue2, actualValue);
        }
        [TestMethod]
        public void AddFourElements_Add_IndexZeroToThree()
        {
            MadeUpListTest myList = new MadeUpListTest();
            int expectedValue1 = 16;
            int expectedValue2 = 15;
            int expectedValue3 = 14;
            int expectedValue4 = 13;
            int actualValue;

            myList.Add(expectedValue1, expectedValue2, expectedValue3, expectedValue4);
            actualValue = myList[0,1,2,3];

            Assert.AreEqual(expectedValue1, expectedValue2, expectedValue3, expectedValue4, actualValue);

        }
        [TestMethod]
        public void AddTenElements_Add_IndexZeroToNine()
        {
            MadeUpListTest myList = new MadeUpListTest();
            int expectedValue1 = 16;
            int expectedValue2 = 15;
            int expectedValue3 = 14;
            int expectedValue4 = 13;
            int expectedValue5 = 12;
            int expectedValue6 = 11;
            int expectedValue7 = 10;
            int expectedValue8 = 9;
            int expectedValue9 = 8;
            int expectedValue10 = 7;
            int actualValue;

            myList.Add(expectedValue1, expectedValue2, expectedValue3, expectedValue4, expectedValue5, expectedValue6, expectedValue7, expectedValue8, expectedValue9, expectedValue10);
            actualValue = myList[0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            Assert.AreEqual(expectedValue1, expectedValue2, expectedValue3, expectedValue4, expectedValue5, expectedValue6, expectedValue7, expectedValue8, expectedValue9, expectedValue10, actualValue);



        }
        [TestMethod]
        public void AddTwelveElements_Add_IndexZeroToEleven()
        {
            int expectedValue1 = 12;
            int expectedValue2 = 11;
            int expectedValue3 = 10;
            int expectedValue4 = 9;
            int expectedValue5 = 8;
            int expectedValue6 = 7;
            int expectedValue7 = 6;
            int expectedValue8 = 5;
            int expectedValue9 = 4;
            int expectedValue10 = 3;
            int expectedValue11 = 2;
            int expectedValue12 = 1;
            int actualValue;

            myList.Add(expectedValue1, expectedValue2, expectedValue3, expectedValue4, expectedValue5, expectedValue6, expectedValue7, expectedValue8, expectedValue9, expectedValue10, expectedValue11, expectedValue12);
            actualValue = myList[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];

            Assert.AreEqual(expectedValue1, expectedValue2, expectedValue3, expectedValue4, expectedValue5, expectedValue6, expectedValue7, expectedValue8, expectedValue9, expectedValue1-, expectedValue11, expectedValue12, actualValue);
        }
    }
}
