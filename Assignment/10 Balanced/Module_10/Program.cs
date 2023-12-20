using System;
namespace Module_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Balanced balanced = new Balanced();

                int[] input = Array.ConvertAll((Console.ReadLine().Trim()).Split(" "),int.Parse);

                foreach (int i in input)
                {
                    balanced.Add(i);
                }

                if (balanced.CheckBalanced()) Console.WriteLine("balanced");
                else Console.WriteLine("not balanced");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}