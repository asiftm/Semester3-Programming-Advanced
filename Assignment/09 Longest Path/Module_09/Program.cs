using System;
namespace Module_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nodes = Convert.ToInt32(Console.ReadLine());

                Maze maze = new Maze(nodes);

                int edges = Convert.ToInt32(Console.ReadLine()); ;

                for (int i = 0; i < edges; i++)
                {
                    string[] input = Console.ReadLine().Split(",");
                    maze.AddEdge(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));
                }

                Console.WriteLine(maze.Dijkstra(0));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}