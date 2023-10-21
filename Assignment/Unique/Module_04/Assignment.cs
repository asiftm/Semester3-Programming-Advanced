using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_04
{
    class Assignment
    {
        public string output = string.Empty;
        public string Unique(string input,int length, int index = 0)
        {
            if(index == length) return output;

            if (input[index] != input[index + 1]) output += input[index];
            
            return Unique(input, length, index+1);
        }
    }
}
