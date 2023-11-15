namespace week7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Fibonacci fibonacci = new Fibonacci();
            int n = 10;

            //Console.WriteLine(fibonacci.Recursion(n));
            //Console.WriteLine(fibonacci.Memorization(n, new int[n+1]));
            Console.WriteLine(fibonacci.Tabulation(n));
            Console.WriteLine(fibonacci.Iterative(n));
        }
    }
}