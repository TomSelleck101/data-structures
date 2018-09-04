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
    public class ArrayQueueTest
    {
        [Test]
        public void Enqueue()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();

            //Act
            arrayQueue.Enqueue(1);

            //Assert
            Assert.AreEqual(1, arrayQueue.Peek());
        }

        [Test]
        public void EnqueueMultiple()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();

            //Act
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);

            //Assert
            Assert.AreEqual(1, arrayQueue.Peek());
        }

        [Test]
        public void IsEmptyNoElements()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();

            //Act
            //Assert
            Assert.AreEqual(true, arrayQueue.IsEmpty());
        }

        [Test]
        public void IsEmptyWithElements()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();
            arrayQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(false, arrayQueue.IsEmpty());
        }

        [Test]
        public void IsFullNoElements()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();

            //Act
            //Assert
            Assert.AreEqual(false, arrayQueue.IsFull());
        }

        [Test]
        public void IsFullWithElements()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(true, arrayQueue.IsFull());
        }

        [Test]
        public void SizeWithElements()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(1);
            //Act
            //Assert
            Assert.AreEqual(10, arrayQueue.Size());
        }


        [Test]
        public void SizeWithoutElements()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();

            //Act
            //Assert
            Assert.AreEqual(0, arrayQueue.Size());
        }


        [Test]
        public void Dequeue()
        {
            //Arrange
            IQueue arrayQueue = new ArrayQueue();
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);

            //Act
            var dequeued = arrayQueue.Dequeue();

            //Assert
            Assert.AreEqual(1, dequeued);
            Assert.AreEqual(2, arrayQueue.Peek());
            Assert.AreEqual(3, arrayQueue.Size());
        }

        //int Size();
        //void Enqueue(int x);
        //int Dequeue();
        //int Peek();
    }
}
