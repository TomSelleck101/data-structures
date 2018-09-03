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
    }
}
