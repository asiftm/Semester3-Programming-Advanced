using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                List<int> listOfCombinations = new List<int>();

                Sum sum = new Sum();
                sum.FindCombinations(input, 0, listOfCombinations);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}