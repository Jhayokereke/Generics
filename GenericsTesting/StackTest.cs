using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;

namespace GenericsTesting
{
    [TestClass]
    public class StackTest
    {
        Stack<string> stack = new Stack<string>();

        [TestMethod]
        public void Test_IsEmpty_Method()
        {
            //Arrange
            stack.Push("Francis");

            //Act
            bool empty = stack.IsEmpty();

            //Assert
            Assert.IsFalse(empty);
        }

        [TestMethod]
        public void Test_Push_Method()
        {
            //Arrange
            stack.Push("Rebecca");
            stack.Push("Bertolt");
            stack.Push("Samson");

            string headValue = "Samson";

            //Act
            string actualHead = stack.Head.Value;

            //Assert
            Assert.AreEqual(headValue, actualHead);
        }

        [TestMethod]
        public void Test_Pop_Method()
        {
            //Arrange
            stack.Push("Rebecca");
            stack.Push("Emmanuel");
            stack.Push("Bertolt");
            stack.Push("Samson");

            string firstOut = "Samson";
            string nextOut = "Bertolt";

            //Act
            string actualFirst = stack.Pop();
            string actualNext = stack.Pop();

            //Assert
            Assert.AreEqual(firstOut, actualFirst);
            Assert.AreEqual(nextOut, actualNext);
        }

        [TestMethod]
        public void Test_Size_Method()
        {
            //Arrange
            stack.Push("Rebecca");
            stack.Push("Bertolt");

            int size = 2;

            //Act
            int actualSize = stack.Size();

            //Assert
            Assert.AreEqual(size, actualSize);
        }
    }
}
