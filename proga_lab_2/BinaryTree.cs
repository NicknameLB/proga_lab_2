using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class TreeNode
    {
        public int Value;
        public TreeNode? Left;
        public TreeNode? Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }

        public int CountLeaves(TreeNode node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return 1;

            return CountLeaves(node.Left) + CountLeaves(node.Right);
        }

        public int GetLeafCount()
        {
            return CountLeaves(Root);
        }
    }
}