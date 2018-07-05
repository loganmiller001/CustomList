using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ToStringTest
    {
        public MadeUpList myList;
        [TestMethod]
        public void MyOverrideToString_ToString_CheckReturn()
        {
            MadeUpList myList = new MadeUpList {Words="Blah", Numbers = 55 };
            Console.WriteLine(myList);


        }
    }
}
