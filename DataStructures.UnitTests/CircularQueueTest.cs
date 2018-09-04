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
    public class CircularQueueTest
    {
        [Test]
        public void Enqueue()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();

            //Act
            circularQueue.Enqueue(1);

            //Assert
            Assert.AreEqual(1, circularQueue.Peek());
        }

        [Test]
        public void EnqueueMultiple()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();

            //Act
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(2);

            //Assert
            Assert.AreEqual(1, circularQueue.Peek());
        }

        [Test]
        public void IsEmptyNoElements()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();

            //Act
            //Assert
            Assert.AreEqual(true, circularQueue.IsEmpty());
        }

        [Test]
        public void IsEmptyWithElements()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();
            circularQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(false, circularQueue.IsEmpty());
        }

        [Test]
        public void IsFullNoElements()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();

            //Act
            //Assert
            Assert.AreEqual(false, circularQueue.IsFull());
        }

        [Test]
        public void IsFullWithElements()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(true, circularQueue.IsFull());
        }

        [Test]
        public void SizeWithElements()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(10, circularQueue.Size());
        }


        [Test]
        public void SizeWithoutElements()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();

            //Act
            //Assert
            Assert.AreEqual(0, circularQueue.Size());
        }


        [Test]
        public void Dequeue()
        {
            //Arrange
            IQueue circularQueue = new CircularQueue();
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(2);
            circularQueue.Enqueue(3);
            circularQueue.Enqueue(4);

            //Act
            var dequeued = circularQueue.Dequeue();

            //Assert
            Assert.AreEqual(1, dequeued);
            Assert.AreEqual(2, circularQueue.Peek());
            Assert.AreEqual(3, circularQueue.Size());
        }

        //int Size();
        //void Enqueue(int x);
        //int Dequeue();
        //int Peek();
    }
}
