using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node(int value)
        {
            Left = null;
            Right = null;
            Value = value;
        }
    }
}
