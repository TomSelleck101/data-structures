using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.DoublyLinkedList.Interface;
using DataStructures.Core.LinkedList.LinkedListNodes;

namespace DataStructures.Core.LinkedList.DoublyLinkedList.Implementation
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> _start;
        public DoubleLinkedList()
        {
            _start = null;
        }

        public void Delete(T element)
        {
            // Check if list is empty
            if (_start == null)
            {
                return;
            }

            // Is element the first one in the list
            if (_start.Data.Equals(element))
            {
                if (_start.Next == null)
                {
                    _start = null;
                    return;
                }

                _start = _start.Next;
                _start.Previous = null;
                return;
            }

            // Is element in the list
            var current = _start.Next;
            while (current != null)
            {
                if (current.Data.Equals(element))
                {
                    break;
                }

                current = current.Next;
            }

            // Element not found
            if (current == null)
            {
                return;
            }

            // Last element in list
            if (current.Next == null)
            {
                current.Previous.Next = null;
                return;
            }

            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;

        }

        public void DeleteLastNode()
        {
            if (_start == null)
            {
                return;
            }

            if (_start.Next == null)
            {
                _start = null;
                return;
            }

            var current = _start.Next;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Previous.Next = null;
        }

        public void DisplayList()
        {
            if (_start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            var current = _start;
            while (current != null)
            {
                Console.Write($"[{current.Data}] <-> ");
                current = current.Next;
            }
            Console.Write($"[]");
        }

        public DoubleLinkedListNode<T> GetHead()
        {
            return _start;
        }

        public void InsertAfter(T newElem, T afterElem)
        {
            DoubleLinkedListNode<T> newElement = new DoubleLinkedListNode<T>(newElem);

            // Find element to insert after 
            DoubleLinkedListNode<T> current = _start;
            while (current != null)
            {
                if (current.Data.Equals(afterElem))
                {
                    break;
                }
                current = current.Next;
            }

            // Check it was found
            if (current == null) throw new ArgumentException($"Element {afterElem} not found");

            // Insert after element

            newElement.Next = current.Next;
            newElement.Previous = current;

            if (current.Next != null)
            {
                current.Next.Previous = newElement;
            }

            current.Next = newElement;
        }

        public void InsertAtEnd(T data)
        {
            DoubleLinkedListNode<T> newElem = new DoubleLinkedListNode<T>(data);
            if (_start == null)
            {
                _start = newElem;
                return;
            }

            DoubleLinkedListNode<T> current = _start;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newElem;
            newElem.Previous = current;
        }

        public void InsertInBeginning(T data)
        {
            DoubleLinkedListNode<T> newElem = new DoubleLinkedListNode<T>(data);

            if (_start == null)
            {
                _start = newElem;
                return;
            }

            newElem.Next = _start;
            _start.Previous = newElem;

            _start = newElem;
        }

        public void Reverse()
        {
            // Empty or single item list
            if (_start == null)
            {
                return;
            }

            if (_start.Next == null)
            {
                return;
            }

            // Get handle on first two items
            var current = _start;
            var next = _start.Next;

            // Set first item next to null and previous to next
            current.Next = null;
            current.Previous = next;

            while (next != null)
            {
                next.Previous = next.Next;
                next.Next = current;
                current = next;
                next = next.Previous;
            }

            _start = current;
        }
    }
}
