using System;
using System.Collections.Generic;
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
            Graph = new List<int>[nodes];
            for(int i = 0; i < nodes; i++)
            {
                Graph[i] = new List<int>();
            }
        }
        public void AddEdge(int node1, int node2)
        {
            Graph[node1].Add(node2);
            Graph[node2].Add(node1);
        }

        public string BFS(int start)
        {
            int distance = 0;
            string output = string.Empty;

            List<int> visited = new List<int>();
            visited.Add(start);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            output += distance.ToString() + " ";

            while (queue.Count > 0)
            {
                distance++;
                int node = queue.Dequeue();

                foreach(int next in Graph[node])
                {
                    if (!visited.Contains(next))
                    {
                        visited.Add(next);
                        queue.Enqueue(next);

                        output += distance.ToString() + " ";
                    }
                }
            }
            if (Nodes > visited.Count)
            {
                for (int i = 0; i < Nodes-visited.Count; i++)
                {
                    output = "-1 " + output; 
                }
            }
            return output;
        }
        public string BFS2(int start)
        {
            string output = string.Empty;

            List<int> visited = new List<int>();

            for (int i = 0; i < Graph.Length; i++)
            {
                Queue<int> queue = new Queue<int>();
                int distance = 0;

                if (i == start)
                {
                    output += "0 ";
                    continue;
                }

                visited.Add(i);
                queue.Enqueue(i);

                while (queue.Count > 0)
                {
                    int node = queue.Dequeue();
                    if(node == start)
                    {
                        output += distance.ToString() + " ";
                        break;
                    }

                    foreach (int next in Graph[node])
                    {
                        if (!visited.Contains(next))
                        {
                            if(next!=start) visited.Add(next);
                            queue.Enqueue(next);
                        }
                    }
                    distance++;
                }
            }
            return output;
        }
    }
}
