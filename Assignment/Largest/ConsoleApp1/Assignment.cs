using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Module_02
{
    internal class Assignment
    {
        public string Largest(string input)
        {
            string[] strings = input.Split(' ');
            int[] ints = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                ints[i] = int.Parse(strings[i]);
            }

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
            int index = 0;
            int lengthOfLargestNum = ints[ints.Length - 1].ToString().Length;
            Dictionary<int, string> dict = new Dictionary<int, string>();
            for (int i = 1; i <= lengthOfLargestNum; i++)
            {
                string numbers = string.Empty;
                for (int j = index; j < ints.Length - 1; j++)
                {
                    int a = ints[j];
                    int lengthOfDigit = a.ToString().Length;
                    if (lengthOfDigit > i)
                    {
                        break;
                    }
                    index++;
                    numbers += a.ToString();
                }
                dict[i] = numbers + " ";
            }

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            return "x";
        }
    }
}


