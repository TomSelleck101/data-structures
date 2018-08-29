using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Core.LinkedList.SingleLinkedList
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
    }
}
