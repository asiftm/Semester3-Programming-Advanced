using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    class Tree
    {
        private Node Root { get; set; }
        public Tree()
        {
            Root = null;
        }
        public void AddNode(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                AddNode(Root, value);
            }
        }

        private void AddNode(Node node, int value)
        {
            if(value < node.Value)
            {
                if(node.Left == null) node.Left = new Node(value);
                else AddNode(node.Left, value);
            }
            else
            {
                if(node.Right == null) node.Right = new Node(value);
                else AddNode(node.Right, value);
            }
        }
        public void InOrderTraversal()
        {
            if (Root != null)
            {
                InOrderTraversal(Root);
                Console.WriteLine();
            }
            else Console.WriteLine("Tree is empty!");
        }

        private void InOrderTraversal(Node node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value);
                Console.Write(" ");
                InOrderTraversal(node.Right);
            }
        }

        public void DeleteNode( int node)
        {
            if (Root == null) return;
            Root = DeleteNode(Root, node);
        }
        private Node DeleteNode(Node root, int node)
        {
            if (root == null) return root;

            if(node < root.Value) root.Left = DeleteNode(root.Left, node);
            else if(node > root.Value) root.Right = DeleteNode(root.Right, node);
            else
            {
                if (root.Left == null) return root.Right;
                else if (root.Right == null) return root.Left;
                root.Value = GetMin(root.Right);
                root.Right = DeleteNode(root.Right, root.Value);
            }
            return root;
        }
        private int GetMin(Node node)
        {
            int min = node.Value;
            while (node.Left != null)
            {
                min = node.Left.Value;
                node = node.Left;
            }
            return min;
        }
    }
}
