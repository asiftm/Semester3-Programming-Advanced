using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_WeightedGraphs
{
    class Maze
    {
        int nodes;
        List<int>[] graph;
        public Maze(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes]; //create graph with nr of nodes
            for (int i = 0; i < nodes; i++) //init all lists
            {
                graph[i] = new List<int>();
            }
        }
        public void AddEdge(int node1, int node2)
        {
            //to make it better, check if a node already is in the list. not going out of bounds
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }
        public void Dijkstra(int start, int end)
        {
            int[] distances = new int[nodes];

            for (int i = 0;i < nodes;i++)
            {
                distances[i] = Int32.MaxValue;
            }

            int[] previous = new int[nodes];

            List<int> visited = new List<int>();

            distances[start] = 0;

            while (true)
            {
                int next = GetNextNode(distances, visited);

                if (next == -1 || next == end) break;

                visited.Add(next);

                foreach (int neighbour in graph[next])
                {
                    int cost = distances[next] + Math.Abs(neighbour - next);

                    if (cost < distances[neighbour])
                    {
                        distances[neighbour] = cost;
                        previous[neighbour] = next;
                    }
                }
            }
            Console.WriteLine(string.Join("  ",distances));

            string path = "";
            int node = 0;

            while (node != start)
            {
                path += previous[node] + " ";
            }
        }
        private int GetNextNode(int[] distances, List<int> visited)
        {
            int next = -1;
            int min = Int32.MaxValue;

            for (int i = 0; i < nodes; i++)
            {
                if (distances[i] < min && !visited.Contains(i))
                {
                    min = distances[i];
                    next = i;
                }
            }
            return next;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nodes; i++)
            {
                s += i + " --> " + String.Join(" ", graph[i]) + "\n";
            }
            return s;
        }
    }
}
