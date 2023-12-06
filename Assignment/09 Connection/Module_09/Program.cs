using System;
using System.Collections.Generic;
namespace Module_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nodes = Convert.ToInt32(Console.ReadLine());
                int edges = Convert.ToInt32(Console.ReadLine());

                Assignment assignment = new Assignment(nodes);

                for (int i = 0; i < edges; i++)
                {
                    int[] input = Array.ConvertAll((Console.ReadLine()).Split(","), int.Parse);
                    assignment.AddEdge(input[0], input[1]);
                }

                assignment.CheckConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }

            
        }
    }
}