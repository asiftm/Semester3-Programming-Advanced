using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Module_06;
namespace Module_06
{
    public class Missing_Link
    {
        //public void Sort(int[] array, int low, int high)
        //{
        //    if (low < high)
        //    {
        //        int p = Partition(array, low, high);
        //        Sort(array, low, p);
        //        Sort(array, p + 1, high);
        //    }
        //}

        //public int Partition(int[] array, int low, int high)
        //{
        //    int pivot = array[(high + low) / 2];

        //    int i = low - 1;
        //    int j = high + 1;

        //    while (true)
        //    {
        //        do
        //        {
        //            i++;
        //        }
        //        while (array[i] < pivot);

        //        do
        //        {
        //            j--;
        //        }
        //        while (array[j] > pivot);

        //        if (i >= j) return j;
        //        int swap = array[i];
        //        array[i] = array[j];
        //        array[j] = swap;
        //    }
        //}

        public string GetMissingLink(int[] ints, int posNum = 1)
        {
            if (posNum >= ints.Length-1) return "No missing link";
            if (!ints.Contains(posNum)) return posNum.ToString();
            return GetMissingLink(ints, ++posNum);
        }
    }
}