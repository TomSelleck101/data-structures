using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Tree;

namespace DataStructures.Core.Implementation.Tree
{
    public class BinarySearchTree : IBinaryTree
    {
        private IBinaryTreeNode _root;

        public BinarySearchTree()
        {
            _root = null;
        }

        public bool IsEmpty()
        {
            return (_root == null);
        }

        public void Insert(int x)
        {
        //  _root = Insert(_root, x);
        }

        //private IBinaryTreeNode Insert(IBinaryTreeNode root, int x)
        //{
        //    if (root == null)
        //    {

        //    }
        //}

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void PreOrderTraversal()
        {
            throw new NotImplementedException();
        }

        public void InOrderTraversal()
        {
            throw new NotImplementedException();
        }

        public void PostOrderTraversal()
        {
            throw new NotImplementedException();
        }

        public void LevelOrderTraversal()
        {
            throw new NotImplementedException();
        }

        public int Height()
        {
            throw new NotImplementedException();
        }

        public void CreateSampleTree()
        {
            throw new NotImplementedException();
        }
    }
}
