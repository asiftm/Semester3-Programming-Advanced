using System;

namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = "apple".ToCharArray();
            Words words = new Words();

            List<List<char>> set = new List<List<char>>();
            List<char> subsets = new List<char>();

            words.Combinations(input, set, subsets);

            foreach (char c in input)
            {
                Console.WriteLine(c);
            }

            ////check in the file
            //List<string> output = new List<string>();

            ////raeding the file
            //StreamReader read = File.OpenText("english.txt");
            //string[] text = read.ReadToEnd().Split("\n");
            //read.Close();


            //foreach (var item in results)
            //{
            //    string combination = string.Join("", item);
            //    if (text.Contains(combination))
            //    {
            //        Console.WriteLine(combination);
            //    }
            //}
        }
    }
}