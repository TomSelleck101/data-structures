using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.LinkedListNodes;

namespace DataStructures.Core.Implementation.Queue
{
    public class SortedLinkedListPriorityQueue
    {
        private PriorityQueueNode _front;

        public SortedLinkedListPriorityQueue()
        {
            _front = null;
        }

        public void Insert(int element, int elementPriority)
        {
            PriorityQueueNode current, newNode;

            newNode = new PriorityQueueNode(element, elementPriority);

            if (IsEmpty() || elementPriority < _front.Priority)
            {
                newNode.Next = _front;
                _front = newNode;
            }
            else
            {
                current = _front;
                while (current.Next != null && current.Next.Priority <= elementPriority)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public int Delete()
        {
            int element;
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }
            else
            {
                element = _front.Data;
                _front = _front.Next;
            }

            return element;
        }

        public bool IsEmpty()
        {
            return _front == null;
        }
    }
}
