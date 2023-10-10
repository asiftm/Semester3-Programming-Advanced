using System;
using System.Collections.Generic;
using System.Text;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = Array.ConvertAll((Console.ReadLine().Split(' ')), int.Parse);

                if (array.Length == (array[array.Length - 1] - array[0] + 1))
                {
                    Console.WriteLine("No missing number.");
                }
                else
                {
                    Assignment assignment = new Assignment();
                    Console.WriteLine($"{assignment.Missing(array)}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
    class Assignment
    {
        public string Missing(int[] array)
        {
            int length = array.Length;

            int startNum = array[0];
            int endNum = array[array.Length - 1];
            int midNum = array[array.Length / 2];

            int ValueDiffStartMid = midNum - startNum;
            int ValueDiffMidEnd = endNum - midNum;

            int startIndex = 0;
            int endIndex = array.Length - 1;
            int midIndex = endIndex / 2;

            int indexDiffStartMid = midIndex - startIndex;
            int indexDiffMidEnd = endIndex - midIndex;

            if (ValueDiffStartMid - 2 == ValueDiffMidEnd)
            {
                return (midNum - 1).ToString();
            }

            while (length > 1)
            {

                if (length <= 4)
                {
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        int x = (array[i] + 1);
                        int y = (array[i + 1]);
                        if (x != y)
                        {
                            return x.ToString();
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
            return "";
        }
    }
}