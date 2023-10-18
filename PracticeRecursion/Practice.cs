using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRecursion
{
    internal class Practice
    {
        public int Sum(int n)
        {
            if (n == 1) return 1;
            return n + Sum(n - 1);
        }
        public int Count(int n)
        {
            if (n < 10) return 1;
            return 1 + Count(n / 10);
        }
        public int Factorial(int a)
        {
            if (a < 1) return 1;
            return a * Factorial(a-1);
        }
        public string ReverseString(string example)
        {
            if(example == string.Empty)
            {
                return string.Empty;
            }
            return ReverseString(example.Substring(1)) + example[0];
        }
        public bool isPalindrome(string input)
        {
            if(input.Length <= 1) return true;

            if (input[0] == input[input.Length-1])
            {
                return isPalindrome(input.Substring(1, input.Length - 2));
            }
            return false;
        }
        public string DecToBin(int inputDecimal, string result)
        {
            if(inputDecimal == 0) return result;

            result = inputDecimal % 2 + result;

            return DecToBin(inputDecimal/2, result);
        }
        public int BinarySearch(int[] arr, int start, int end, int input)
        {
            if (start > end) return -1;

            int mid = (start + end) / 2;

            if (input == arr[mid]) return mid;

            if (input < arr[mid]) return BinarySearch(arr, start, mid - 1, input);
            
            return BinarySearch(arr, mid + 1, end, input);
        }
        public bool isFibonacci(int input, int a = 0, int b = 1)
        {
            if ( a + b == input || a == input || b == input) return true;
            if ( a + b > input || input < 1) return false;

            return isFibonacci(input, b, a + b );
        }
    }
}
