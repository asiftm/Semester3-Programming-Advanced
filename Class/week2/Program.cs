namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 5, 1, 4, 3, 7, 0, 2, 6, 9, 8 };

            Sorting sorting = new Sorting();

            foreach (int i in sorting.Bubble(ints))
            {
                Console.WriteLine(i);
            }
            foreach (int i in sorting.ReverseBubbleSort(ints))
            {
                Console.WriteLine(i);
            }
            
        }
    }
}