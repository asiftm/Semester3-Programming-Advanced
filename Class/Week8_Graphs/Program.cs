using System;
using System.ComponentModel;

namespace Week8_Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze_Class maze_class = new Maze_Class(25);

            maze_class.AddEdge(0, 1);
            maze_class.AddEdge(1, 2);
            maze_class.AddEdge(2, 3);
            maze_class.AddEdge(3, 4);
            maze_class.AddEdge(4, 9);
            maze_class.AddEdge(9, 14);
            maze_class.AddEdge(18, 17);
            maze_class.AddEdge(18, 19);
            maze_class.AddEdge(19, 14);
            maze_class.AddEdge(19, 24);
            maze_class.AddEdge(24, 23);
            maze_class.AddEdge(18, 23);
            maze_class.AddEdge(22, 23);
            maze_class.AddEdge(17, 12);
            maze_class.AddEdge(21, 22);
            maze_class.AddEdge(21, 20);
            maze_class.AddEdge(20, 15);
            maze_class.AddEdge(15, 10);
            maze_class.AddEdge(10, 5);
            maze_class.AddEdge(5, 0);

            Console.WriteLine(maze_class.ToString());

            List<int> solve = maze_class.DFS_Recursion(12, new List<int> { } , 10);
            Console.WriteLine("DFS_Recursion: " + string.Join("  ",solve));

            Console.WriteLine("DFS_Stack:     " + maze_class.DFS_Stack(12, 10).Trim());

            Console.WriteLine("BFS_Queue:     " + maze_class.BFS_Queue(12, 10).Trim());




        }
    }
}