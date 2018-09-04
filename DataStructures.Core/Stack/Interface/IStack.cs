using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Core.Stack.Interface
{
    public interface IStack
    {
        int Size();
        bool IsEmpty();
        bool IsFull();
        void Push(int i);
        int Pop();
        int Peek();
        void Display();
    }
}
