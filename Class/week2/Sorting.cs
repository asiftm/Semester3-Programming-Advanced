using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class Sorting
    {
        public int[] Bubble(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length - 1; j++)
                {
                    int temp = ints[j];
                    int value1 = ints[j];
                    int value2 = ints[j + 1];

                    if (ints[j] > ints[j + 1])
                    {
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }
            return ints;
        }
        public int[] ReverseBubbleSort(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length - 1; j++)
                {
                    int temp = ints[j];
                    int value1 = ints[j];
                    int value2 = ints[j + 1];

                    if (ints[j] < ints[j + 1])
                    {
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }

            return ints;
        }
        public override string ToString()
        {

        }
    }
}
