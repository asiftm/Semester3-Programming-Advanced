using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09
{
    class Maze
    {
        int Nodes;
        List<int>[] Graph;
        Dictionary<int, int>[] Edges;

        public Maze(int nodes)
        {
            Nodes = nodes;

            Graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                Graph[i] = new List<int>();
            }

            Edges = new Dictionary<int, int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                Edges[i] = new Dictionary<int, int>();
            }
        }
        public void AddEdge(int node1,int node2, int edge)
        {
            if (!Graph[node1].Contains(node2))
            {
                Graph[node1].Add(node2);
                Edges[node1][node2] = edge;
            }
        }
        public void Dijkstra(int start)
        {
            int[] distances = new int[Nodes];
            for (int i = 0; i < Nodes; i++)
            {
                distances[i] = int.MaxValue;
            }
            distances[start] = 0;

            int[] previous = new int[Nodes];

            List<int> visited = new List<int>();

            while (true)
            {
                int currentNode = GetCurrentNode(distances,visited);

                //if (currentNode == end) break;
                if (currentNode == -1) break;

                visited.Add(currentNode);

                foreach (int neighbor in Graph[currentNode])
                {
                    int distance = distances[currentNode] + Math.Abs(Edges[currentNode][neighbor]);

                    if (distance > distances[neighbor])
                    {
                        distances[neighbor] = distance;
                        previous[neighbor] = currentNode;
                    }
                    else if(distance < distances[neighbor] && distances[neighbor] == int.MaxValue)
                    {
                        distances[neighbor] = distance;
                        previous[neighbor] = currentNode;
                    }
                }
            }

            int longestPath = 0;
            string path = "";
            int node = visited.Last();
            while(node != start)
            {
                path = previous[node] + " " + path;
                longestPath += Edges[previous[node]][node];
                node = previous[node];
            }
            Console.WriteLine($" start at {start}, the path is {path} and the longest path is {longestPath}");
        }
        public int GetCurrentNode(int[] distances, List<int> visited)
        {
            int nextNode = -1;
            int max = -1;

            for (int i = 0; i < Nodes; i++)
            {
                if (distances[i] > max && distances[i] != int.MaxValue && !visited.Contains(i))
                {
                    nextNode = i;
                    max = distances[i];
                }
            }
            return nextNode;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Nodes; i++)
            {
                s += i + " --> " + string.Join(" ",Graph[i]) + "\n";
            }
            return s;
        }
    }
}
