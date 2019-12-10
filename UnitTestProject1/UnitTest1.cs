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
            //Arrange
            NewCustomList<int> newlist = new NewCustomList<int>();

            newlist.Add(5);
            newlist.Add(3);
            newlist.Add(5);
            newlist.Add(22);
            newlist.Add(50);
            newlist.Add(2);
            newlist.Add(100);
            //Act
            int expectedResult = 22;
            //assert
            Assert.AreEqual(expectedResult, newlist[3]);
        }
        [TestMethod]
        public void Add_String()
        {
            //Arrange
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
            //Arrange
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
            //Arrange
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
            //Arrange
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
            //Arrange
            NewCustomList<int> newlist = new NewCustomList<int>();
            newlist.Add(5);
            newlist.Add(3);
            newlist.Add(5);
            newlist.Add(22);
            newlist.Add(50);
            newlist.Add(2);
            newlist.Add(100);
            int expected = 10;
            //Act
            int actual = newlist.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_IndexCount()
        {
            //Arrange
            NewCustomList<int> newlist = new NewCustomList<int>();
            newlist.Add(5);
            newlist.Add(3);
            newlist.Add(22);
            newlist.Add(50);
            newlist.Add(2);
            newlist.Add(100);
            int expected = 6;
            //Act
            int actual = newlist.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Indexer_ElementOutOfRange()
        {
            //Arrange
            NewCustomList<int> newlist = new NewCustomList<int>();

            newlist.Add(1);
            newlist.Add(2);
            newlist.Add(3);
            newlist.Add(5);
            newlist.Add(6);

            //newlist[10];
            //Assert
            //  Assert.AreEqual();

        }
        [TestMethod]
        public void Remove_TestFirstInt()
        {
            //Arrange
            NewCustomList<int> newlist = new NewCustomList<int>();
            newlist.Add(1);
            newlist.Add(2);
            newlist.Add(3);
            newlist.Add(4);
            newlist.Add(5);
            //Act
            newlist.Remove(3);
            //Assert
            Assert.AreEqual(4, newlist[2]);


        }
        [TestMethod]
        public void Remove_TestEndOfString()
        {
            //Arrange
            NewCustomList<string> newlist = new NewCustomList<string>();
            newlist.Add("Hi");
            newlist.Add("Hello");
            newlist.Add("Baby");
            newlist.Add("Hey");
            newlist.Add("Son");
            //Act
            newlist.Remove("Son");
            //Assert
            Assert.AreEqual("Son", newlist.LastElementRemoved);
        }
        [TestMethod]
        public void Convert_DataTypes_ToString()
        {
            //Arrange
            NewCustomList<int> newlist = new NewCustomList<int>();
            newlist.Add(34);
            //Act
            string result = newlist.ToString();
            //Assert
            Assert.AreEqual(result, "34");
        }
        [TestMethod]
        public void String_Add_ToString()
        {
            //Arrange
            NewCustomList<string> newlist = new NewCustomList<string>();
            newlist.Add("Hello");
            newlist.Add("World");
            newlist.Add("To");
            newlist.Add("Go");
            newlist.Add("Cart");
            //Act
            string actual = newlist.ToString();
            string expected = "HelloWorldToGoCart";
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Overloading_PlusOperator()
        {
            //Arrange
            NewCustomList<int> newlist = new NewCustomList<int>() { 1,2 };
             
            NewCustomList<int> secondList = new NewCustomList<int>() {3,4};
            NewCustomList<int> expectdResult = new NewCustomList<int>() { 1, 2, 3, 4 };
            //Act
            NewCustomList<int> actualresult = (newlist + secondList);
            
            //Assert
            Assert.AreEqual(expectdResult.ToString(),actualresult.ToString());
        }

        [TestMethod]
        public void Test_Overloading_SubstactionOperator()
        {
            //Arrange
            NewCustomList<int> list = new NewCustomList<int>() { 1, 3, 5 };
            NewCustomList<int> secondList = new NewCustomList<int>() { 2, 1, 6, 7, 8 };
            NewCustomList<int> expectedResult = new NewCustomList<int>() {3,5};

            //Act
            NewCustomList<int> actualresult = (list - secondList);
            //Assert
            Assert.AreEqual(expectedResult.ToString(),actualresult.ToString());


        }
        [TestMethod]
        public void Test_OfTwoCustomListZIP()
        {
            //Arrange
            NewCustomList<int> oddlist = new NewCustomList<int>() { 1, 3, 5 };
            NewCustomList<int> evenlist = new NewCustomList<int>() { 2, 4, 6 };
            
            //Act
            NewCustomList<int> expectedresult = new NewCustomList<int>() { 1, 2, 3, 4, 5, 6 };                // Act
            NewCustomList<int> actual = NewCustomList<int>.Zip(oddlist, evenlist);
          
            //Assert
            Assert.AreEqual(expectedresult.ToString(), actual.ToString());
        }
        [TestMethod]
        public void TestSort_ListOfUnsortedValues_OutputInSortedOrder()
        {
            // Arrange
            
           
            NewCustomList<int> expectedresult = new NewCustomList<int>() { 1, 2, 3, 4, 5, 6, 7 };
            NewCustomList<int> j = new NewCustomList<int>() { 5, 3, 7, 2, 6, 4, 1 };

            // Act
            NewCustomList<int> actualresult = NewCustomList<int>.Sort<int>(j);

            // Assert
            Assert.AreEqual(expectedresult.ToString(), actualresult.ToString()); ;
        }
    }
}






