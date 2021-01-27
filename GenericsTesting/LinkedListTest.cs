using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;

namespace GenericsTesting
{
    [TestClass]
    public class LinkedListTest
    {

        LinkedList<string> List = new LinkedList<string>();
        [TestMethod]
        public void Test_Add_Method()
        {
            //Arrange
            List.Add("Gerald");
            List.Add("Samuel");

            int count = 2;
            string headValue = "Gerald";
            string tailValue = "Samuel";

            //Act
            int actualCount = List.Count;
            string actualHeadValue = List.Head.Value;
            string actualTailValue = List.Tail.Value;

            //Assert
            Assert.AreEqual(count, actualCount);
            Assert.AreEqual(headValue, actualHeadValue);
            Assert.AreEqual(tailValue, actualTailValue);
        }

        [TestMethod]
        public void Test_Remove_Method()
        {
            //Arrange
            List.Add("Gerald");
            List.Add("Samuel");

            //Act
            bool first = List.Remove("Gerald");
            bool second = List.Remove("Matthew");

            //Assert
            Assert.IsTrue(first);
            Assert.IsFalse(second);
        }

        [TestMethod]
        public void Test_Check_Method()
        {
            //Arrange
            List.Add("Gerald");
            List.Add("Samuel");

            //Act
            bool first = List.Check("Samuel");
            bool second = List.Check("Blessing");

            //Assert
            Assert.IsTrue(first);
            Assert.IsFalse(second);
        }

        [TestMethod]
        public void Test_Index_Method()
        {
            //Arrange
            List.Add("Gerald");
            List.Add("Samuel");
            List.Add("Onyeka");
            List.Add("Paul");
            List.Add("Agboola");
            List.Add("Reiner");
            int indexOfA = 4;
            int indexOfB = -1;

            //Act
            int indexA = List.Index("Agboola");
            int indexB = List.Index("Blessing");

            //Assert
            Assert.AreEqual(indexA, indexOfA);
            Assert.AreEqual(indexB, indexOfB);
        }
    }
}
