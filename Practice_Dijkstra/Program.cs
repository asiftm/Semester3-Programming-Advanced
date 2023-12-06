namespace Practice_Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the number of vertices in the graph
            int vertices = 5;

            // Create an adjacency matrix to represent the graph
            int[,] graph = new int[,]
                {
                    { 0, 2, 4, 0, 0 },
                    { 2, 0, 1, 7, 0 },
                    { 4, 1, 0, 3, 0 },
                    { 0, 7, 3, 0, 1 },
                    { 0, 0, 0, 1, 0 }
                };

            // Find the shortest path from node 0 to all other vertices
            DijkstraAlgorithm(graph, vertices, 0);
        }

        static void DijkstraAlgorithm(int[,] graph, int vertices, int startnode)
        {
            // Create arrays to store the shortest distances and visited vertices
            int[] distances = new int[vertices];
            bool[] visited = new bool[vertices];

            // Initialize distances and visited array
            for (int i = 0; i < vertices; ++i)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            // Distance from the start node to itself is always 0
            distances[startnode] = 0;

            // Find the shortest path for all vertices
            for (int count = 0; count < vertices - 1; ++count)
            {
                // Find the node with the minimum distance value
                int minDistancenode = FindMinimumDistance(distances, visited, vertices);

                // Mark the selected node as visited
                visited[minDistancenode] = true;

                // Update the distance value of the adjacent vertices
                for (int v = 0; v < vertices; ++v)
                {
                    // Update distance[v] only if it is not in the visited set,
                    // there is an edge from minDistancenode to v,
                    // and the total weight of path from startnode to v through
                    // minDistancenode is less than the current value of distance[v]
                    if (!visited[v] && graph[minDistancenode, v] != 0 &&
                        distances[minDistancenode] != int.MaxValue &&
                        distances[minDistancenode] + graph[minDistancenode, v] < distances[v])
                    {
                        distances[v] = distances[minDistancenode] + graph[minDistancenode, v];
                    }
                }
            }

            // Print the shortest distances
            PrintSolution(distances, vertices);
        }

        static int FindMinimumDistance(int[] distances, bool[] visited, int vertices)
        {
            // Initialize min value
            int min = int.MaxValue;
            int minIndex = -1;

            // Find the node with the minimum distance value that is not yet processed
            for (int v = 0; v < vertices; ++v)
            {
                if (visited[v] == false && distances[v] <= min)
                {
                    min = distances[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        static void PrintSolution(int[] distances, int vertices)
        {
            Console.WriteLine("Shortest distances from the start node:");

            for (int i = 0; i < vertices; ++i)
            {
                Console.WriteLine($"node {i}: {distances[i]}");
            }
        }
    }
}