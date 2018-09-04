using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Implementation.Queue;

namespace DataStructures.UnitTests
{
    public class SortedLinkedListPriorityQueueTest
    {
        [Test]
        public void AddElementsToList()
        {
            var list = new SortedLinkedListPriorityQueue();

            list.Insert(1, 1);
            list.Insert(2, 2);
            list.Insert(3, 3);
            list.Insert(4, 4);
            list.Insert(5, 5);

            list.Insert(6, 2);


        }
    }
}
