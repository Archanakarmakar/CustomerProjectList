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
        [TestMethod]
        public void Add_String()
        {
            NewCustomList<string> newlist = new NewCustomList<string>();
            string expectedResult = "Test";

            newlist.Add("words");
            newlist.Add("Test");

            //assert
            Assert.AreEqual(expectedResult, newlist[1]);
        }
        [TestMethod]
        public void Add_Double()
        {
            NewCustomList<double> newlist = new NewCustomList<double>();
            double expectedResult = 19.55;
            //act
            newlist.Add(.32);
            newlist.Add(19.55);


            //assert
            Assert.AreNotEqual(expectedResult, newlist[0]);
        }



        [TestMethod]
        public void Add_SetStringAtIndex0()
        {
            NewCustomList<string> newlist = new NewCustomList<string>();
            newlist.Add("hello");
            string bar = "foo";
            //Act
            newlist[0] = bar;

            //Assert
            Assert.AreEqual("foo", bar);
        }
        [TestMethod]
        public void Add_IndexCpacity()
        {
            NewCustomList<int> newlist = new NewCustomList<int>();
            newlist.Add(5);
            newlist.Add(3);
            newlist.Add(5);
            newlist.Add(22);
            newlist.Add(50);
            newlist.Add(2);
            newlist.Add(100);
            int expected = 10;
            int actual = newlist.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_IndexCount()
        {
            NewCustomList<int> newlist = new NewCustomList<int>();
            newlist.Add(5);
            newlist.Add(3);
            newlist.Add(22);
            newlist.Add(50);
            newlist.Add(2);
            newlist.Add(100);
            int expected = 6;
            int actual = newlist.Count;

            Assert.AreEqual(expected, actual);
        }

    }
    }


