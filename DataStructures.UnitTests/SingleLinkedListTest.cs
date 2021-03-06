﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.SingleLinkedList;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    public class SingleLinkedListTest
    {
        [Test]
        public void AddToFrontOfLinkedList()
        {
            //Arrange
            SingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddFirst(1);
            l.AddFirst(2);

            //Act
            l.AddFirst(3);

            //Assert
            Assert.AreEqual(l.Contains(3), true);
            Assert.AreEqual(l.GetElementPosition(3), 1);
        }

        [Test]
        public void AddToEndOfLinkedList()
        {
            //Arrange
            SingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);

            //Act
            l.AddLast(3);

            //Assert
            Assert.AreEqual(l.Contains(3), true);
            Assert.AreEqual(l.GetElementPosition(3), 3);
        }

        [Test]
        public void CountLinkedList()
        {
            //Arrange
            SingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);

            //Act
            var c = l.Count();

            //Assert
            Assert.AreEqual(c, 2);
        }

        [Test]
        public void InsertAfterElementOfLinkedList()
        {
            //Arrange
            SingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddAfterElement(9, 2);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 3);
        }

        [Test]
        public void InsertAfterLastElementOfLinkedList()
        {
            //Arrange
            SingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddAfterElement(9, 4);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 5);
        }

        [Test]
        public void InsertAfterFirstElementOfLinkedList()
        {
            //Arrange
            SingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddAfterElement(9, 1);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 2);
        }

        [Test]
        public void InsertAfterNonExistentElementThrowsException()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            //Assert
            Assert.Throws<ArgumentException>( () => l.AddAfterElement(9, 5));
        }

        [Test]
        public void InsertBeforeElementOfLinkedList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddBeforeElement(9, 2);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 2);
        }

        [Test]
        public void InsertBeforeFirstElement()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddBeforeElement(9, 1);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 1);
        }

        [Test]
        public void InsertBeforeLastElement()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddBeforeElement(9, 4);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 4);
        }
        [Test]
        public void InsertBeforeNonExistentElementThrowsException()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => l.AddBeforeElement(9, 5));
        }

        [Test]
        public void InsertElementAtPositionOfLinkedList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddAtPosition(9, 2);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 2);
        }

        [Test]
        public void InsertElementAtFirstPositionOfLinkedList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddAtPosition(9, 1);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 1);
        }

        [Test]
        public void InsertElementAtSecondLastPositionOfLinkedList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddAtPosition(9, 4);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 4);
        }


        [Test]
        public void InsertElementAtLastPosition()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            l.AddAtPosition(9, 5);

            //Assert
            Assert.AreEqual(l.Contains(9), true);
            Assert.AreEqual(l.GetElementPosition(9), 5);
        }

        [Test]
        public void InsertElementAtOutOfBoundsPositionThrowsException()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => l.AddAtPosition(9, 6));
        }

        [Test]
        public void DeleteFirstNode()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            Assert.AreEqual(l.Contains(1), true);

            //Act
            l.DeleteFirstNode();

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteFirstNodeOneElementList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();
            l.AddLast(1);
            Assert.AreEqual(l.Contains(1), true);

            //Act
            l.DeleteFirstNode();

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteFirstNodeEmptyList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            //Act
            l.DeleteFirstNode();

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteLastNode()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            Assert.AreEqual(l.Contains(4), true);

            //Act
            l.DeleteLastNode();

            //Assert
            Assert.AreEqual(l.Contains(4), false);
        }

        [Test]
        public void DeleteLastNodeOneElementList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);

            Assert.AreEqual(l.Contains(1), true);

            //Act
            l.DeleteLastNode();

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteLastNodeEmptyList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            //Act
            l.DeleteLastNode();

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteElement()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            Assert.AreEqual(l.Contains(3), true);

            //Act
            l.Delete(3);

            //Assert
            Assert.AreEqual(l.Contains(3), false);
        }

        [Test]
        public void DeleteFirstElement()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            Assert.AreEqual(l.Contains(1), true);

            //Act
            l.Delete(1);

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteLastElement()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            Assert.AreEqual(l.Contains(4), true);

            //Act
            l.Delete(4);

            //Assert
            Assert.AreEqual(l.Contains(4), false);
        }


        [Test]
        public void DeleteNonExistentElementThrowsException()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            Assert.AreEqual(l.Contains(5), false);

            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => l.Delete(5));
        }

        [Test]
        public void ReverseLinkedList()
        {
            //Arrange
            var l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);

            Assert.AreEqual(l.GetElementPosition(1), 1);
            Assert.AreEqual(l.GetElementPosition(2), 2);
            Assert.AreEqual(l.GetElementPosition(3), 3);

            //Act
            l.Reverse();

            //Assert
            Assert.AreEqual(l.GetElementPosition(1), 3);
            Assert.AreEqual(l.GetElementPosition(2), 2);
            Assert.AreEqual(l.GetElementPosition(3), 1);
        }
    }
}
