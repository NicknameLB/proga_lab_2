using System;

namespace TreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            // Добавление узлов в дерево
            tree.Root = new TreeNode(1);
            tree.Root.Left = new TreeNode(2);
            tree.Root.Right = new TreeNode(3);
            tree.Root.Left.Left = new TreeNode(4);
            tree.Root.Left.Right = new TreeNode(5);

            int leafCount = tree.GetLeafCount();
            Console.WriteLine($"Количество листьев в дереве: {leafCount}");
        }
    }
}