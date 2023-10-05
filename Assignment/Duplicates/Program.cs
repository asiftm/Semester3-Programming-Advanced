using System.Text.RegularExpressions;

namespace Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FindDuplicate findDuplicate = new FindDuplicate();
                string input = Console.ReadLine();
                string fileName = "words.txt";

                Console.WriteLine(findDuplicate.Search(fileName, input));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}