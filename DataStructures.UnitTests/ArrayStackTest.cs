using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Stack.Implementation;
using DataStructures.Core.Stack.Interface;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    public class ArrayStackTest
    {
        [Test]
        public void PushToStack()
        {
            //Arrange
            IStack stack = new ArrayStack();

            //Act
            stack.Push(1);

            //Assert
            Assert.AreEqual(1, stack.Peek());
        }
    }
}
