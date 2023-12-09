using System;

namespace Practice_Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(6);

            maze.AddEdge(0, 2, 4);
            maze.AddEdge(0, 3, 2);

            //maze.AddEdge(1, 2, 9);
            maze.AddEdge(1, 4, 1);

            //maze.AddEdge(2, 0);
            //maze.AddEdge(2, 3, 3);
            //maze.AddEdge(2, 5, 1);
            maze.AddEdge(2, 1, 9);

            //maze.AddEdge(3, 2);
            //maze.AddEdge(3, 0);
            maze.AddEdge(3, 2, 3);
            maze.AddEdge(3, 5, 20);

            //maze.AddEdge(4, 1);
            //maze.AddEdge(4, 5, 2);

            maze.AddEdge(5, 4, 2);
            //maze.AddEdge(5, 3);
            maze.AddEdge(5, 2, 1);

            //Console.WriteLine(maze.ToString());
            //maze.Dijkstra(0,4);
        }
    }
}