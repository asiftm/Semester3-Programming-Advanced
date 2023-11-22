using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Module_06;
namespace Module_06
{
    class Program
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
                //missing_Link.Sort(ints, 0, ints.Length - 1);

                //for (int i = 1; i < ints.Length; i++)
                //{
                //    if (!ints.Contains(i))
                //    {
                //        Console.WriteLine(i);
                //        return;
                //    }
                //}
                //Console.WriteLine("No missing link");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
            
        }
    }
}