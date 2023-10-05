namespace week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt"), Int32.Parse);

            Searching searching = new Searching();

            int number = 998;

            //Console.WriteLine($"Linear: {number} {searching.Linear(array, number)}, attempts {searching.attempts}");
            //Console.WriteLine($"Stupid: {number} {searching.Stupid(array, number)}, attempts {searching.attempts}");
            //Console.WriteLine($"Binary: {number} {searching.Binary(array, number)}, attempts {searching.attempts}");

            //Console.WriteLine(array[100]);

        }
    }
}