using System;
namespace Module_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt16(Console.ReadLine());

                if (input < 0) throw new Exception();

                Assignment assignment = new Assignment();

                Console.WriteLine(assignment.Sequence(input));
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}