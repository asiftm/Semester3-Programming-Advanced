using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    class Node
    {
        public int Value { get; set; }
        public Node LeftValue { get; set; }
        public Node RightValue { get; set; }
        public Node(int root)
        {
            Value = root;
            LeftValue = null;
            RightValue = null;
        }
    }
}
