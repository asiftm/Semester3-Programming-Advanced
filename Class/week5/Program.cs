namespace week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NQueens nQueens = new NQueens(4);
            //nQueens.PlaceQueens();
            //Console.WriteLine(nQueens);




            int[] array = new int[] {7,8,9};
            //List<List<int>> result = new List<List<int>>();
            //List<int> subset = new List<int>();

            SubsetProblem subsetProblem = new SubsetProblem();
            //subsetProblem.Solve(array, result, subset);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(" ",item));
            //}
            foreach (var item in subsetProblem.SolveBinary(array))
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}
