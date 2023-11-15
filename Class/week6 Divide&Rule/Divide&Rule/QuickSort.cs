using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Rule
{
    internal class QuickSort
    {
        public List<int> SortWithLists(List<int> list)
        {
            if(list.Count <= 1) return list;

            int pivot = list[0];

            List<int> smaller = new List<int>();
            List<int> grater = new List<int>();

            foreach (int i in list)
            {
                if (i < pivot) smaller.Add(i);
                else if (i > pivot) grater.Add(i);
            }
            return SortWithLists(smaller).Union(new List<int> { pivot }).Union(SortWithLists(grater)).ToList<int>();
        }
        public void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(array, low, high);
                Sort(array, low, p);
                Sort(array, p + 1, high);
            }
        }

        public int Partition(int[] array, int low, int high)
        {
            int pivot = array[(high + low) / 2];

            int i = low - 1;
            int j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                }
                while (array[i] < pivot);

                do
                {
                    j--;
                }
                while (array[j] > pivot);

                if (i >= j) return j;
                int swap = array[i];
                array[i] = array[j];
                array[j] = swap;
            }
        }
    }
}
