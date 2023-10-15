using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSorting
{
    internal class Sort
    {
        public int[] BubbleSort(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                bool isSorted = false;
                for (int j = 0; j < ints.Length - 1; j++)
                {
                    if(ints[j] > ints[j + 1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j+1] = temp;
                        isSorted = true;
                    }
                }
                if (!isSorted) return ints;
            }
            return ints;
        }
        public int[] InsertionSort(int[] ints)
        {
            for(int i  = 1; i < ints.Length; i++)
            {
                int currentNum = ints[i];
                int j = i-1;
                while (j >= 0 && ints[j] > currentNum )
                {
                    ints[j+1] = ints[j];
                    j--;
                }
                ints[j+1] = currentNum;
            }
            return ints;
        }
        public int[] SelectionSort(int[] ints)
        {
            for (int i = 0; i < ints.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[min] > ints[j])
                    {
                        min = j;
                    }
                }
                int temp = ints[min];
                ints[min] = ints[i];
                ints[i] = temp;
            }
            return ints;
        }
        public int[] MergeSort(int[] ints)
        {
            return ints;
        }
        public int[] QuickSort(int[] ints)
        {
            return ints;
        }
    }
}
