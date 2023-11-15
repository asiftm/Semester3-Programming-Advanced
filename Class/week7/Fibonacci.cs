using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class Fibonacci
    {
        public int Recursion(int a)
        {
            if (a < 0) throw new ArgumentException("Crazy input!");
            if(a == 0) return 0;
            if(a == 1) return 1;

            return Recursion(a - 1) + Recursion(a-2);
        }
        public int Memorization(int n, int[] memorization)
        {
            if (n < 0) throw new ArgumentException("Crazy input!");

            if(n == 0) return 0;
            if(n == 1) return 1;

            if (memorization[n] != 0) return memorization[n];

            memorization[n] = Memorization(n - 1, memorization) + Memorization(n-2, memorization);

            return memorization[n];
        }
        public int Tabulation(int n)
        {
            if (n < 0) throw new Exception("Crazy input");

            int[] tabulation = new int[n + 1];

            tabulation[0] = 0;
            tabulation[1] = 1;

            for (int i = 2; i <= n ; i++)
            {
                tabulation[i] = tabulation[i-1] + tabulation[i-2];
            }
            return tabulation[n];
        }
        public int Iterative(int n)
        {
            if (n < 0) throw new Exception("Crazy input");

            int fib0 = 0;
            int fib1 = 1;

            int fib = 0;

            for (int i = 2; i <= n ; i++)
            {
                fib = fib0 + fib1;
                fib0 = fib1;
                fib1 = fib;
            }
            return fib;
        }

    }
}
