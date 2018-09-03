using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using DataStructures.Core.LinkedList.DoublyLinkedList.Implementation;
using DataStructures.Core.LinkedList.DoublyLinkedList.Interface;

namespace DataStructures.UnitTests
{
    public class DoubleLinkedListTest
    {
        [Test]
        public void AddAtBeginningOfEmptyList()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();

            //Act
            l.InsertInBeginning(1);

            //Assert
            var start = l.GetHead();
            Assert.AreEqual(start.Data, 1);

        }

        [Test]
        public void AddAtBeginningOfList()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertInBeginning(1);

            //Act
            l.InsertInBeginning(2);

            //Assert
            var start = l.GetHead();
            Assert.AreEqual(start.Data, 2);
        }

        [Test]
        public void AddAtEndOfEmptyList()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();

            //Act
            l.InsertAtEnd(1);

            //Assert
            var start = l.GetHead();
            Assert.AreEqual(start.Data, 1);
        }


        [Test]
        public void AddAtEndOfList()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);

            //Act
            l.InsertAtEnd(2);

            //Assert
            var start = l.GetHead();
            Assert.AreEqual(start.Next.Data, 2);
        }

        [Test]
        public void AddAfterElement()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);
            l.InsertAtEnd(2);
            l.InsertAtEnd(3);

            //Act
            l.InsertAfter(4, 2);

            //Assert
            var start = l.GetHead();
            Assert.AreEqual(start.Next.Next.Data, 4);
        }

        [Test]
        public void AddAfterNonExistentElement()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);
            l.InsertAtEnd(2);
            l.InsertAtEnd(3);

            //Act
            Assert.Throws<ArgumentException>(() => l.InsertAfter(4, 20));
        }

        [Test]
        public void DeleteFirstElement()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);
            l.InsertAtEnd(2);

            //Act
            l.Delete(1);

            //Assert
            var head = l.GetHead();
            Assert.AreEqual(head.Data, 2);
        }

        [Test]
        public void DeleteOnlyElement()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);

            //Act
            l.Delete(1);

            //Assert
            var head = l.GetHead();
            Assert.AreEqual(head, null);
        }

        [Test]
        public void DeleteElement()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);
            l.InsertAtEnd(2);
            l.InsertAtEnd(3);
            l.InsertAtEnd(4);
            l.InsertAtEnd(5);

            //Act
            l.Delete(3);

            //Assert
            var current = l.GetHead();
            while (current != null)
            {
                Assert.AreNotEqual(current.Data, 3);
                current = current.Next;
            }
        }

        [Test]
        public void DeleteLastElement()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);
            l.InsertAtEnd(2);
            l.InsertAtEnd(3);
            l.InsertAtEnd(4);
            l.InsertAtEnd(5);

            //Act
            l.Delete(5);

            //Assert
            var current = l.GetHead();
            while (current != null)
            {
                Assert.AreNotEqual(current.Data, 5);
                current = current.Next;
            }
        }

        [Test]
        public void DeleteLastNode()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);
            l.InsertAtEnd(2);
            l.InsertAtEnd(3);
            l.InsertAtEnd(4);
            l.InsertAtEnd(5);

            //Act
            l.DeleteLastNode();

            //Assert
            var current = l.GetHead();
            while (current != null)
            {
                Assert.AreNotEqual(current.Data, 5);
                current = current.Next;
            }
        }

        [Test]
        public void DeleteLastNodeOnlyElement()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);

            //Act
            l.DeleteLastNode();

            //Assert
            var current = l.GetHead();
            while (current != null)
            {
                Assert.AreNotEqual(current.Data, 1);
                current = current.Next;
            }
        }

        [Test]
        public void ReverseList()
        {
            //Arrange
            IDoubleLinkedList<int> l = new DoubleLinkedList<int>();
            l.InsertAtEnd(1);
            l.InsertAtEnd(2);
            l.InsertAtEnd(3);

            //Act
            l.Reverse();

            //Assert
            var current = l.GetHead();

            Assert.AreEqual(current.Data, 3);
            Assert.AreEqual(current.Next.Data, 2);
            Assert.AreEqual(current.Next.Next.Data, 1);
        }
    }
}
