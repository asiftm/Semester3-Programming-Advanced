using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_04
{
    class Assignment
    {
        public  int Occurences(int number, int[] sequence, int index, int count = 0)
        {
            if (index < 0) return count;

            if (sequence[index] == number) count++;

            return Occurences(number, sequence, index-1, count);
        }
    }
}
