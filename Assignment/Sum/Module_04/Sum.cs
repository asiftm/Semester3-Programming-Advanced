using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_04
{
    class Sum
    {
        public int Result = 0;
        public int DoSum(string input, int index)
        {
            if (index < 0) return Result;

            try
            {
                string x = input[index].ToString();
                int a = Convert.ToInt32(x);
                Result += a;
            }
            catch { }

            return DoSum(input, index-1);
        }
    }
}
