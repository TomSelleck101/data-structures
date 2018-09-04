using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Queue;
using DataStructures.Core.LinkedList.LinkedListNodes;

namespace DataStructures.Core.Implementation.Queue
{
    public class LinkedListQueue : IQueue
    {
        private SingleLinkedListNode<int> _front;
        private SingleLinkedListNode<int> _rear;

        public LinkedListQueue()
        {
            _front = null;
            _rear = null;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            var element = _front.Data;
            _front = _front.Link;

            return element;
        }

        public void Enqueue(int x)
        {
            var newElement = new SingleLinkedListNode<int>(x);

            if (_front == null)
            {
                _front = newElement;
            }
            else
            {
                _rear.Link = newElement;
            }

            _rear = newElement;
        }

        public bool IsEmpty()
        {
            return _front == null;
        }

        public bool IsFull()
        {
            return false;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            return _front.Data;
        }

        public int Size()
        {
            int s = 0;
            SingleLinkedListNode<int> current = _front;

            while (current != null)
            {
                s++;
                current = current.Link;
            }

            return s;
        }
    }
}
