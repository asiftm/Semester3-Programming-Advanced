namespace Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = Array.ConvertAll((Console.ReadLine().Split(" ")), int.Parse);

                if (array.Length == (array[array.Length-1] - array[0] + 1))
                {
                    Console.WriteLine("No missing numbers");
                }
                else
                {
                    Searching searching = new Searching();

                    Console.WriteLine($"between {array[0]} and {array[array.Length - 1]}");
                    Console.WriteLine($"the missing number is {searching.LinearMethod(array)} and it took {searching.attempt} attempts in linear method");
                    Console.WriteLine($"the missing number is {searching.Quickest(array)} and it took {searching.attempt} attempt using Array.Sum");
                    Console.WriteLine($"the missing number is {searching.BinaryMethod(array)} and it took {searching.attempt} attempts in binary method");
                }
            }
            catch (Exception){
                Console.WriteLine("Something Wrong");
            }
        }
    }
}