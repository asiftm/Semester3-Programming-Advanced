using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space;
using System.Text.RegularExpressions;

namespace Module_02
{
    public class Assignment
    {
        public string Space(string input)
        {
            try
            {
                
                //if(!input.Contains(", fragment: \""))
                //{
                //    return "Crazy input!";
                //}
                //string a = input.Replace("TS: ", "").Replace(", fragment: \"", " ").Replace("\"", "|");
                //string[] messageArray = a.Remove(a.Length - 1).Split("|");

                //Dictionary<int, string> dict = new Dictionary<int, string>();
                //foreach (string line in messageArray)
                //{
                //    dict[int.Parse(line.Split(" ")[0])] = line.Split(" ")[1];
                //}
                //List<int> keyList = dict.Keys.ToList();
                //keyList.Sort();
                //string output = string.Empty;
                //foreach (int key in keyList)
                //{
                //    ;
                //}
                //return output;

                string output = string.Empty;

                string pattern = @"TS: (\d+), fragment: ""([^""]+)""";
                MatchCollection matches = Regex.Matches(input, pattern);

                if (matches.Count == 0) return "Crazy input!";

                Dictionary<int, string> dict = new Dictionary<int, string>();
                List<int> list = new List<int>();
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        int num = int.Parse (match.Groups[1].Value);
                        string text = match.Groups[2].Value;
                        list.Add(num);
                        dict[num] = text;
                    }
                }
                list.Sort();
                foreach (int key in list)
                {
                    if (dict.ContainsKey(key))
                    {
                        output += dict[key] + " ";
                    }
                }
                if(output.Length == 0) return "Crazy input!";
                
                return output;
            }

            catch (Exception ex)
            {
                return "Crazy input!";
            }
        }
    }
}
