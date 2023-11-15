namespace Divide_Rule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Sum sum = new Sum();
            Console.WriteLine(sum.Iterative(arr));
            Console.WriteLine(sum.drArray(arr));
            Console.WriteLine(sum.drList(list));


            List<int> unsortedList = new List<int>() { 10, 5, 9 ,7 ,4 ,8, 2, 6, 1, 3};
            QuickSort quickSort = new QuickSort();
            List<int> sortedList = quickSort.SortWithLists(unsortedList);
            Console.WriteLine(string.Join(" ",sortedList));

            int[] array = new int[] { 2, 7, 9, 1, 10, 8, 14, 21, 4, 5, 18, 19 };
            quickSort.Sort(array, 0, array.Length - 1);
            Console.WriteLine(String.Join(" ", array));

            Hanoi hanoi = new Hanoi();
            hanoi.SolveHanoi(2, 'A', 'C', 'B');

        }
    }
}