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

                Sum sum = new Sum();
                Console.WriteLine(sum.DoSum(input, input.Length - 1));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}