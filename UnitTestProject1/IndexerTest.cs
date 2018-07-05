using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class IndexerTest
    {
        public MadeUpList myList;
        [TestMethod]
        public void CheckIndexer_MyIndexer_CheckValues()
        {
            MadeUpList myMadeUpList = new MadeUpList();
            int[] myList = new[] {12, 13, 14, 15, 16, 17, 18 };
            myList[2] = 15;
            myList[3] = 16;
            int expectedValue1 = 15;
            int expectedValue2 = 16;
            int actualValue1;
            int actualValue2;

            actualValue1 = myList[2];
            actualValue2 = myList[3];

            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);

            


        }
    }
}
