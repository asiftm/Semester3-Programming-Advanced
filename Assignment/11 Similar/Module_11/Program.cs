using System;
namespace Module_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input1 = Console.ReadLine().Trim();
                string input2 = Console.ReadLine().Trim();

                Similar similar = new Similar(input1);
                Console.WriteLine(similar.IsSimilar(input1, input2));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
