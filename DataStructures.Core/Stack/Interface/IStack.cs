using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Core.Stack.Interface
{
    public interface IStack<T>
    {
        int Size();
        bool IsEmpty();
        bool IsFull();
        void Push(T i);
        T Pop();
        T Peek();
        void Display();
        bool ValidExpression(IEnumerable<T> parentheses);
    }
}
