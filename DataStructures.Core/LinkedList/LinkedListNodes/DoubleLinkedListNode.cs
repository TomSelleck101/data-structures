namespace DataStructures.Core.LinkedList.LinkedListNodes
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode<T> Previous;
        public T Data;
        public DoubleLinkedListNode<T> Next;

        public DoubleLinkedListNode(T data)
        {
            Data = data;
            Previous = null;
            Next = null;
        }
    }
}
