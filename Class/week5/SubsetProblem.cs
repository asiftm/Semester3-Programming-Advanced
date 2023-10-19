using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class SubsetProblem
    {
        public void Solve(int[] array, List<List<int>> result, List<int> subset, int index = 0)
        {
            result.Add(new List<int>(subset)); //otherwise adding reference

            for (int i = 0; i < array.Length; i++)
            {
                subset.Add(array[i]);
                Solve(array, result, subset, i + 1);
                subset.RemoveAt(subset.Count-1);
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
