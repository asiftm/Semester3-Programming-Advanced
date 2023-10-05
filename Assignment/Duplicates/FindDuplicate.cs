using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Duplicates
{
    internal class FindDuplicate
    {
        public string Search(string fileName, string input) 
        {

            StreamReader streamReader = File.OpenText(fileName);
            string txt = streamReader.ReadToEnd();
            streamReader.Close();

            Regex regex = new Regex($"\\b({input})\\w+");
            MatchCollection matchCollection = regex.Matches(txt);
            Match[] matchArray = matchCollection.Cast<Match>().ToArray();

            string output = string.Empty;
            for (int i = 0; i < matchArray.Length - 1; i++)
            {
                string temp = matchArray[i].ToString();
                string temp2 = matchArray[i + 1].ToString();
                if (temp == temp2)
                {
                    output += temp + " ";
                }
            }

            if (output.Length == 0)
            {
                return "No duplicates found.";
            }
            else
            {
                return output;
            }
        }
    }
}

