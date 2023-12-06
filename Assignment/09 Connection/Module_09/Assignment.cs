using System;
using System.Collections.Generic;
namespace Module_09
{
    internal class Assignment
    {
        int Nodes;
        List<int>[] Graph;

        public Assignment(int nodes)
        {
            Nodes = nodes;
            Graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                Graph[i] = new List<int>();
            }
        }
        public void AddEdge(int node1, int node2)
        {
            Graph[node1].Add(node2);
            Graph[node2].Add(node1);
        }
        public void CheckConnection()
        {
            Stack<int> stack = new Stack<int> ();

            List<int> visited = new List<int> ();

            stack.Push(0);

            while (stack.Count > 0)
            {
                int node = stack.Pop ();

                visited.Add (node);

                foreach (int neighbour in Graph[node])
                {
                    if (!visited.Contains(neighbour))
                    {
                        stack.Push(neighbour);
                    }
                }
            }
            if (visited.Count < Nodes) Console.WriteLine("not connected");
            else Console.WriteLine("connected");

        }
    }
}
