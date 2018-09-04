using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Core.LinkedList.LinkedListNodes
{
    public class PriorityQueueNode
    {
        public int Priority;
        public int Data;
        public PriorityQueueNode Next;

        public PriorityQueueNode(int i, int priority)
        {
            Priority = priority;
            Data = i;
            Next = null;
        }
    }
}
