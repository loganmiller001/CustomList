using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void AddOneElement_Add_IndexZero()
        {
            AddTest myList = new AddTest();
            int expectedValue = 16;
            int actualValue;

            myList.Add(expectedValue);
            actualValue = myList[0];

            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void AddTwoElements_Add_IndexZeroToOne()
        {
            AddTest myList = new AddTest();
            int expectedValue1 = 16;
            int expectedValue2 = 15;
            int actualValue1;
            int actualValue2;

            myList.Add(expectedValue1);
            myList.Add(expectedValue2);
            actualValue1 = myList[0];
            actualValue2 = myList[1];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);
        }
        [TestMethod]
        public void AddFourElements_Add_IndexZeroToThree()
        {
            AddTest myList = new AddTest();
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
            actualValue1 = myList[0];
            actualValue2 = myList[1];
            actualValue3 = myList[2];
            actualValue4 = myList[3];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);
            Assert.AreEqual(expectedValue3, actualValue3);
            Assert.AreEqual(expectedValue4, actualValue4);

        }
        [TestMethod]
        public void AddTenElements_Add_IndexZeroToNine()
        {
            AddTest myList = new AddTest();
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
            actualValue1 = myList[0];
            actualValue2 = myList[1];
            actualValue3 = myList[2];
            actualValue4 = myList[3];
            actualValue5 = myList[4];
            actualValue6 = myList[5];
            actualValue7 = myList[6];
            actualValue8 = myList[7];
            actualValue9 = myList[8];
            actualValue10 = myList[9];

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
            actualValue1 = myList[0];
            actualValue2 = myList[1];
            actualValue3 = myList[2];
            actualValue4 = myList[3];
            actualValue5 = myList[4];
            actualValue6 = myList[5];
            actualValue7 = myList[6];
            actualValue8 = myList[7];
            actualValue9 = myList[8];
            actualValue10 = myList[9];
            actualValue11 = myList[10];
            actualValue12 = myList[11];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue1, actualValue2);
            Assert.AreEqual(expectedValue1, actualValue3);
            Assert.AreEqual(expectedValue1, actualValue4);
            Assert.AreEqual(expectedValue1, actualValue5);
            Assert.AreEqual(expectedValue1, actualValue6);
            Assert.AreEqual(expectedValue1, actualValue7);
            Assert.AreEqual(expectedValue1, actualValue8);
            Assert.AreEqual(expectedValue1, actualValue9);
            Assert.AreEqual(expectedValue1, actualValue10);
            Assert.AreEqual(expectedValue1, actualValue11);
            Assert.AreEqual(expectedValue1, actualValue12);
        }
    }
}
