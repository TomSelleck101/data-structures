using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Queue;

namespace DataStructures.Core.Implementation.Queue
{
    public class ArrayQueue : IQueue
    {
        private int[] _queueArray;
        private int _frontIndex;
        private int _rearIndex;

        public ArrayQueue()
        {
            _queueArray = new int[10];
            _frontIndex = -1;
            _rearIndex = -1;
        }

        public ArrayQueue(int maxSize)
        {
            _queueArray = new int[maxSize];
            _frontIndex = -1;
            _rearIndex = -1;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            var element = _queueArray[_frontIndex];
            _frontIndex = _frontIndex + 1;
            return element;

        }

        public void Enqueue(int x)
        {
            if (IsFull())
            {
                throw new ArgumentException("Queue is full");
            }

            if (_frontIndex == -1)
            {
                _frontIndex = 0;
            }

            _rearIndex = _rearIndex + 1;
            _queueArray[_rearIndex] = x;
        }

        public bool IsEmpty()
        {
            return (_frontIndex == -1 || _frontIndex == _rearIndex + 1);
        }

        public bool IsFull()
        {
            return (_rearIndex == _queueArray.Length - 1);
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            return _queueArray[_frontIndex];
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }

            return _rearIndex - _frontIndex + 1;
        }
    }
}
