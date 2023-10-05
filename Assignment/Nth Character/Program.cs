namespace Nth_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int targetIndex))
                {
                    FindText findText = new FindText();
                    string fileName = "words.txt";
                    Console.WriteLine(findText.FindCharacter(fileName, targetIndex));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please write a valid integer");
                }
            }
            catch 
            {
                Console.WriteLine("Something wrong");
            }
        }
    }
}



