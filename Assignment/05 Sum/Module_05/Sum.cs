using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    class Sum
    {
        public int stack = 0;
        public void FindCombinations(int input, int currentSum, List<int> listOfCombinations, int trace = 1)
        {
            if (currentSum == input)
            {
                Console.WriteLine(string.Join(" ",listOfCombinations));
                return;
            }
            if (currentSum > input) return;

            for (int i = trace ; i <= input; i++)
            {
                listOfCombinations.Add(i);
                int temp = currentSum;
                currentSum += i;

                FindCombinations(input, currentSum, listOfCombinations, listOfCombinations[listOfCombinations.Count - 1]);

                listOfCombinations.RemoveAt(listOfCombinations.Count - 1);
                currentSum = temp;
            }
        }
    }
}
