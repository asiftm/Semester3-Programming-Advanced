using System;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split(" ");

                if(input.Length > 2)
                {
                    Console.WriteLine("Crazy input!");
                    Environment.Exit(0);
                }

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Multiplication(int.Parse(input[0]), int.Parse(input[1])));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
            
        }
    }
}