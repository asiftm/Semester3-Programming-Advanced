using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class SubsetProblem
    {
        int a;
        /*
            Start with empty subset and add to result list.
            iterate through the elements of input:
            Include current element in the subset.
            Recursively call yourself with the updated subset and the next index.
            Exclude the current element from the subset (backtrack)
         */

        public void Solve(int[] array, List<List<int>> results, List<int> sublist, int index = 0)
        {
            results.Add(new List<int>(sublist)); //otherwise adding reference
            for (int i = index; i < array.Length; i++)
            {
                sublist.Add(array[i]);
                Console.WriteLine($"step into {++a}");
                Solve(array, results, sublist, i + 1);
                Console.WriteLine($"back to {--a}");
                sublist.RemoveAt(sublist.Count - 1);
            }
        }
        public List<List<int>> SolveBinary(int[] array)
        {
            List<List<int>> results = new List<List<int>>();

            for (int i = 0; i < Math.Pow(2,array.Length); i++)
            {
                List<int> subset = new List<int>();
                string binary = Convert.ToString(i,2).PadLeft(array.Length, '0');

                for (int j = 0; j < array.Length; j++)
                {
                    if (binary[j] == '1') subset.Add(array[j]);
                }
                results.Add(subset);
            }
            return results;
        }
    }
}


