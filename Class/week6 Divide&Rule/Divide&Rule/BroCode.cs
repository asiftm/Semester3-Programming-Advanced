using System;
namespace Divide_Rule
{
    class BroCode
    {
        public void QuickSort(int[] array, int start, int end)
        {
            if (end <= start) return; //base case

            int pivot = partition(array, start, end);

            QuickSort(array, start, pivot - 1);

            QuickSort(array, pivot + 1, end);
        }
        private int partition(int[] array, int start, int end)
        {

            int pivot = array[end];
            int i = start - 1;
            int temp = 0;

            for (int j = start; j <= end; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            i++;
            temp = array[i];
            array[i] = array[end];
            array[end] = temp;

            return i;
        }
    }

}