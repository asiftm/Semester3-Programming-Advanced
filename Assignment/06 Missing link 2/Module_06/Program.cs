using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Module_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int[] ints = Array.ConvertAll(input.Split(" "), int.Parse);

                Missing_Link missing_Link = new Missing_Link();

                string output = missing_Link.GetMissingLink(ints);
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}