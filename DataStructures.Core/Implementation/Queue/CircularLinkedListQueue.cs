using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Queue;
using DataStructures.Core.LinkedList.LinkedListNodes;

namespace DataStructures.Core.Implementation.Queue
{
    public class CircularLinkedListQueue : IQueue
    {
        private SingleLinkedListNode<int> _rear;

        public CircularLinkedListQueue()
        {
            _rear = null;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            SingleLinkedListNode<int> deleteNode;
            if (_rear.Link == _rear)
            {
                deleteNode = _rear;
                _rear = null;
            }
            else
            {
                deleteNode = _rear.Link;
                _rear.Link = deleteNode.Link;
            }

            return deleteNode.Data;

        }

        public void Enqueue(int x)
        {
            SingleLinkedListNode<int> newNode = new SingleLinkedListNode<int>(x);

            if (IsEmpty())
            {
                _rear = newNode;
                _rear.Link = _rear;

                return;
            }

            newNode.Link = _rear.Link;
            _rear.Link = newNode;
            _rear = newNode;
        }

        public bool IsEmpty()
        {
            return _rear == null;
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

            return _rear.Link.Data;
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }

            int s = 0;
            SingleLinkedListNode<int> current = _rear.Link;

            do
            {
                s++;
                current = current.Link;
            } while (current != _rear.Link);

            return s;
        }
    }
}
