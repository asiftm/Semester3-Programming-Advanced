namespace PracticeRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice practice = new Practice();

            Console.WriteLine(practice.Factorial(6));
            Console.WriteLine(practice.FactorialRecursion(6));

            int[] array = {2, 6, 9, 8, 4, 1, 7, 3, 5};
            Console.WriteLine(practice.Sum(array));
            Console.WriteLine(practice.SumRecursion(array));
        }
    }
}