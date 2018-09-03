using System;

namespace DataStructures.Core.LinkedList.LinkedListNodes
{
    public class SingleLinkedListNode<T>
    {
        public T Data;
        public SingleLinkedListNode<T> Link;

        public SingleLinkedListNode(T data)
        {
            Data = data;
            Link = null;
        }

        public int CompareTo(SingleLinkedListNode<T> compareNode)
        {
            if (typeof(T) == typeof(int))
            {
                var thisInt = Convert.ToInt32(Data);
                var compareInt = Convert.ToInt32(compareNode.Data);

                if (thisInt > compareInt)
                {
                    return 1;
                }
                if (thisInt < compareInt)
                {
                    return -1;
                }
            }
            else
            {
                throw new ArgumentException("Unhandled data type");
            }

            return 0;
        }
    }
}
