using System;
namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                 just followed the instruction given in the assignment. 
                 */

                // first take an input. this is the size of our matrix
                int input = Convert.ToInt32(Console.ReadLine());

                // making out matrix at the time of declearing the MagicSquare type variable. it can be done later too
                MagicSquare magicSquare = new MagicSquare(input);

                // creating out solution
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