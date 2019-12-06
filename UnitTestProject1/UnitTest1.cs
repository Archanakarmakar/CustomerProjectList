using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1Add_List()
        {
            NewCustomList<int> newlist = new NewCustomList<int>();
            int expectedResult = 22;
            newlist.Add(5);
            newlist.Add(3);
            newlist.Add(5);
            newlist.Add(22);
            newlist.Add(50);
            newlist.Add(2);
            newlist.Add(100);

            //assert
            Assert.AreEqual(expectedResult, newlist[3]);
        }

    }
    }

