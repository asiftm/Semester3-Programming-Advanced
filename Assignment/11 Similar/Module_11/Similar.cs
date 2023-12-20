using System;
using System.Collections.Generic;
namespace Module_11
{
    internal class Similar
    {
        Dictionary<char,char> Chart;

        public Similar(string input)
        {
            Chart = new Dictionary<char, char>(input.Length);
        }
        public string IsSimilar(string input1, string input2)
        {
            for (int i = 0; i < input1.Length; i++)
            {
                if (!Chart.ContainsKey(input2[i]))
                {
                    Chart[input2[i]] = input1[i];
                }
                else if (Chart[input2[i]] != input1[i])
                {
                    return "False";
                }
            }
            return "True";
        }
    }
}
