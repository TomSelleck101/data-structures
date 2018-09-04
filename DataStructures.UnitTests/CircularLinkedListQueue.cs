using DataStructures.Core.Implementation.Queue;
using DataStructures.Core.Interface.Queue;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    public class CircularCircularLinkedListQueue
    {
        [Test]
        public void Enqueue()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();

            //Act
            circularLinkedListQueue.Enqueue(1);

            //Assert
            Assert.AreEqual(1, circularLinkedListQueue.Peek());
        }

        [Test]
        public void EnqueueMultiple()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();

            //Act
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(2);

            //Assert
            Assert.AreEqual(1, circularLinkedListQueue.Peek());
        }

        [Test]
        public void IsEmptyNoElements()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();

            //Act
            //Assert
            Assert.AreEqual(true, circularLinkedListQueue.IsEmpty());
        }

        [Test]
        public void IsEmptyWithElements()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();
            circularLinkedListQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(false, circularLinkedListQueue.IsEmpty());
        }

        [Test]
        public void IsFullNoElements()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();

            //Act
            //Assert
            Assert.AreEqual(false, circularLinkedListQueue.IsFull());
        }

        [Test]
        public void IsFullWithElements()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(false, circularLinkedListQueue.IsFull());
        }

        [Test]
        public void SizeWithElements()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(10, circularLinkedListQueue.Size());
        }


        [Test]
        public void SizeWithoutElements()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();

            //Act
            //Assert
            Assert.AreEqual(0, circularLinkedListQueue.Size());
        }

        [Test]
        public void Dequeue()
        {
            //Arrange
            IQueue circularLinkedListQueue = new CircularLinkedListQueue();
            circularLinkedListQueue.Enqueue(1);
            circularLinkedListQueue.Enqueue(2);
            circularLinkedListQueue.Enqueue(3);
            circularLinkedListQueue.Enqueue(4);

            //Act
            var dequeued = circularLinkedListQueue.Dequeue();

            //Assert
            Assert.AreEqual(1, dequeued);
            Assert.AreEqual(2, circularLinkedListQueue.Peek());
            Assert.AreEqual(3, circularLinkedListQueue.Size());
        }
        //int Size();
        //void Enqueue(int x);
        //int Dequeue();
        //int Peek();
    }
}
