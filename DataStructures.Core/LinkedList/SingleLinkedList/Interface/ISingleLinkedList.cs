using DataStructures.Core.LinkedList.LinkedListNodes;
using DataStructures.Core.LinkedList.SingleLinkedList.Implementation;

namespace DataStructures.Core.LinkedList.SingleLinkedList.Interface
{
    public interface ISingleLinkedList<T>
    {
        SingleLinkedListNode<T> GetHead();
        int GetElementPosition(T element);
        T GetFirst();
        T GetLast();
        void AddFirst(T newElem);
        void AddLast(T newElem);
        void AddAfterElement(T newElement, T afterElement);
        void AddBeforeElement(T newElement, T beforeElement);
        void PrintList();
        int Count();
        bool Contains(T elem);
        void AddAtPosition(T newElement, int position);
        void DeleteFirstNode();
        void DeleteLastNode();
        void Delete(T element);
        void Reverse();
        void BubbleSortByDataExchange();
        void BubbleSortByLinkExchange();
        ISingleLinkedList<T> MergeLinkedListWithNewList(ISingleLinkedList<T> list);
        void MergeSort();
        ISingleLinkedList<T> MergeLinkedListWithLinkRearrange(ISingleLinkedList<T> list);
        bool HasCycle();
        void RemoveCycle();
        void Concatenate(ISingleLinkedList<T> list);
    }
}