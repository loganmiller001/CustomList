using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ToStringTest<T>
    {
        public MadeUpList<T> myList;
        [TestMethod]
        public void MyOverrideToString_ToString_CheckReturn()
        {
            MadeUpList<T> myList = new MadeUpList<T> {Words="Blah", Numbers = 55 };
            Console.WriteLine(myList);


        }
    }
}
