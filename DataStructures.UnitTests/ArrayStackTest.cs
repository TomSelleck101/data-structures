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
            IStack<int> stack = new ArrayStack<int>();

            //Act
            stack.Push(1);

            //Assert
            Assert.AreEqual(1, stack.Peek());
        }

        [Test]
        public void BalancedParenthesesTrue()
        {
            //Arrange
            IStack<char> stack = new ArrayStack<char>(20);

            //Act
            //Assert
            Assert.AreEqual(true, stack.ValidExpression("(()(())(()))"));
        }

        [Test]
        public void BalancedParenthesesFalse()
        {
            //Arrange
            IStack<char> stack = new ArrayStack<char>(20);

            //Act
            //Assert
            Assert.AreEqual(false, stack.ValidExpression("(()(())(())))"));
        }
    }
}
