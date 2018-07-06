using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class IterableTest
    {
        [TestMethod]
        public void IndexesShouldHaveValue_GetEnumerator_Value()
        {
            MadeUpList<string> myList = new MadeUpList<string>();
            string[] madeUpList = new string[5] {"Bob", "Ross", "Cole", "Dale", "Dan"};

            string expectedResult = (madeUpList.GetEnumerator().ToString());
            string actualResult;

            actualResult = (myList.GetEnumerator().ToString());

            Assert.AreEqual(expectedResult, actualResult);
         
        }
    }
}
