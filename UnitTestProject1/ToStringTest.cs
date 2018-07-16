using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ToStringTest
    {
        
        [TestMethod]
        public void MyOverrideToString_ToString_CheckReturn()
        {
            MadeUpList<int> myList = new MadeUpList<int>();
            int[] stringList = new int[] {1 };
            string expectedValue = "1" ;


           

            string actualValue = stringList[0].ToString();

            Assert.AreEqual(expectedValue, actualValue);


        }

        [TestMethod]
        public void MyOverrrideToString_ToString_MultipleInts()
        {
            MadeUpList<int> stringTest = new MadeUpList<int>();
            int[] stringList = new[] { 17, 18, 19, 20};
            string expectedValue1 = "17";
            string expectedValue2 = "18";
            string expectedValue3 = "19";
            string expectedValue4 = "20";
            string actualValue1;
            string actualValue2;
            string actualValue3;
            string actualValue4;



            actualValue1 = stringList[0].ToString();
            actualValue2 = stringList[1].ToString();
            actualValue3 = stringList[2].ToString();
            actualValue4 = stringList[3].ToString();
            Assert.AreEqual(expectedValue1, actualValue1);
            Assert.AreEqual(expectedValue2, actualValue2);
            Assert.AreEqual(expectedValue3, actualValue3);
            Assert.AreEqual(expectedValue4, actualValue4);
        }


       
    }
}
