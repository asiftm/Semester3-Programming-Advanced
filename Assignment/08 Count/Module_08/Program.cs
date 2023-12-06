using System;
namespace Module_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numberOfNodes = Convert.ToInt32(Console.ReadLine());
                int numberOfEdges = Convert.ToInt32(Console.ReadLine());

                //string[] a = { "0 1","2 3","3 4" };

                Assignment assignment = new Assignment(numberOfNodes);

                for (int i = 0; i < numberOfEdges; i++)
                {
                    string[] pair = Console.ReadLine().Split(" ");
                    assignment.AddEdge(int.Parse(pair[0]), int.Parse(pair[1]));
                }

                Console.WriteLine(assignment.GetConnectedComponents());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}