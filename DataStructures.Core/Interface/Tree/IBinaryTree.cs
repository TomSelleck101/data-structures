using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Core.Implementation.Tree;

namespace DataStructures.Core.Interface.Tree
{
    public interface IBinaryTree
    {
        void Display();
        void PreOrderTraversal();
        void InOrderTraversal();
        void PostOrderTraversal();
        void LevelOrderTraversal();
        int Height();

        void CreateSampleTree();
    }
}
