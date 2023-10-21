using System;

namespace Module_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Unique(input + " ", input.Length));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
