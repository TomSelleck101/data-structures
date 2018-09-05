using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Interface.Tree;

namespace DataStructures.Core.Implementation.Tree
{
    public class BinaryTree : IBinaryTree
    {
        private IBinaryTreeNode _root;

        public BinaryTree()
        {
            _root = null;
        }

        public void CreateSampleTree()
        {
            _root = new BinaryTreeNode('P');

            _root.SetLeftNode('Q');
            _root.SetRightNode('R');

            _root.GetLeftNode().SetLeftNode('A');
            _root.GetLeftNode().SetRightNode('B');

            _root.GetRightNode().SetLeftNode('X');
        }

        public void Display()
        {
            Display(_root, 0);
            Console.WriteLine();
        }

        private void Display(IBinaryTreeNode node, int level)
        {
            if (node == null)
            {
                return;
            }

            Display(node.GetRightNode(), level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.Write(node.GetInfo());

            Display(node.GetLeftNode(), level + 1);
        }

        public int Height()
        {
            return Height(_root);
        }

        private int Height(IBinaryTreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = Height(node.GetLeftNode());
            int rightHeight = Height(node.GetRightNode());

            if (leftHeight > rightHeight)
            {
                return 1 + leftHeight;
            }

            return rightHeight + 1;
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(_root);
            Console.WriteLine();
        }

        private void InOrderTraversal(IBinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            InOrderTraversal(node.GetLeftNode());
            Console.Write(node.GetInfo() + " ");
            InOrderTraversal(node.GetRightNode());
        
        }

        public void LevelOrderTraversal()
        {
            if (_root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }

            Queue<IBinaryTreeNode> queue = new Queue<IBinaryTreeNode>();
            queue.Enqueue(_root);

            IBinaryTreeNode current;

            while (queue.Count != 0)
            {
                current = queue.Dequeue();
                Console.Write(current.GetInfo() + " ");
                if (current.GetLeftNode() != null)
                {
                    queue.Enqueue(current.GetLeftNode());
                }
                if (current.GetRightNode() != null)
                {
                    queue.Enqueue(current.GetRightNode());
                }
            }
            Console.WriteLine();
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(_root);
            Console.WriteLine();
        }

        private void PostOrderTraversal(IBinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            PostOrderTraversal(node.GetLeftNode());
            PostOrderTraversal(node.GetRightNode());
            Console.Write(node.GetInfo() + " ");
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(_root);
            Console.WriteLine();
        }

        private void PreOrderTraversal(IBinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.GetInfo() + " ");
            PreOrderTraversal(node.GetLeftNode());
            PreOrderTraversal(node.GetRightNode());
        }
    }
}
