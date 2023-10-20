using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    class Assignment
    {
        public int Multiplication(int a, int b)
        {
            if (b < 1) return 0;
            return (a + (Multiplication(a, b-1)));
        }
    }
}
