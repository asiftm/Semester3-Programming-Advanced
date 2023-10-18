using System.Security.Cryptography;

namespace PracticeSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 4, 7, 6, 9, 8, 5, 6 };

            Sort sort = new Sort();

            //ints = sort.BubbleSort(ints);

            ints = sort.InsertionSort(ints);

            //ints = sort.Selection(ints);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write($"{ints[i]} ");
            }
        }
    }
}