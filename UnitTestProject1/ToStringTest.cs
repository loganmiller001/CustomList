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
            MadeUpList<int> myList = new MadeUpList<int> {Words="Blah", Numbers = 55 };
            Console.WriteLine(myList);


        }
    }
}
