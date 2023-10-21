using System;

namespace Module_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Minimum(input, input.Length - 1, input[input.Length - 1]));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}