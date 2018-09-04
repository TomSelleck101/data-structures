using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.SingleLinkedList.Implementation;
using DataStructures.Core.LinkedList.SingleLinkedList.Interface;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    public class SingleLinkedListTest
    {
        [Test]
        public void AddToFrontOfLinkedList()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);

            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => l.AddAfterElement(9, 5));
        }

        [Test]
        public void InsertBeforeElementOfLinkedList()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();
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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            //Act
            l.DeleteFirstNode();

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteLastNode()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            //Act
            l.DeleteLastNode();

            //Assert
            Assert.AreEqual(l.Contains(1), false);
        }

        [Test]
        public void DeleteElement()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

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

        [Test]
        public void BubbleSortByDataExchange()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(5);
            l.AddLast(9);
            l.AddLast(1);
            l.AddLast(10);
            l.AddLast(2);

            //Act
            l.BubbleSortByDataExchange();

            //Assert
            Assert.AreEqual(l.GetElementPosition(1), 1);
            Assert.AreEqual(l.GetElementPosition(2), 2);
            Assert.AreEqual(l.GetElementPosition(5), 3);
            Assert.AreEqual(l.GetElementPosition(9), 4);
            Assert.AreEqual(l.GetElementPosition(10), 5);
        }

        [Test]
        public void BubbleSortByLinkExchange()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(100);
            l.AddLast(5);
            l.AddLast(9);
            l.AddLast(1);
            l.AddLast(10);
            l.AddLast(2);
            l.AddLast(12);
            l.AddLast(22);

            //Act
            l.BubbleSortByLinkExchange();

            //Assert
            Assert.AreEqual(l.GetElementPosition(1), 1);
            Assert.AreEqual(l.GetElementPosition(2), 2);
            Assert.AreEqual(l.GetElementPosition(5), 3);
            Assert.AreEqual(l.GetElementPosition(9), 4);
            Assert.AreEqual(l.GetElementPosition(10), 5);
            Assert.AreEqual(l.GetElementPosition(12), 6);
            Assert.AreEqual(l.GetElementPosition(22), 7);
            Assert.AreEqual(l.GetElementPosition(100), 8);
        }

        [Test]
        public void MergeLinkedListByCreatingNewList()
        {
            //Arrange
            var l1 = new SingleLinkedList<int>();

            l1.AddLast(1);
            l1.AddLast(5);
            l1.AddLast(9);
            l1.AddLast(100);

            var l2 = new SingleLinkedList<int>();

            l2.AddLast(2);
            l2.AddLast(3);
            l2.AddLast(4);
            l2.AddLast(12);
            l2.AddLast(15);

            //Act
            ISingleLinkedList<int> l3 = l1.MergeLinkedListWithNewList(l2);

            //Assert
            Assert.AreEqual(l3.GetElementPosition(1), 1);
            Assert.AreEqual(l3.GetElementPosition(2), 2);
            Assert.AreEqual(l3.GetElementPosition(3), 3);
            Assert.AreEqual(l3.GetElementPosition(4), 4);
            Assert.AreEqual(l3.GetElementPosition(5), 5);
            Assert.AreEqual(l3.GetElementPosition(9), 6);
            Assert.AreEqual(l3.GetElementPosition(12), 7);
            Assert.AreEqual(l3.GetElementPosition(15), 8);
            Assert.AreEqual(l3.GetElementPosition(100), 9);
        }

        [Test]
        public void MergeLinkedListByLinkRearrange()
        {
            //Arrange
            var l1 = new SingleLinkedList<int>();

            l1.AddLast(1);
            l1.AddLast(5);
            l1.AddLast(9);
            l1.AddLast(100);

            var l2 = new SingleLinkedList<int>();

            l2.AddLast(2);
            l2.AddLast(3);
            l2.AddLast(4);
            l2.AddLast(12);
            l2.AddLast(15);

            //Act
            ISingleLinkedList<int> l3 = l1.MergeLinkedListWithLinkRearrange(l2);

            //Assert
            Assert.AreEqual(l3.GetElementPosition(1), 1);
            Assert.AreEqual(l3.GetElementPosition(2), 2);
            Assert.AreEqual(l3.GetElementPosition(3), 3);
            Assert.AreEqual(l3.GetElementPosition(4), 4);
            Assert.AreEqual(l3.GetElementPosition(5), 5);
            Assert.AreEqual(l3.GetElementPosition(9), 6);
            Assert.AreEqual(l3.GetElementPosition(12), 7);
            Assert.AreEqual(l3.GetElementPosition(15), 8);
            Assert.AreEqual(l3.GetElementPosition(100), 9);
        }

        [Test]
        public void MergeSort()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(100);
            l.AddLast(5);
            l.AddLast(9);
            l.AddLast(1);
            l.AddLast(10);
            l.AddLast(2);
            l.AddLast(12);
            l.AddLast(22);

            //Act
            l.MergeSort();

            //Assert
            Assert.AreEqual(l.GetElementPosition(1), 1);
            Assert.AreEqual(l.GetElementPosition(2), 2);
            Assert.AreEqual(l.GetElementPosition(5), 3);
            Assert.AreEqual(l.GetElementPosition(9), 4);
            Assert.AreEqual(l.GetElementPosition(10), 5);
            Assert.AreEqual(l.GetElementPosition(12), 6);
            Assert.AreEqual(l.GetElementPosition(22), 7);
            Assert.AreEqual(l.GetElementPosition(100), 8);
        }

        [Test]
        public void DetectCycle()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(100);
            l.AddLast(5);
            l.AddLast(9);
            l.AddLast(1);


            // Insert cycle
            var listHead = l.GetHead();
            while (listHead.Link != null)
            {
                listHead = listHead.Link;
            }

            var listEnd = listHead;

            listHead = l.GetHead();
            while (listHead.Data != 5)
            {
                listHead = listHead.Link;
            }

            listEnd.Link = listHead;

            //Act
            var r = l.HasCycle();

            //Assert
            Assert.AreEqual(r, true);
        }

        [Test]
        public void DetectCycleEmptyList()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            //Act
            var r = l.HasCycle();

            //Assert
            Assert.AreEqual(r, false);
        }

        [Test]
        public void DetectCycleOneElement()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();
            l.AddLast(1);

            //Act
            var r = l.HasCycle();

            //Assert
            Assert.AreEqual(r, false);
        }

        [Test]
        public void DetectCycleManyElements()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();
            l.AddLast(100);
            l.AddLast(5);
            l.AddLast(9);
            l.AddLast(1);
            l.AddLast(10);
            l.AddLast(2);
            l.AddLast(12);
            l.AddLast(22);


            //Act
            var r = l.HasCycle();

            //Assert
            Assert.AreEqual(r, false);
        }

        [Test]
        public void RemoveCycle()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            l.AddLast(100);
            l.AddLast(5);
            l.AddLast(9);
            l.AddLast(1);

            // Insert cycle
            var listHead = l.GetHead();
            while (listHead.Link != null)
            {
                listHead = listHead.Link;
            }

            var listEnd = listHead;

            listHead = l.GetHead();
            while (listHead.Data != 5)
            {
                listHead = listHead.Link;
            }

            listEnd.Link = listHead;

            var r = l.HasCycle();
            Assert.AreEqual(r, true);

            // Act
            l.RemoveCycle();

            // Assert 
            r = l.HasCycle();
            Assert.AreEqual(r, false);
        }

        [Test]
        public void RemoveCycleEmptyList()
        {
            //Arrange
            ISingleLinkedList<int> l = new SingleLinkedList<int>();

            // Act
            var r = l.HasCycle();
            Assert.AreEqual(r, false);

            l.RemoveCycle();

            // Assert 
            r = l.HasCycle();
            Assert.AreEqual(r, false);
        }

        [Test]
        public void ConcatenateList()
        {
            //Arrange
            ISingleLinkedList<int> l1 = new SingleLinkedList<int>();
            ISingleLinkedList<int> l2 = new SingleLinkedList<int>();

            l1.AddLast(1);
            l1.AddLast(2);
            l1.AddLast(3);

            l2.AddLast(4);
            l2.AddLast(5);
            l2.AddLast(6);

            // Act
            l1.Concatenate(l2);

            // Assert 
            Assert.AreEqual(l1.GetElementPosition(1), 1);
            Assert.AreEqual(l1.GetElementPosition(2), 2);
            Assert.AreEqual(l1.GetElementPosition(3), 3);
            Assert.AreEqual(l1.GetElementPosition(4), 4);
            Assert.AreEqual(l1.GetElementPosition(5), 5);
            Assert.AreEqual(l1.GetElementPosition(6), 6);
        }

        [Test]
        public void ConcatenateWithEmptyList()
        {
            //Arrange
            ISingleLinkedList<int> l1 = new SingleLinkedList<int>();
            ISingleLinkedList<int> l2 = new SingleLinkedList<int>();

            l1.AddLast(1);
            l1.AddLast(2);
            l1.AddLast(3);

            // Act
            l1.Concatenate(l2);

            // Assert 
            Assert.AreEqual(l1.GetElementPosition(1), 1);
            Assert.AreEqual(l1.GetElementPosition(2), 2);
            Assert.AreEqual(l1.GetElementPosition(3), 3);
            Assert.AreEqual(l1.Count(), 3);
        }

        [Test]
        public void ConcatenateEmptyListWithElements()
        {
            //Arrange
            ISingleLinkedList<int> l1 = new SingleLinkedList<int>();
            ISingleLinkedList<int> l2 = new SingleLinkedList<int>();

            l2.AddLast(1);
            l2.AddLast(2);
            l2.AddLast(3);

            // Act
            l1.Concatenate(l2);

            // Assert 
            Assert.AreEqual(l1.GetElementPosition(1), 1);
            Assert.AreEqual(l1.GetElementPosition(2), 2);
            Assert.AreEqual(l1.GetElementPosition(3), 3);
            Assert.AreEqual(l1.Count(), 3);
        }
    }
}
