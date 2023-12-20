using System;
namespace Module_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine().Trim();
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int[] ints = Array.ConvertAll((input.Split(" ")), int.Parse);

                Missing missing = new Missing();

                missing.ArrayIndexMethod(ints, n);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}