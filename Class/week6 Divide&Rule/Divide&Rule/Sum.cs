using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Rule
{
    internal class Sum
    {
        public int Iterative(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public int drArray(int[] arr, int index = 0)
        {
            if (index == arr.Length) return 0;

            return arr[index] + drArray(arr,index+1);
        }
        public int drList(List<int> list)
        {
            if (list.Count == 1) return list[0];

            int value = list[0];
            list.Remove(value);

            return value + drList(list);
        }
    }
}
