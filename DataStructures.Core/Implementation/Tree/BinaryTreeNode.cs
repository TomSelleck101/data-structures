using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Tree;

namespace DataStructures.Core.Implementation.Tree
{
    public class BinaryTreeNode : IBinaryTreeNode
    {
        private BinaryTreeNode _lChild;
        private char _info;
        private BinaryTreeNode _rChild;

        public BinaryTreeNode(char data)
        {
            _info = data;
            _lChild = null;
            _rChild = null;
        }

        public char GetInfo()
        {
            return _info;
        }

        public void SetRightNode(char data)
        {
            _rChild = new BinaryTreeNode(data);
        }

        public void SetLeftNode(char data)
        {
            _lChild = new BinaryTreeNode(data);
        }

        public IBinaryTreeNode GetLeftNode()
        {
            return _lChild;
        }

        public IBinaryTreeNode GetRightNode()
        {
            return _rChild;
        }
    }
}
