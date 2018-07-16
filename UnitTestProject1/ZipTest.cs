using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class ZipTest
    { 

        [TestMethod]
        public void ZipIntLists_Zip_ArraysZipped()
        {

            MadeUpList<int> list1 = new MadeUpList<int>();
            MadeUpList<int> list2 = new MadeUpList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            MadeUpList<int> list3 = list1.Zip(list2);

            Assert.AreEqual(list3[0], 1);
            Assert.AreEqual(list3[1], 2);
            Assert.AreEqual(list3[2], 3);
            Assert.AreEqual(list3[3], 4);
            Assert.AreEqual(list3[4], 5);
            Assert.AreEqual(list3[5], 6);

            
        }

        [TestMethod]

        public void ZipStringLists_Zip_ArraysAreZipped()
        {
            MadeUpList<string> list1 = new MadeUpList<string>();
            MadeUpList<string> list2 = new MadeUpList<string>();

            list1.Add("1");
            list1.Add("2");
            list1.Add("3");
            list1.Add("4");
            list2.Add("5");
            list2.Add("6");
            list2.Add("7");
            list2.Add("8");

            MadeUpList<string> list3 = list1.Zip(list2);

            Assert.AreEqual(list3[0], "1");
            Assert.AreEqual(list3[1], "5");
            Assert.AreEqual(list3[2], "2");
            Assert.AreEqual(list3[3], "6");
            Assert.AreEqual(list3[4], "3");
            Assert.AreEqual(list3[5], "7");
            Assert.AreEqual(list3[6], "4");
            Assert.AreEqual(list3[7], "8");
        }

        [TestMethod]
        public void BoolTest_Zip_ZipsBooleans()
        {
            MadeUpList<bool> list1 = new MadeUpList<bool>();
            MadeUpList<bool> list2 = new MadeUpList<bool>();

            list1.Add(true);
            list1.Add(false);
            list2.Add(true);
            list2.Add(false);

            MadeUpList<bool> list3 = list1.Zip(list2);

            Assert.AreEqual(list3[0], true);
            Assert.AreEqual(list3[1], true);
            Assert.AreEqual(list3[2], false);
            Assert.AreEqual(list3[3], false);

        }
    }
}