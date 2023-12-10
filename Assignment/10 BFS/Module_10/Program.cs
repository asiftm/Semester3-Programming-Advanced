using System;
namespace Module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BST bst = new BST();

                int[] ints = Array.ConvertAll(Console.ReadLine().Trim().Split(" "), int.Parse);

                foreach (int i in ints)
                {
                    bst.AddNode(i);
                }

                Console.WriteLine(bst.BFS());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}