using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.LinkedList.DoublyLinkedList.Implementation;
using DataStructures.Core.LinkedList.LinkedListNodes;

namespace DataStructures.Core.LinkedList.DoublyLinkedList.Interface
{
    public interface IDoubleLinkedList<T>
    {
        void DisplayList();
        DoubleLinkedListNode<T> GetHead();
        void InsertInBeginning(T data);
        void InsertAtEnd(T data);
        void InsertAfter(T newElem, T afterElem);
        void Delete(T element);
        void DeleteLastNode();
        void Reverse();
    }
}
