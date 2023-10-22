using System;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int spots = Convert.ToInt32(Console.ReadLine());

                string pairs = Console.ReadLine();

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Parking(spots, pairs));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
            
        }
    }
}