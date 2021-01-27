using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;

namespace GenericsTesting
{
    [TestClass]
    public class QueueTest
    {
        Queue<string> queue = new Queue<string>();

        [TestMethod]
        public void Test_IsEmpty_Method()
        {
            //Arrange

            //Act
            bool empty = queue.IsEmpty();

            //Assert
            Assert.IsTrue(empty);
        }

        [TestMethod]
        public void Test_Enqueue_Method()
        {
            //Arrange
            queue.Enqueue("Rebecca");
            queue.Enqueue("Bertolt");
            queue.Enqueue("Samson");

            string headValue = "Rebecca";
            string tailValue = "Samson";

            //Act
            string actualHead = queue.Head.Value;
            string actualTail = queue.Tail.Value;

            //Assert
            Assert.AreEqual(headValue, actualHead);
            Assert.AreEqual(tailValue, actualTail);
        }

        [TestMethod]
        public void Test_Dequeue_Method()
        {
            //Arrange
            queue.Enqueue("Rebecca");
            queue.Enqueue("Bertolt");
            queue.Enqueue("Samson");

            string firstOut = "Rebecca";
            string nextOut = "Bertolt";

            //Act
            string actualFirst = queue.Dequeue();
            string actualNext = queue.Dequeue();

            //Assert
            Assert.AreEqual(firstOut, actualFirst);
            Assert.AreEqual(nextOut, actualNext);
        }

        [TestMethod]
        public void Test_Size_Method()
        {
            //Arrange
            queue.Enqueue("Rebecca");
            queue.Enqueue("Bertolt");
            queue.Enqueue("Samson");

            int size = 3;

            //Act
            int actualSize = queue.Size();

            //Assert
            Assert.AreEqual(size, actualSize);
        }
    }
}
