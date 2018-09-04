using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.LinkedListNodes;
using DataStructures.Core.Stack.Interface;

namespace DataStructures.Core.Stack.Implementation
{
    public class LinkedListStack<T> : IStack<T>
    {
        private SingleLinkedListNode<T> _top;

        public LinkedListStack()
        {
            _top = null;
        }
       
        public void Display()
        {
            var current = _top;

            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("Stack is: ");
            while (current != null)
            {
                Console.WriteLine(current.Data + " ");
                current = current.Link;
            }
        }

        public bool IsEmpty()
        {
            return _top == null;
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Stack is empty");
            }

            return _top.Data;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Stack is empty");
            }
            var x = _top.Data;
            _top = _top.Link;

            return x;
        }

        public int Size()
        {
            int s = 0;
            SingleLinkedListNode<T> current = _top;

            while (current != null)
            {
                current = current.Link;
                s++;
            }

            return s;
        }

        public void Push(T x)
        {
            var newElement = new SingleLinkedListNode<T>(x);
            newElement.Link = _top;
            _top = newElement;
        }

        public bool ValidExpression(IEnumerable<T> parentheses)
        {
            throw new NotImplementedException();
        }
    }
}
