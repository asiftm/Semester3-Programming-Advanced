namespace Module_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4 --> nr of nodes
            4 --> nr of edges
            0,1,2 --> node 1, node 2, weight
            1,2,3
            2,3,4
            0,2,1
             */

            int nodes = 4;

            Maze maze = new Maze(nodes);

            int edges = 4;

            maze.AddEdge(0, 1, 2);
            maze.AddEdge(1, 2, 3);
            maze.AddEdge(2, 3, 4);
            maze.AddEdge(0, 2, 1);

            Console.WriteLine(maze.ToString());

            //maze.Dijkstra(0);

            for (int i = 0; i < nodes; i++)
            {
                maze.Dijkstra(i);
            }

        }
    }
}