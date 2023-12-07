using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Dijkstra
{
    class Maze
    {
        int nodes;
        List<int>[] graph;
        Dictionary<int, int>[] Edges;
        
        public Maze(int nodes)
        {
            this.nodes = nodes;

            graph = new List<int>[nodes];   //create graph with nr of nodes
            for (int i = 0; i < nodes; i++) //init all lists
            {
                graph[i] = new List<int>();
            }

            Edges = new Dictionary<int, int>[nodes];
            for (int i = 0; i < nodes; i++) //init all dicts
            {
                Edges[i] = new Dictionary<int, int>();
            }
        }

        public void AddEdge(int node1, int node2, int edge)
        {
            //maze.AddEdge(0, 1);
            //check if a node already is in the list, not going out of bounds
            if (!graph[node1].Contains(node2))
            {
                graph[node1].Add(node2);
                Edges[node1][node2] = edge; 
            }

        }
        public void Dijkstra(int start, int end)
        {
            int[] distances = new int[nodes];//making an for distances
            for(int i = 0;i < nodes;i++)
            {
                distances[i] = Int32.MaxValue;
                //filling the distances array with the highest int value
            }

            int[] previous = new int[nodes];//making an array for previous values

            List<int> visited = new List<int>();//list to mark the arrays as visited

            distances[start] = 0;//the distance from start node to start node is 0

            while (true)
            {
                int CurrentNode = GetNextNode(distances, visited); //finding the CurrentNode node to visit

                if (CurrentNode == end) break; //break if it reaches 0

                if (CurrentNode == -1) break; //break if CurrentNode == -1 means no CurrentNode node to visit

                visited.Add(CurrentNode); //mark CurrentNode node as visited

                //for each neighbor calculate the cost and update if lower
                foreach(int neighbor in graph[CurrentNode])
                {
                    //the distance of neighbor is the distance of current node plus current node to neighbor
                    int distance = distances[CurrentNode] + Math.Abs(Edges[CurrentNode][neighbor]);

                    if (distances[neighbor] > distance) // if the new calculated distance is less then the distance in distance array
                    {
                        distances[neighbor] = distance; //replace the distance with shortest distance
                        previous[neighbor] = CurrentNode; //record the path
                    }
                }
            }

            //printing the output
            string path = end.ToString();
            int node = end;
            while(node != start)
            {
                path = previous[node] + " " + path;
                node = previous[node];
            }

            Console.WriteLine(path);
        }

        private int GetNextNode(int[] distances, List<int> visited)
        {
            int next = -1;//suppose next node is -1
            int min = Int32.MaxValue; //let minimum value is infinite

            for (int i = 0; i < nodes; i++)
            {
                if (distances[i] < min && !visited.Contains(i)) 
                    //the distanse of node i should be less than the existing distance
                    //the node should be not visited
                {
                    min = distances[i]; //adjusting the new minimum distance
                    next = i; // current i is the next node to visit
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
