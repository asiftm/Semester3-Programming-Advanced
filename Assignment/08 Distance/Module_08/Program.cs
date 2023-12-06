using System;
namespace Module_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numberOfNodes = 4; //Convert.ToInt32(Console.ReadLine());
                int numberOfEdges = 2; //Convert.ToInt32(Console.ReadLine());

                string[] a = { "0 1","1 2","1 3"};
                //string[] a = { "0 1","2 3"};

                Assignment assignment = new Assignment(numberOfNodes);

                for (int i = 0; i < numberOfEdges; i++)
                {
                    string[] pair = a[i].Split(" ");
                    assignment.AddEdge(int.Parse(pair[0]), int.Parse(pair[1]));
                }

                int start = 0; //Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(assignment.BFS2(start));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}