﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.CircularLinkedList;
using DataStructures.Core.LinkedList.LinkedListNodes;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    public class CircularLinkedListTest
    {
        [Test]
        public void InsertIntoEmptyList()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            // Act
            l.InsertLast(1);

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Data, 1);
        }

        [Test]
        public void InsertIntoSingleElementList()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            // Act
            l.InsertLast(1);
            l.InsertLast(2);

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Data, 2);
            Assert.AreEqual(lastElem.Link.Data, 1);
        }


        [Test]
        public void InsertAtBeginningList()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            // Act
            l.InsertLast(1);
            l.InsertBeginning(2);

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Data, 1);
            Assert.AreEqual(lastElem.Link.Data, 2);
        }

        [Test]
        public void InsertAfterElement()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            l.InsertLast(1);
            l.InsertLast(2);
            l.InsertLast(3);
            l.InsertLast(4);

            // Act
            l.InsertAfter(5, 3);

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Link.Link.Link.Link.Data, 5);
        }

        [Test]
        public void InsertAfterLastElement()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            l.InsertLast(1);
            l.InsertLast(2);
            l.InsertLast(3);
            l.InsertLast(4);

            // Act
            l.InsertAfter(5, 4);

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Data, 5);
        }

        [Test]
        public void DeleteLastElement()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            l.InsertLast(1);
            l.InsertLast(2);
            l.InsertLast(3);
            l.InsertLast(4);

            // Act
            l.DeleteLastElement();

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Data, 3);
        }

        [Test]
        public void DeleteElement()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            l.InsertLast(1);
            l.InsertLast(2);
            l.InsertLast(3);
            l.InsertLast(4);

            // Act
            l.DeleteElement(3);

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Link.Link.Link.Data, 4);
        }

        [Test]
        public void DeleteFirstNamedElement()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            l.InsertLast(1);
            l.InsertLast(2);
            l.InsertLast(3);
            l.InsertLast(4);

            // Act
            l.DeleteElement(1);

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Link.Data, 2);
        }

        [Test]
        public void DeleteFirstElement()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            l.InsertLast(1);
            l.InsertLast(2);
            l.InsertLast(3);
            l.InsertLast(4);

            // Act
            l.DeleteFirstElement();

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem.Link.Data, 2);
        }

        [Test]
        public void DeleteFirstAndOnlyElement()
        {
            // Arrange
            CircularLinkedList<int> l = new CircularLinkedList<int>();

            l.InsertLast(1);

            // Act
            l.DeleteFirstElement();

            // Assert
            SingleLinkedListNode<int> lastElem = l.GetLast();
            Assert.AreEqual(lastElem, null);
        }

    }
}