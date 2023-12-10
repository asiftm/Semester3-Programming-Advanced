using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Module_10
{
    class BST
    {
        public Node Root { get; set; }

        public BST()
        {
            Root = null;
        }
        public void AddNode(int value)
        {
            if (Root == null) Root = new Node(value);
            else AddNode(Root, value);
        }
        public void AddNode(Node root, int value)
        {
            if(root.Value > value)
            {
                if (root.LeftValue == null) root.LeftValue = new Node(value);
                else AddNode(root.LeftValue, value);
            }
            else
            {
                if(root.RightValue == null) root.RightValue = new Node(value);
                else AddNode(root.RightValue, value);
            }
        }
        public string BFS()
        {
            string output = "";

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (true)
            {
                if (queue.Count == 0) break;
                Node currentNode = queue.Dequeue();
                output += currentNode.Value + " ";

                if(currentNode.LeftValue != null) queue.Enqueue(currentNode.LeftValue);
                if(currentNode.RightValue != null) queue.Enqueue(currentNode.RightValue);
            }
            return output;
        }
    }
}


