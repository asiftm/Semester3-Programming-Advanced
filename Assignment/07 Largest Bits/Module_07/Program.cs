using System;
namespace Module_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine().Trim());

                string binary = Convert.ToString(input, 2);

                Assignment assignment = new Assignment(binary);

                int largestBinary = assignment.LargestBits(binary);

                Console.WriteLine(Convert.ToInt32(largestBinary.ToString(), 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
            
        }
    }
}

