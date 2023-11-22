using System;
using System.Xml.Linq;

namespace Week8_Graphs
{
    class Maze_Class
    {
        int nodes;
        List<int>[] graph;
        public Maze_Class(int nodes)
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
        public List<int> DFS_Recursion(int start, List<int> visited, int stop)
        {
            if (visited == null) visited = new List<int>();
            visited.Add(start);

            if(start == stop) return visited;

            foreach (int node in graph[start])
            {
                if (!visited.Contains(node))
                {
                    List<int> nodes = DFS_Recursion(node, visited, stop);
                    if (nodes.Contains(stop)) return nodes;
                }
            }
            return visited;
        }
        public string DFS_Stack(int start, int stop)
        {
            String path = "";

            Stack<int> stack = new Stack<int>();
            stack.Push(start);

            while (stack.Count != 0)
            {
                int node = stack.Pop();

                if (node == stop) return path += " " + node + " "; ;

                if (!path.Contains(" " + node + " ")) path += " " + node + " ";

                foreach (var next in graph[node])
                {
                    if(!path.Contains(" " + next + " "))
                    {
                        stack.Push(next);
                    }
                }
            }
            return path;
        }
        public string BFS_Queue(int start, int stop)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            List<int> visited = new List<int>();
            visited.Add(start);

            while (queue.Count != 0)
            {
                int node = queue.Dequeue();
                if (node == stop) return string.Join("  ", visited);

                foreach (var neighbour in graph[node])
                {
                    if (!visited.Contains(neighbour))
                    {
                        queue.Enqueue(neighbour);
                        visited.Add(neighbour);
                    }
                }
            }
            return string.Join("  ", visited);
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
    class Maze_Canvas
    {
        int nodes;
        List<int>[] graph;
        public Maze_Canvas(int nodes)
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
        public bool DFS_Recursion(int node, bool[] visited)
        {
            Console.WriteLine("next->" + node);

            if (node == 0) return true;

            foreach (int next in graph[node])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    return DFS_Recursion(next, visited);
                }
            }
            return false;
        }
        public void DFS(int node)
        {
            bool[] visited = new bool[graph.Length];
            visited[node] = true;
            DFS_Recursion(node, visited);
        }
        public void DFS_Stack(int node)
        {
            bool[] visited = new bool[graph.Length];
            Stack<int> stack = new Stack<int>();

            visited[node] = true;
            stack.Push(node);

            while (stack.Count != 0)
            {
                node = stack.Pop();
                Console.WriteLine("next->" + node);

                if (node == 0) return;

                foreach (int next in graph[node])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        stack.Push(next);
                    }
                }
            }
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