using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_04
{
    class Assignment
    {
        public int Minimum(int[] input, int index, int minimum)
        {
            if (index < 1) return minimum;

            if(minimum > input[index - 1])
            {
                minimum = input[index - 1];
            }
            return Minimum(input, index-1, minimum);
        }
    }
}
