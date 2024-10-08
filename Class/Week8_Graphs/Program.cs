﻿namespace Week8_Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(25);

            maze.AddEdge(0, 1);
            maze.AddEdge(1, 2);
            maze.AddEdge(2, 3);
            maze.AddEdge(3, 4);
            maze.AddEdge(4, 9);
            maze.AddEdge(9, 14);
            maze.AddEdge(18, 17);
            maze.AddEdge(18, 19);
            maze.AddEdge(19, 14);
            maze.AddEdge(19, 24);
            maze.AddEdge(24, 23);
            maze.AddEdge(18, 23);
            maze.AddEdge(22, 23);
            maze.AddEdge(17, 12);
            maze.AddEdge(21, 22);
            maze.AddEdge(21, 20);
            maze.AddEdge(20, 15);
            maze.AddEdge(15, 10);
            maze.AddEdge(10, 5);
            maze.AddEdge(5, 0);
            maze.AddEdge(12, 0);

            Console.WriteLine(maze.ToString());

            List<int> nodes_all = maze.DFSwithoutStop(12, null);
            Console.WriteLine("DFS RECUSION WITHOUT STOP:" + String.Join("--> ", nodes_all));

            List<int> nodes = maze.DFS(12, null, 0);
            Console.WriteLine("DFS RECUSION:" + String.Join("--> ", nodes));

            Console.WriteLine("DFS STACK: " + maze.DFS(12,0));
            Console.WriteLine("BFS:" + maze.BFS(12, 0));




        }
    }
}