using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Stack.Interface;

namespace DataStructures.Core.Stack.Implementation
{
    public class ArrayStack : IStack
    {
        private int[] _stackArray;
        private int _top;

        public ArrayStack()
        {
            _stackArray = new int[10];
            _top = -1;
        }

        public ArrayStack(int maxSize)
        {
            _stackArray = new int[maxSize];
            _top = -1;
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public bool IsFull()
        {
            return _top == _stackArray.Length - 1;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Stack is empty");
            }

            return _stackArray[_top];
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Stack is empty");
            }

            var popped = _stackArray[_top];
            _top = _top - 1;

            return popped;
        }

        public void Push(int i)
        {
            if (IsFull())
            {
                throw new ArgumentException("Stack is full");
            }

            _top = _top + 1;
            _stackArray[_top] = i;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("Stack: ");
            for (int i = _top; i >= 0; i--)
            {
                Console.WriteLine(_stackArray[i] + " ");
            }
            Console.WriteLine();
        }

        public int Size()
        {
            return _top + 1;
        }
    }
}
