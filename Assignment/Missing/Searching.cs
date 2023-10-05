using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Missing
{
    internal class Searching
    {
        public int attempt { get; set; }
        public int LinearMethod(int[] array)
        {
            attempt = 0;
            for (int i = 0; i<array.Length - 1; i++)
            {
                attempt++;

                if (array[i] + 1 != array[i + 1])
                {
                    return array[i] + 1;
                }
            }
            return -1;
        }

        public int BinaryMethod(int[] array)
        {
             attempt = 0;

            int length = array.Length;

            int startNum = array[0];
            int endNum = array[array.Length - 1];
            int midNum = array[array.Length/2];

            int ValueDiffStartMid = midNum - startNum;
            int ValueDiffMidEnd = endNum - midNum;

            int startIndex = 0;
            int endIndex = array.Length-1;
            int midIndex = endIndex / 2;

            int indexDiffStartMid = midIndex - startIndex;
            int indexDiffMidEnd = endIndex - midIndex;                             
            
            if(ValueDiffStartMid-2 == ValueDiffMidEnd)
            {
                attempt++;
                return midNum-1;
            }

            while (length > 1)
            {
                attempt++;

                if (length <= 4)
                {
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        attempt++;
                        int x = (array[i] + 1);
                        int y = (array[i + 1]);
                        if (x != y)
                        {
                            return x;
                        }
                    }
                }
                else if (indexDiffStartMid != ValueDiffStartMid)
                {
                    endIndex = midIndex;
                    midIndex = (endIndex + startIndex) / 2;

                    indexDiffStartMid = midIndex - startIndex;
                    indexDiffMidEnd = endIndex - midIndex;

                    startNum = array[startIndex];
                    endNum = array[endIndex];
                    midNum = array[midIndex];

                    ValueDiffStartMid = midNum - startNum;
                    ValueDiffMidEnd = endNum - midNum;

                    length = endIndex - startIndex + 1;

                }
                else if (indexDiffMidEnd != ValueDiffMidEnd)
                {
                    startIndex = midIndex;
                    midIndex = (endIndex + startIndex) / 2;

                    indexDiffStartMid = midIndex - startIndex;
                    indexDiffMidEnd = endIndex - midIndex;

                    startNum = array[startIndex];
                    endNum = array[endIndex];
                    midNum = array[midIndex];

                    ValueDiffStartMid = midNum - startNum;
                    ValueDiffMidEnd = endNum - midNum;

                    length = endIndex - midIndex + 1;
                }
            }
            return -1;
        }
        public double Quickest(int[] array)
        {
            attempt = 0;
            attempt++;
            double sumWithMissing = array.Sum();
            double sumWithoutMissing = (((double)array.Length+1) / 2) * ((2 * array[0])+ (double)array.Length);

            return sumWithoutMissing - sumWithMissing;
        }
    }
}
