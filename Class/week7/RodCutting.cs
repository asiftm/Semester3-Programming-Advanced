using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class RodCutting
    {
        public int[] Prices { get; set; }

        public RodCutting(int[] prices)
        {
            Prices = prices;
        }

        public int Recursion(int n)
        {
            Console.Write("call with n " + n + " ");

            int r = 0;
            if (n <= 0) return Prices[0]; //or r or 0

            for (int i = 1; i <= n; i++)
            {
                //r_n = max(p_i + r_n-i) 1 <= i <= n 
                r = Math.Max(r, Prices[i] + Recursion(n - i));
            }
            return r;
        }

        public int Memoization(int n, int[] memoization)
        {
            //Console.WriteLine("call with n " + n + " ");

            int r = 0;
            if (n <= 0) return Prices[0]; //or r or 0
            if (memoization[n] != 0) return memoization[n];

            for (int i = 1; i <= n; i++)
            {
                //r_n = max(p_i + r_n-i) 1 <= i <= n 
                r = Math.Max(r, Prices[i] + Memoization(n - i, memoization));

                memoization[n] = r;

            }
            return r;
        }

        public int Tabulation(int n)
        {
            if (n <= 0) return Prices[0]; //or 0

            int[] bestPrice = new int[n + 1];
            bestPrice[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int r = 0;

                for (int j = 0; j <= i; j++)
                {
                    r = Math.Max(r, Prices[j] + bestPrice[i - j]);
                    bestPrice[i] = r;

                }
            }
            return bestPrice[n];
        }
    }
}