using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Core.Interface.Queue
{
    public interface IQueue
    {
        bool IsEmpty();
        bool IsFull();
        int Size();
        void Enqueue(int x);
        int Dequeue();
        int Peek();
    }
}
