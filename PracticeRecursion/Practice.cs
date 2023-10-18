using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRecursion
{
    internal class Practice
    {
        public int Factorial(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
        public int FactorialRecursion(int a)
        {
            if (a < 1) return 1;
            return a * FactorialRecursion(a-1);
        }
        public int Sum(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
        public int SumRecursion(int[] array)
        {
            return 8;
        }
    }
}
