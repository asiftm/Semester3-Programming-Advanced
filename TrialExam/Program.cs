using System;
using System.Diagnostics;

namespace TrialExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] ints = Array.ConvertAll((Console.ReadLine().Split(" ")), int.Parse);

                //BruteForce bruteForce = new BruteForce();
                //Console.WriteLine(bruteForce.GetGreatest(ints));


                //Recursion recursion = new Recursion();
                //Console.WriteLine(recursion.GetGreatest(ints));


                Greedy greedy = new Greedy();
                Console.WriteLine(greedy.GetGreatest(ints));
            }
            catch(Exception e)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
