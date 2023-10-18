namespace PracticeRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice practice = new Practice();

            Console.WriteLine(practice.Sum(10));

            Console.WriteLine(practice.Count(12345));

            Console.WriteLine(practice.Factorial(6));

            Console.WriteLine(practice.ReverseString("the simple engineer"));

            Console.WriteLine(practice.isPalindrome("racecar"));

            Console.WriteLine(practice.DecToBin(233,""));

            int[] arr = { -4, -1, 0, 2, 3, 5, 8, 11, 17, 18, 20 };
            Console.WriteLine(practice.BinarySearch( arr, 0, arr.Length - 1, -2));

            Console.WriteLine(practice.isFibonacci(4));
        }
    }
}