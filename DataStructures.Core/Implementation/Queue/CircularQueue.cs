using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Queue;

namespace DataStructures.Core.Implementation.Queue
{
    public class CircularQueue : IQueue
    {
        private int[] _queueArray;
        private int _front;
        private int _rear;

        public CircularQueue()
        {
            _queueArray = new int[10];
            _front = -1;
            _rear = -1;
        }

        public CircularQueue(int maxSize)
        {
            _queueArray = new int[maxSize];
            _front = -1;
            _rear = -1;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            int x = _queueArray[_front];

            if (_front == _rear)
            {
                _front = -1;
                _rear = -1;
            } else if (_front == _queueArray.Length - 1)
            {
                _front = 0;
            }
            else
            {
                _front++;
            }

            return x;
        }

        public void Enqueue(int x)
        {
            if (IsFull())
            {
                throw new ArgumentException("Queue is full");
            }

            if (_front == -1)
            {
                _front = 0;
            }

            if (_rear == _queueArray.Length - 1)
            {
                _rear = 0;
            }
            else
            {
                _rear++;
            }

            _queueArray[_rear] = x;
        }

        public bool IsEmpty()
        {
            return _front == -1;
        }

        public bool IsFull()
        {
            return _front == 0 && _rear == _queueArray.Length - 1 || _front == _rear + 1;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            return _queueArray[_front];
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }

            if (IsFull())
            {
                return _queueArray.Length;
            }

            int i = _front;
            int s = 0;

            if (_front <= _rear)
            {
                while (i <= _rear)
                {
                    s++;
                    i++;
                }
            }
            else
            {
                while (i <= _queueArray.Length - 1)
                {
                    i++;
                    s++;
                }

                i = 0;
                while (i <= _rear)
                {
                    s++;
                    i++;
                }
            }

            return s;
        }
    }
}
