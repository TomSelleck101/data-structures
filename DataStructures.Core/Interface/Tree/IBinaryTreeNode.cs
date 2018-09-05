using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Core.Interface.Tree
{
    public interface IBinaryTreeNode
    {
        IBinaryTreeNode GetRightNode();
        IBinaryTreeNode GetLeftNode();
        char GetInfo();

        void SetRightNode(char data);
        void SetLeftNode(char data);
    }
}
