using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Stack.Interface;
using DataStructures.Core.Stack.Implementation;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    public class LinkedListStackTest
    {
        [Test]
        public void PushToStack()
        {
            //Arrange
            IStack<int> stack = new LinkedListStack<int>();

            //Act
            stack.Push(1);

            //Assert
            Assert.AreEqual(1, stack.Peek());
        }
    }
}
