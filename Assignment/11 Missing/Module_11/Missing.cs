using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    class Missing
    {
        public void BruteForce(int[] ints, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool b = false;

                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[j] == i) b = true;
                }
                if (!b) Console.WriteLine(i);
            }
        }
        public void ArrayIndexMethod(int[] ints, int n)
        {
            bool isMissing = false;
            int[] temp = new int[n+1];
            for (int i = 0; i < ints.Length; i++)
            {
                if(ints[i] <= n) temp[ints[i]] = ints[i];
            }
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == 0)
                {
                    isMissing = true;
                    Console.WriteLine(i);
                }
            }
            if (!isMissing) Console.WriteLine("No missing integers!");
        }
    }
}
