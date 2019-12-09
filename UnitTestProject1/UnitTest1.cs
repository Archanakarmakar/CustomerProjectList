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
            newlist.Add("get");
            newlist.Add("A");
            newlist.Add("new");
            newlist.Add("life");

            string expected = "hello";
            //Act
            string actual = newlist[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_SetStringAtEndIndex()
        {
            NewCustomList<string> newlist = new NewCustomList<string>();
            newlist.Add("hello");
            newlist.Add("get");
            newlist.Add("A");
            newlist.Add("new");
            newlist.Add("job");

            string expected = "job";
            //Act
            string actual = newlist[4];

            //Assert
            Assert.AreEqual(expected, actual);
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
        [TestMethod]
        public void Indexer_ElementOutOfRange()
        {
            NewCustomList<int> newlist = new NewCustomList<int>();

            newlist.Add(1);
            newlist.Add(2);
            newlist.Add(3);
            newlist.Add(5);
            newlist.Add(6);

            //newlist[10];
            //  Assert.AreEqual();

        }
        [TestMethod]
        public void Remove_TestInt()
        {
            NewCustomList<int> newlist = new NewCustomList<int>();
            newlist.Add(1);
            newlist.Add(2);
            newlist.Add(3);
            newlist.Add(4);
            newlist.Add(5);

            newlist.Remove(3);
            Assert.AreEqual(4, newlist[2]);


        }
        [TestMethod]
        public void Remove_TestEndOfString()
        {
            NewCustomList<string> newlist = new NewCustomList<string>();
            newlist.Add("Hi");
            newlist.Add("Hello");
            newlist.Add("Baby");
            newlist.Add("Hey");
            newlist.Add("Say");

            newlist.Remove("Say");
            Assert.AreEqual("Say", newlist.LastElementRemoved);
        }

        [TestMethod]
        public void String_Add_ToString()
        {
            NewCustomList<string> newlist = new NewCustomList<string>();
            newlist.Add("Hello");
            newlist.Add("World");
            newlist.Add("To");
            newlist.Add("Go");
            newlist.Add("Cart");

            string actual = newlist.StringToString();
            string expected = "HelloWorldToGoCart";
            Assert.AreEqual(expected, actual);
        }

    }
}


