using System;

namespace DataStructures.Core.LinkedList.SingleLinkedList
{
    /*
     * Dynamic data structure made up of nodes
     * Data not stored in contiguous memory
     * Easy deletion / insertion
     * Can be used to implement abstract data types like list, stack and queue
     * Effcient random access not possible
     * Implementation requires extra memory
     */
    public class SingleLinkedList<T>
    {
        private SingleLinkedListNode<T> _start;

        public SingleLinkedList()
        {
            _start = null;
        }

        public int GetElementPosition(T element)
        {
            var p = _start;
            var position = 1;

            while (p != null)
            {
                if (p.Data.Equals(element))
                {
                    break;
                }

                p = p.Link;
                position++;
            }

            if (p.Equals(null))
            {
                return -1;
            }

            return position;
        }

        public T GetFirst()
        {
            if (_start == null)
            {
                return default(T);
            }

            return _start.Data;
        }

        public T GetLast()
        {
            if (_start == null)
            {
                return default(T);
            }

            var temp = _start;
            while (temp.Link != null)
            {
                temp = temp.Link;
            }

            return temp.Data;
        }

        public void AddFirst(T newElem)
        {
            var newNode = new SingleLinkedListNode<T>(newElem)
            {
                Link = _start
            };

            _start = newNode;
        }

        public void AddLast(T newElem)
        {
            var newNode = new SingleLinkedListNode<T>(newElem);

            if (_start == null)
            {
                _start = newNode;
                return;
            }

            var temp = _start;
            while (temp.Link != null)
            {
                temp = temp.Link;
            }

            temp.Link = newNode;
        }

        public void AddAfterElement(T newElement, T afterElement)
        {
            var currentNode = _start;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(afterElement))
                {
                    var newNode = new SingleLinkedListNode<T>(newElement);

                    var temp = currentNode.Link;

                    currentNode.Link = newNode;
                    newNode.Link = temp;

                    return;
                }

                currentNode = currentNode.Link;
            }

            throw new ArgumentException($"List does not contain element {afterElement}");
        }

        public void AddBeforeElement(T newElement, T beforeElement)
        {
            var currentNode = _start;
            var newNode = new SingleLinkedListNode<T>(newElement);

            if (_start == null)
            {
                throw new ArgumentException($"List is empty");
            }

            if (_start.Data.Equals(beforeElement))
            {
                newNode.Link = _start;
                _start = newNode;

                return;
            }

            while (currentNode.Link != null)
            {
                if (currentNode.Link.Data.Equals(beforeElement))
                {
                    var temp = currentNode.Link;

                    currentNode.Link = newNode;
                    newNode.Link = temp;

                    return;
                }

                currentNode = currentNode.Link;
            }
            throw new ArgumentException($"List does not contain element {beforeElement}");

        }

        public void PrintList()
        {
            if (_start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            var p = _start;
            while (p != null)
            {
                Console.Write($"[{p.Data}] -> ");
                p = p.Link;
            }

            Console.Write("[]");
            Console.WriteLine("");
        }

        public int Count()
        {
            var n = 0;

            var p = _start;
            while (p != null)
            {
                n++;
                p = p.Link;
            }

            return n;
        }

        public bool Contains(T elem)
        {
            var p = _start;

            while (p != null)
            {
                if (p.Data.Equals(elem))
                {
                    break;
                }

                p = p.Link;
            }

            return p != null;
        }

        public void AddAtPosition(T newElement, int position)
        {
            var current = _start;

            if (position == 1)
            {
                var newNode = new SingleLinkedListNode<T>(newElement)
                {
                    Link = _start
                };

                _start = newNode;

                return;
            }

            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Link;
            }

            if (current == null)
            {
                throw new ArgumentException($"List does not contain {position} elements");
            }

            var newElem = new SingleLinkedListNode<T>(newElement)
            {
                Link = current.Link
            };

            current.Link = newElem;
        }

        public void DeleteFirstNode()
        {
            if (_start == null)
            {
                return;
            }

            _start = _start.Link;
        }

        public void DeleteLastNode()
        {
            if (_start == null)
            {
                return;
            }

            if (_start.Link == null)
            {
                _start = null;
                return;
            }

            var current = _start;

            while (current.Link.Link != null)
            {
                current = current.Link;
            }

            current.Link = null;

        }

        public void Delete(T element)
        {
            if (_start == null)
            {
                throw new ArgumentException($"List is empty");
            }

            if (_start.Data.Equals(element))
            {
                _start = _start.Link;
                return;
            }

            var current = _start;
            while (current.Link != null)
            {
                if (current.Link.Data.Equals(element))
                {
                    current.Link = current.Link.Link;
                    return;
                }

                current = current.Link;
            }

            throw new ArgumentException($"Element not found");
        }

        public void Reverse()
        {
            SingleLinkedListNode<T> prev, current, next;

            prev = null;
            current = _start;

            while (current != null)
            {
                next = current.Link;

                current.Link = prev;

                prev = current;
                current = next;
            }

            _start = prev;
        }
    }
}
