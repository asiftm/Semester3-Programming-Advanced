namespace week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NQueens nQueens = new NQueens(20);
            nQueens.PlaceQueens();
            Console.WriteLine(nQueens);
        }
    }
}
