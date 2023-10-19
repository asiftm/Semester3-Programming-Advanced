using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    class Node
    {
        public string Data { get; set; }
        public Node PreviousNode { get; set; }
        public Node NextNode { get; set; }
        public Node(string nodeData)
        {
            Data = nodeData;
            PreviousNode = null;
            NextNode = null;
        }
    }
}
