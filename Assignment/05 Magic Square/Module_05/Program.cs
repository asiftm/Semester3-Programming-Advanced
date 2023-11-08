using System;
namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                MagicSquare magicSquare = new MagicSquare(input);
                string output = magicSquare.Create();
                Console.WriteLine(output.Replace("solution :\n", ""));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}