using System;
namespace Module_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt16(Console.ReadLine().Trim());

                if (input < 0) throw new Exception();

                Assignment assignment = new Assignment();

                Console.WriteLine("\n" + assignment.Sum(input));
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}