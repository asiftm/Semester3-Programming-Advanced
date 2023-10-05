using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class Searching
    {
        public int attempts { get; set; }
        public int Linear(int[] array, int number)
        {
            attempts = 0;
            for (int i = 0; i < array.Length; i++)
            {
                attempts++;
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
        public int Stupid(int[] array, int number)
        {
            attempts = 0;

            int counter = 0;
            int maxCount = array.Length*2;

            Random rnd = new Random();
            
            while (counter < maxCount)
            {
                attempts++;

                int index = rnd.Next(0,array.Length);

                if (array[index] == number)
                {
                    return index;
                }
                counter++;
            }
            return -1;
        }
        public int Binary(int[] array, int number)
        {
            attempts = 0;
            int start = 0;
            int end = array.Length -1;

            while (start <= end)
            {
                attempts++;
                int mid = (start + end) / 2;

                if (array[mid] == number)
                {
                    return mid;
                }
                else if (number == array[start])
                {
                    return start;
                }
                else if (number == array[end])
                {
                    return end;
                }
                else if (number < array[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
