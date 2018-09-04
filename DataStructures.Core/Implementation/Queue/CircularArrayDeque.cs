using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Queue;

namespace DataStructures.Core.Implementation.Queue
{
    public class CircularArrayDeque
    {
        private int[] _queueArray;
        private int _front;
        private int _rear;

        public CircularArrayDeque()
        {
            _queueArray = new int[10];
            _front = -1;
            _rear = -1;
        }

        public CircularArrayDeque(int maxSize)
        {
            _queueArray = new int[maxSize];
            _front = -1;
            _rear = -1;
        }

        public void InsertFront(int x)
        {
            if (IsFull())
            {
                throw new ArgumentException("Queue is full");
            }

            if (_front == -1)
            {
                _front = 0;
                _rear = 0;
            }
            else if (_front == 0)
            {
                _front = _queueArray.Length - 1;
            }
            else
            {
                _front = _front - 1;
            }
            _queueArray[_front] = x;
        }

        public void InsertRear(int x)
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
                _rear = _rear + 1;
            }
            _queueArray[_rear] = x;
        }

        public int DeleteFront()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            var x = _queueArray[_front];

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
                _front = _front + 1;
            }

            return x;
        }

        public int DeleteRear()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Queue is empty");
            }

            var x = _queueArray[_rear];

            if (_front == _rear)
            {
                _front = -1;
                _rear = -1;
            } else if (_rear == 0)
            {
                _rear = _queueArray.Length - 1;
            }
            else
            {
                _rear = _rear - 1;
            }

            return x;
        }

        public bool IsEmpty()
        {
            return _front == -1;
        }

        public bool IsFull()
        {
            return ((_front == 0 && _rear == _queueArray.Length - 1) || _front == _rear + 1);
        }
    }
}
