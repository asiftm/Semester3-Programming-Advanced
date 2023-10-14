using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Module_01
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
                    Assignment findText = new Assignment();
                    string fileName = "words.txt";
                    Console.WriteLine(findText.NthCharacter(fileName, targetIndex));
                }
                else
                {
                    Console.WriteLine("Crazy input!");
                }
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
    public class Assignment
    {
        public string NthCharacter(string fileName, int index)
        {
            try
            {   
                if (index.ToString().Contains(".")) return "Crazy input!";

                StreamReader streamReader = File.OpenText(fileName);
                string[] textArray = streamReader.ReadToEnd().Split('\n');

                if (index < 0 || index > textArray.Length * 10) return "Crazy input!";

                char[] targetLineOfString = textArray[index / 10].ToCharArray();
                return targetLineOfString[index % 10].ToString();
            }
            catch
            {
                return "Crazy input!";
            }
        }
    }
}
