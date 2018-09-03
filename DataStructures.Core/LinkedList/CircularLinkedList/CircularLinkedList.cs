using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.LinkedListNodes;

namespace DataStructures.Core.LinkedList.CircularLinkedList
{
    public class CircularLinkedList<T>
    {
        private SingleLinkedListNode<T> _last;

        public CircularLinkedList()
        {
            _last = null;
        }

        public void DisplayList()
        {
            if (_last == null)
            {
                Console.WriteLine("List is empty");
            }

            SingleLinkedListNode<T> current = _last.Link;
            do
            {
                Console.Write($"[{current.Data}] -> ");
                current = current.Link;
            } while (current != _last.Link);
        }

        public SingleLinkedListNode<T> GetLast()
        {
            return _last;
        }

        public void InsertLast(T data)
        {
            SingleLinkedListNode<T> newElement = new SingleLinkedListNode<T>(data);

            if (_last == null)
            {
                _last = newElement;
                _last.Link = _last;
                return;
            }

            newElement.Link = _last.Link;
            _last.Link = newElement;
            _last = newElement;
        }

        public void InsertBeginning(T data)
        {
            SingleLinkedListNode<T> newElement = new SingleLinkedListNode<T>(data);

            if (_last == null)
            {
                _last = newElement;
                _last.Link = _last;
                return;
            }

            newElement.Link = _last.Link;
            _last.Link = newElement;
        }

        public void InsertAfter(T newData, T afterElement)
        {
            // Empty list
            if (_last == null)
            {
                throw new ArgumentException($"List is empty");
            }

            // Get first element
            var current = _last.Link;
            do
            {
                if (current.Data.Equals(afterElement))
                {
                    break;
                }
                current = current.Link;

            } while (current != _last.Link);

            // Element not found
            if (!current.Data.Equals(afterElement))
            {
                throw new ArgumentException($"Element {afterElement} not found");
            }
            
            // Create new node and set up pointers
            var newElement = new SingleLinkedListNode<T>(newData);

            newElement.Link = current.Link;
            current.Link = newElement;
            
            // If current node is the last element, reset last to be new element
            if (current == _last)
            {
                _last = newElement;
            }
        }

        public void DeleteFirstElement()
        {
            if (_last == null)
            {
                return;
            }
            if (_last.Link == _last)
            {
                _last = null;
                return;
            }

            _last.Link = _last.Link.Link;
        }

        public void DeleteLastElement()
        {
            if (_last == null)
            {
                return;
            }
            if (_last.Link == _last)
            {
                _last = null;
                return;
            }

            var current = _last.Link;
            while (current.Link != _last)
            {
                current = current.Link;
            }

            current.Link = _last.Link;
            _last = current;
        }

        public void DeleteElement(T data)
        {
            // Empty list
            if (_last == null)
            {
                return;
            }

            // Last element
            if (_last.Data.Equals(data))
            {
                DeleteLastElement();
                return;
            }

            // First Element
            if (_last.Link.Data.Equals(data))
            {
                _last.Link = _last.Link.Link;
                return;
            }

            // Middle of list
            var current = _last.Link;
            while (!current.Link.Data.Equals(data) && current.Link != _last)
            {
                current = current.Link;
            }

            if (!current.Link.Data.Equals(data))
            {
                throw new ArgumentException($"Element {data} not found");
            }

            current.Link = current.Link.Link;
        }
    }
}
