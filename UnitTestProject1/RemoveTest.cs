//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using CustomList;
//namespace UnitTestProject1
//{
//    [TestClass]
//    public class RemoveTest
//    {
//        public MadeUpList myList;   

//        [TestMethod]
//        public void RemoveOneElement_Remove_IndexZero()
//        {
//            MadeUpList myList = new MadeUpList();
//            int expectedValue = 16;
//            int actualValue;

//            myList.Remove(expectedValue);
//            actualValue = myList[0];

//            Assert.AreEqual(expectedValue, actualValue);
//        }
//        [TestMethod]
//        public void RemoveTwoElements_Remove_IndexZeroToOne()
//        {
//            RemoveTest myList = new RemoveTest();
//            int expectedValue1 = 16;
//            int expectedValue2 = 15;
//            int actualValue1;
//            int actualValue2;

//            myList.Remove(expectedValue1);
//            myList.Remove(expectedValue2);
//            actualValue1 = myList[0];
//            actualValue2 = myList[1];

//            Assert.AreEqual(expectedValue1, actualValue1);
//            Assert.AreEqual(expectedValue2, actualValue2);
//        }
//        [TestMethod]
//        public void RemoveFourElements_Remove_IndexZeroToThree()
//        {
//            MadeUpList myList = new MadeUpList();
//            int expectedValue1 = 16;
//            int expectedValue2 = 15;
//            int expectedValue3 = 14;
//            int expectedValue4 = 13;
//            int actualValue1;
//            int actualValue2;
//            int actualValue3;
//            int actualValue4;

//            myList.Remove(expectedValue1);
//            myList.Remove(expectedValue2);
//            myList.Remove(expectedValue3);
//            myList.Remove(expectedValue4);
//            actualValue1 = myList[0];
//            actualValue2 = myList[1];
//            actualValue3 = myList[2];
//            actualValue4 = myList[3];

//            Assert.AreEqual(expectedValue1, actualValue1);
//            Assert.AreEqual(expectedValue2, actualValue2);
//            Assert.AreEqual(expectedValue3, actualValue3);
//            Assert.AreEqual(expectedValue4, actualValue4);

//        }
//        [TestMethod]
//        public void RemoveTenElements_Remove_IndexZeroToNine()
//        {
//            MadeUpList myList = new MadeUpList();
//            int expectedValue1 = 16;
//            int expectedValue2 = 15;
//            int expectedValue3 = 14;
//            int expectedValue4 = 13;
//            int expectedValue5 = 12;
//            int expectedValue6 = 11;
//            int expectedValue7 = 10;
//            int expectedValue8 = 9;
//            int expectedValue9 = 8;
//            int expectedValue10 = 7;
//            int actualValue1;
//            int actualValue2;
//            int actualValue3;
//            int actualValue4;
//            int actualValue5;
//            int actualValue6;
//            int actualValue7;
//            int actualValue8;
//            int actualValue9;
//            int actualValue10;

//            myList.Remove(expectedValue1);
//            myList.Remove(expectedValue2);
//            myList.Remove(expectedValue3);
//            myList.Remove(expectedValue4);
//            myList.Remove(expectedValue5);
//            myList.Remove(expectedValue6);
//            myList.Remove(expectedValue7);
//            myList.Remove(expectedValue8);
//            myList.Remove(expectedValue9);
//            myList.Remove(expectedValue10);
//            actualValue1 = myList[0];
//            actualValue2 = myList[1];
//            actualValue3 = myList[2];
//            actualValue4 = myList[3];
//            actualValue5 = myList[4];
//            actualValue6 = myList[5];
//            actualValue7 = myList[6];
//            actualValue8 = myList[7];
//            actualValue9 = myList[8];
//            actualValue10 = myList[9];

//            Assert.AreEqual(expectedValue1, actualValue1);
//            Assert.AreEqual(expectedValue2, actualValue2);
//            Assert.AreEqual(expectedValue3, actualValue3);
//            Assert.AreEqual(expectedValue4, actualValue4);
//            Assert.AreEqual(expectedValue5, actualValue5);
//            Assert.AreEqual(expectedValue6, actualValue6);
//            Assert.AreEqual(expectedValue7, actualValue7);
//            Assert.AreEqual(expectedValue8, actualValue8);
//            Assert.AreEqual(expectedValue9, actualValue9);
//            Assert.AreEqual(expectedValue10, actualValue10);



//        }
//        [TestMethod]
//        public void RemoveTwelveElements_Remove_IndexZeroToEleven()
//        {
//            MadeUpList myList = new MadeUpList();
//            int expectedValue1 = 12;
//            int expectedValue2 = 11;
//            int expectedValue3 = 10;
//            int expectedValue4 = 9;
//            int expectedValue5 = 8;
//            int expectedValue6 = 7;
//            int expectedValue7 = 6;
//            int expectedValue8 = 5;
//            int expectedValue9 = 4;
//            int expectedValue10 = 3;
//            int expectedValue11 = 2;
//            int expectedValue12 = 1;
//            int actualValue1;
//            int actualValue2;
//            int actualValue3;
//            int actualValue4;
//            int actualValue5;
//            int actualValue6;
//            int actualValue7;
//            int actualValue8;
//            int actualValue9;
//            int actualValue10;
//            int actualValue11;
//            int actualValue12;

//            myList.Remove(expectedValue1);
//            myList.Remove(expectedValue2);
//            myList.Remove(expectedValue3);
//            myList.Remove(expectedValue4);
//            myList.Remove(expectedValue5);
//            myList.Remove(expectedValue6);
//            myList.Remove(expectedValue7);
//            myList.Remove(expectedValue8);
//            myList.Remove(expectedValue9);
//            myList.Remove(expectedValue10);
//            myList.Remove(expectedValue11);
//            myList.Remove(expectedValue12);
//            actualValue1 = myList[0];
//            actualValue2 = myList[1];
//            actualValue3 = myList[2];
//            actualValue4 = myList[3];
//            actualValue5 = myList[4];
//            actualValue6 = myList[5];
//            actualValue7 = myList[6];
//            actualValue8 = myList[7];
//            actualValue9 = myList[8];
//            actualValue10 = myList[9];
//            actualValue11 = myList[10];
//            actualValue12 = myList[11];

//            Assert.AreEqual(expectedValue1, actualValue1);
//            Assert.AreEqual(expectedValue1, actualValue2);
//            Assert.AreEqual(expectedValue1, actualValue3);
//            Assert.AreEqual(expectedValue1, actualValue4);
//            Assert.AreEqual(expectedValue1, actualValue5);
//            Assert.AreEqual(expectedValue1, actualValue6);
//            Assert.AreEqual(expectedValue1, actualValue7);
//            Assert.AreEqual(expectedValue1, actualValue8);
//            Assert.AreEqual(expectedValue1, actualValue9);
//            Assert.AreEqual(expectedValue1, actualValue10);
//            Assert.AreEqual(expectedValue1, actualValue11);
//            Assert.AreEqual(expectedValue1, actualValue12);
//        }
//    }
//}

