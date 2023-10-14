using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class EX1
    {
        public int Sum(int n)
        {
            if (n == 1) return 1;
            return n + Sum(n - 1); 
        }
        public int Count(int n)
        {
            if(n<10) return 1;
            return 1 + Count(n/10);
        }
        public string Reverse(string s)
        {
            if(s.Length == 1) return s;

            //return Reverse(s.Substring(1, s.Length - 1)) + s[0];
            return s[s.Length - 1] + Reverse(s.Substring(0,s.Length-1));
        }
    }
}
