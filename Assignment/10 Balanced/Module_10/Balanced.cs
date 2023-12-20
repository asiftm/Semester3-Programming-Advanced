using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    class Balanced
    {
        public Node Root { get; set; }
        public Balanced()
        {
            Root = null;
        }
        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Add(Root, value);
            }
        }
        private void Add(Node node, int value)
        {
            if (node.Value > value)
            {
                if (node.Left == null) node.Left = new Node(value);
                else Add(node.Left, value);
            }
            else
            {
                if (node.Right == null) node.Right = new Node(value);
                else Add(node.Right, value);
            }

        }
        public bool CheckBalanced()
        {
            if (Root == null || (Root.Left == null && Root.Right == null)) return true;
            else
            {
                if(Math.Abs(GetHeight(Root.Left)- GetHeight(Root.Right)) > 1) return false;
                else return true;
            }
        }
        public int GetHeight(Node root)
        {
            if (root == null) return 0;
            if (root.Left == null && root.Right == null) return 1;
            
            int height = 0;

            int leftHeight = GetHeight(root.Left);
            int rightHeight = GetHeight(root.Right);

            if (leftHeight > rightHeight)
            {
                height = leftHeight;
            }
            else
            {
                height = rightHeight;
            }

            return height+1;
        }
    }
}
