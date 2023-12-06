using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Module_08
{
    class Assignment
    {
        int Nodes;
        List<int>[] Graph;
        int ConnectedComponents = 0;
        public Assignment(int node)
        {
            this.Nodes = node;
            Graph = new List<int>[node];
            for (int i = 0; i < node; i++)
            {
                Graph[i] = new List<int>();
            }
        }
        public void AddEdge(int node1,int node2)
        {
            Graph[node1].Add(node2);
        }
        public int GetConnectedComponents()
        {
            List<int> visited = new List<int>();

            for (int i = 0; i < Graph.Length; i++)
            {
                if (visited.Contains(i)) continue;
                visited.Add(i);

                if (Graph[i].Count > 0)
                {
                    Stack<int> stack = new Stack<int>();

                    stack.Push(i);

                    while (stack.Count > 0)
                    {
                        int node = stack.Pop();

                        foreach (int next in Graph[node])
                        {
                            if (!visited.Contains(next))
                            {
                                visited.Add(next);
                                stack.Push(next);
                            }
                        }
                    }
                }
                ConnectedComponents++;
            }
            return ConnectedComponents;
        }
    }
}
