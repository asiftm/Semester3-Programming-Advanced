using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine();
                string fileName = "words.txt";

                Console.WriteLine(assignment.Duplicates(input, fileName));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
    public class Assignment
    {
        public string Duplicates(string start, string filename)
        {
            start = start.ToLower().Trim();
            if (start.Length == 0) return "Crazy input!";

            StreamReader streamReader = File.OpenText(filename);
            string txt = streamReader.ReadToEnd();
            streamReader.Close();
            
            Regex regex = new Regex($"\\b({start})\\w+");
            MatchCollection matchCollection = regex.Matches(txt);

            string output = string.Empty;
            for (int i = 0; i < matchCollection.Count - 1; i++)
            {
                string temp = matchCollection[i].ToString();
                string temp2 = matchCollection[i + 1].ToString();
                if (temp == temp2)
                {
                    output += temp + " ";
                }
            }

            if (output.Length == 0) return "No duplicates found.";
            else return output.Trim();
        }
    }
}
