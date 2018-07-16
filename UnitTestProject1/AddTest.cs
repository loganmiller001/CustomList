using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace UnitTestProject1
{
    [TestClass]
    public class AddTest
    {


        [TestMethod]
        public void AddOneElement_AddIndex_IndexZero()
        {
           MadeUpList<int> myList = new MadeUpList<int>();
            int[] MadeUpList = new[] { 16 };
            int expectedValue = 16;
            int actualValue;

            myList.Add(expectedValue);
            actualValue = MadeUpList[0];

            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void AddTwoElements_AddIndex_IndexZeroToOne()
        {
            MadeUpList<int> myList = new MadeUpList<int>();
            int[] MadeUpList = new[] {16, 15 };
            int expectedValue1 = 16;
            int expectedValue2 = 15;
            int actualValue1;
            int actualValue2;

            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            actualValue1 = MadeUpList[0];
            actualValue2 = MadeUpList[1];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);
        }
        [TestMethod]
        public void AddFourElements_AddIndex_IndexZeroToThree()
        {
            MadeUpList<int> myList = new MadeUpList<int>();
            int[] MadeUpList = new[] { 16, 15, 14, 13};
            int expectedValue1 = 16;
            int expectedValue2 = 15;
            int expectedValue3 = 14;
            int expectedValue4 = 13;
            int actualValue1;
            int actualValue2;
            int actualValue3;
            int actualValue4;

            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            myList.Add(expectedValue3);
            myList.Add(expectedValue4);
            actualValue1 = MadeUpList[0];
            actualValue2 = MadeUpList[1];
            actualValue3 = MadeUpList[2];
            actualValue4 = MadeUpList[3];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);
            Assert.AreEqual(expectedValue3, actualValue3);
            Assert.AreEqual(expectedValue4, actualValue4);

        }
        [TestMethod]
        public void AddTenElements_AddIndex_IndexZeroToNine()
        {
            MadeUpList<int> myList = new MadeUpList<int>();
            int[] MadeUpList = new[] { 16, 15, 14, 13, 12, 11, 10, 9, 8, 7};
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
            int actualValue1;
            int actualValue2;
            int actualValue3;
            int actualValue4;
            int actualValue5;
            int actualValue6;
            int actualValue7;
            int actualValue8;
            int actualValue9;
            int actualValue10;

            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            myList.Add(expectedValue3);
            myList.Add(expectedValue4);
            myList.Add(expectedValue5);
            myList.Add(expectedValue6);
            myList.Add(expectedValue7);
            myList.Add(expectedValue8);
            myList.Add(expectedValue9);
            myList.Add(expectedValue10);
            actualValue1 = MadeUpList[0];
            actualValue2 = MadeUpList[1];
            actualValue3 = MadeUpList[2];
            actualValue4 = MadeUpList[3];
            actualValue5 = MadeUpList[4];
            actualValue6 = MadeUpList[5];
            actualValue7 = MadeUpList[6];
            actualValue8 = MadeUpList[7];
            actualValue9 = MadeUpList[8];
            actualValue10 = MadeUpList[9];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);
            Assert.AreEqual(expectedValue3, actualValue3);
            Assert.AreEqual(expectedValue4, actualValue4);
            Assert.AreEqual(expectedValue5, actualValue5);
            Assert.AreEqual(expectedValue6, actualValue6);
            Assert.AreEqual(expectedValue7, actualValue7);
            Assert.AreEqual(expectedValue8, actualValue8);
            Assert.AreEqual(expectedValue9, actualValue9);
            Assert.AreEqual(expectedValue10, actualValue10);



        }
        [TestMethod]
        public void AddTwelveElements_AddIndex_IndexZeroToEleven()
        {
            MadeUpList<int> myList = new MadeUpList<int>();
            int[] MadeUpList = new[] { 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5 };
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
            int expectedValue11 = 6;
            int expectedValue12 = 5;
            int actualValue1;
            int actualValue2;
            int actualValue3;
            int actualValue4;
            int actualValue5;
            int actualValue6;
            int actualValue7;
            int actualValue8;
            int actualValue9;
            int actualValue10;
            int actualValue11;
            int actualValue12;

            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            myList.Add(expectedValue3);
            myList.Add(expectedValue4);
            myList.Add(expectedValue5);
            myList.Add(expectedValue6);
            myList.Add(expectedValue7);
            myList.Add(expectedValue8);
            myList.Add(expectedValue9);
            myList.Add(expectedValue10);
            myList.Add(expectedValue11);
            myList.Add(expectedValue12);
            actualValue1 = MadeUpList[0];
            actualValue2 = MadeUpList[1];
            actualValue3 = MadeUpList[2];
            actualValue4 = MadeUpList[3];
            actualValue5 = MadeUpList[4];
            actualValue6 = MadeUpList[5];
            actualValue7 = MadeUpList[6];
            actualValue8 = MadeUpList[7];
            actualValue9 = MadeUpList[8];
            actualValue10 = MadeUpList[9];
            actualValue11 = MadeUpList[10];
            actualValue12 = MadeUpList[11];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);
            Assert.AreEqual(expectedValue3, actualValue3);
            Assert.AreEqual(expectedValue4, actualValue4);
            Assert.AreEqual(expectedValue5, actualValue5);
            Assert.AreEqual(expectedValue6, actualValue6);
            Assert.AreEqual(expectedValue7, actualValue7);
            Assert.AreEqual(expectedValue8, actualValue8);
            Assert.AreEqual(expectedValue9, actualValue9);
            Assert.AreEqual(expectedValue10, actualValue10);
            Assert.AreEqual(expectedValue11, actualValue11);
            Assert.AreEqual(expectedValue12, actualValue12);
        }
        [TestMethod]
        public void CountIndex_Count_Length()
        {
            MadeUpList<int> myList = new MadeUpList<int>();
            int expected = 4;
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);

            int actual = myList.ArrayCount;
            Assert.AreEqual(expected, actual);



        }
    }
}
