using System;

namespace Module_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int[] sequence = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Occurences(number, sequence, sequence.Length - 1));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}