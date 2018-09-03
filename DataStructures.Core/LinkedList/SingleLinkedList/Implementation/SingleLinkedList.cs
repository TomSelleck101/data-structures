using System;
using DataStructures.Core.LinkedList.LinkedListNodes;
using DataStructures.Core.LinkedList.SingleLinkedList.Interface;

namespace DataStructures.Core.LinkedList.SingleLinkedList.Implementation
{
    /*
     * Dynamic data structure made up of nodes
     * Data not stored in contiguous memory
     * Easy deletion / insertion
     * Can be used to implement abstract data types like list, stack and queue
     * Effcient random access not possible
     * Implementation requires extra memory
     */
    public class SingleLinkedList<T> : ISingleLinkedList<T>
    {
        private SingleLinkedListNode<T> _start;

        public SingleLinkedList()
        {
            _start = null;
        }

        public SingleLinkedListNode<T> GetHead()
        {
            return _start;
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

        public void BubbleSortByDataExchange()
        {
            SingleLinkedListNode<T> end = null, current = null, next = null;

            for (end = null; end != _start.Link; end = current)
            {
                for (current = _start; current.Link != end; current = current.Link)
                {
                    next = current.Link;
                    if (current.CompareTo(next) >= 0)
                    {
                        var temp = current.Data;
                        current.Data = next.Data;
                        next.Data = temp;
                    }
                }
            }
        }

        public void BubbleSortByLinkExchange()
        {
            SingleLinkedListNode<T> end = null, r = null, p = null, q = null, temp = null;

            for (end = null; end != _start.Link; end = p)
            {
                for (r = p = _start; p.Link != end; r = p, p = p.Link)
                {
                    q = p.Link;
                    if (p.CompareTo(q) > 0)
                    {
                        p.Link = q.Link;
                        q.Link = p;
                        if (p != _start)
                        {
                            r.Link = q;
                        }
                        else
                        {
                            _start = q;
                        }

                        //temp = p;
                        p = q;
                        //q = temp;
                    }
                }
            }
        }

        public ISingleLinkedList<T> MergeLinkedListWithNewList(ISingleLinkedList<T> list)
        {
            SingleLinkedList<T> mergedList = new SingleLinkedList<T>();

            mergedList._start = MergeCreateList(_start, list.GetHead());

            return mergedList;
        }

        private SingleLinkedListNode<T> MergeCreateList(SingleLinkedListNode<T> p1, SingleLinkedListNode<T> p2)
        {
            // Determine start node
            SingleLinkedListNode<T> startM;
            if (p1.CompareTo(p2) == (0 | -1))
            {
                startM = new SingleLinkedListNode<T>(p1.Data);
                p1 = p1.Link;
            }
            else
            {
                startM = new SingleLinkedListNode<T>(p2.Data);
                p2 = p2.Link;
            }

            // Add nodes to start node and advance pointers
            SingleLinkedListNode<T> pM = startM;
            while (p1 != null && p2 != null)
            {
                if (p1.CompareTo(p2) == (0 | -1))
                {
                    pM.Link = new SingleLinkedListNode<T>(p1.Data);
                    p1 = p1.Link;
                }
                else
                {
                    pM.Link = new SingleLinkedListNode<T>(p2.Data);
                    p2 = p2.Link;
                }
                pM = pM.Link;
            }

            // Add remaining elements to list
            while (p1 != null)
            {
                pM.Link = new SingleLinkedListNode<T>(p1.Data);
                p1 = p1.Link;
                pM = pM.Link;
            }

            while (p2 != null)
            {
                pM.Link = new SingleLinkedListNode<T>(p2.Data);
                p2 = p2.Link;
                pM = pM.Link;
            }

            return startM;
        }

        public void MergeSort()
        {
            _start = MergeSort(_start);
        }

        private SingleLinkedListNode<T> MergeSort(SingleLinkedListNode<T> listStart)
        {
            if (listStart == null || listStart.Link == null)
            {
                return listStart;
            }

            SingleLinkedListNode<T> start1 = listStart;
            SingleLinkedListNode<T> start2 = DivideList(listStart);

            start1 = MergeSort(start1);
            start2 = MergeSort(start2);

            SingleLinkedListNode<T> startM = MergeRearrange(start1, start2);

            return startM;
        }

        private SingleLinkedListNode<T> DivideList(SingleLinkedListNode<T> list)
        {
            SingleLinkedListNode<T> fastPointer = list.Link.Link;
            while (fastPointer != null && fastPointer.Link != null)
            {
                list = list.Link;
                fastPointer = fastPointer.Link.Link;
            }

            SingleLinkedListNode<T> centerNode = list.Link;
            list.Link = null;
            return centerNode;
        }

        public ISingleLinkedList<T> MergeLinkedListWithLinkRearrange(ISingleLinkedList<T> list)
        {
            SingleLinkedList<T> mergedList = new SingleLinkedList<T>();

            mergedList._start = MergeRearrange(_start, list.GetHead());

            return mergedList;
        }

        private SingleLinkedListNode<T> MergeRearrange(SingleLinkedListNode<T> p1, SingleLinkedListNode<T> p2)
        {
            // Determine start node
            SingleLinkedListNode<T> startM;
            if (p1.CompareTo(p2) == (0 | -1))
            {
                startM = new SingleLinkedListNode<T>(p1.Data);
                p1 = p1.Link;
            }
            else
            {
                startM = new SingleLinkedListNode<T>(p2.Data);
                p2 = p2.Link;
            }

            // Add links to node and advance pointers
            SingleLinkedListNode<T> pM = startM;
            while (p1 != null && p2 != null)
            {
                if (p1.CompareTo(p2) <= 0)
                {
                    pM.Link = p1;
                    pM = pM.Link;
                    p1 = p1.Link;
                }
                else
                {
                    pM.Link = p2;
                    pM = pM.Link;
                    p2 = p2.Link;
                }
            }

            // Add remaining elements to list
            if (p1 == null)
            {
                pM.Link = p2;
            }
            else
            {
                pM.Link = p1;
            }

            return startM;
        }

        public bool HasCycle()
        {
            if (FindCycle() != null)
            {
                return true;
            }

            return false;
        }

        public SingleLinkedListNode<T> FindCycle()
        {
            if (_start == null || _start.Link == null)
            {
                return null;
            }

            SingleLinkedListNode<T> slow = _start, fast = _start;

            while (fast != null && fast.Link != null)
            {
                slow = slow.Link;
                fast = fast.Link.Link;

                if (slow == fast)
                {
                    return slow;
                }
            }

            return null;

        }

        public void RemoveCycle()
        {
            // Find cycle node
            SingleLinkedListNode<T> node = FindCycle();
            if (node == null)
            {
                return;
            }

            // Determine cycle length
            SingleLinkedListNode<T> current = node, next = node;
            int cycleLength = 0;
            do
            {
                cycleLength++;
                next = next.Link;
            } while (current != next);

            // Determine length of list before cycle
            int listBeforeCycleLength = 0;
            current = _start;

            while (current != next)
            {
                listBeforeCycleLength++;
                current = current.Link;
                next = next.Link;
            }

            // Remove last node link
            int listLength = listBeforeCycleLength + cycleLength;

            current = _start;
            for (int i = 1; i <= listLength - 1; i++)
            {
                current = current.Link;
            }

            current.Link = null;
        }
    }
}
