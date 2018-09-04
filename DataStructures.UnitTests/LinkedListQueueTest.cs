using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Implementation.Queue;
using DataStructures.Core.Interface.Queue;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    public class LinkedListQueueTest
    {
        [Test]
        public void Enqueue()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();

            //Act
            linkedListQueue.Enqueue(1);

            //Assert
            Assert.AreEqual(1, linkedListQueue.Peek());
        }

        [Test]
        public void EnqueueMultiple()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();

            //Act
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(2);

            //Assert
            Assert.AreEqual(1, linkedListQueue.Peek());
        }

        [Test]
        public void IsEmptyNoElements()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();

            //Act
            //Assert
            Assert.AreEqual(true, linkedListQueue.IsEmpty());
        }

        [Test]
        public void IsEmptyWithElements()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(false, linkedListQueue.IsEmpty());
        }

        [Test]
        public void IsFullNoElements()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();

            //Act
            //Assert
            Assert.AreEqual(false, linkedListQueue.IsFull());
        }

        [Test]
        public void IsFullWithElements()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(false, linkedListQueue.IsFull());
        }

        [Test]
        public void SizeWithElements()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(10, linkedListQueue.Size());
        }


        [Test]
        public void SizeWithoutElements()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();

            //Act
            //Assert
            Assert.AreEqual(0, linkedListQueue.Size());
        }

        [Test]
        public void Dequeue()
        {
            //Arrange
            IQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(1);
            linkedListQueue.Enqueue(2);
            linkedListQueue.Enqueue(3);
            linkedListQueue.Enqueue(4);

            //Act
            var dequeued = linkedListQueue.Dequeue();

            //Assert
            Assert.AreEqual(1, dequeued);
            Assert.AreEqual(2, linkedListQueue.Peek());
            Assert.AreEqual(3, linkedListQueue.Size());
        }
        //int Size();
        //void Enqueue(int x);
        //int Dequeue();
        //int Peek();
    }
}
