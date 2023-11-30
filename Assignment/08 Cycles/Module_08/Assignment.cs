using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Module_08
{
    class Assignment
    {
        int Nodes;
        List<int>[] Graph;
        public Assignment(int nodes)
        {
            this.Nodes = nodes;
            Graph = new List<int>[Nodes];
            for (int i = 0; i < nodes; i++)
            {
                Graph[i]= new List<int>();
            }
        }
        public void AddEdge(int node1, int node2)
        {
            Graph[node1].Add(node2);
        }
        public string DFS()
        {
            for (int i = 0; i < Graph.Length; i++)
            {
                if (Graph[i].Contains(i)) return "cyclic";
                if (Graph[i].Count > 0)
                {
                    List<int> visited = new List<int>();
                    Stack<int> stack = new Stack<int>();

                    stack.Push(Graph[i][0]);

                    while (stack.Count > 0)
                    {
                        int node = stack.Pop();

                        foreach (int next in Graph[node])
                        {
                            if (!visited.Contains(next)) visited.Add(next);
                            else return "cyclic";
                            stack.Push(next);
                        }
                    }
                }
            }
            return "acyclic";
        }
    }
}
