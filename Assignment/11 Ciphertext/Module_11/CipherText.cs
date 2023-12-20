using System;
using System.IO;
namespace Module_11
{
    public class CipherText
    {
        public string Decrypt(string input)
        {
            StreamReader read = File.OpenText("english.txt");
            string result = "Crazy input!";
            while (result == "Crazy input!")
            {
                string line = read.ReadLine();
                if (line == null) break;
                else if(line.Length == input.Length)
                {
                    result = GetResult(input, line);
                }
            }
            return result;
        }
        private string GetResult(string input, string line)
        {
            if(line == "PAPER")
            {
                Console.WriteLine("yes");
            }
            bool corrcectShift = true;
            int diff = CalculateKey(input[0], line[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (diff != CalculateKey(input[i], line[i]))
                {
                    corrcectShift = false;
                    break;
                }
            }
            if (corrcectShift) return $"Shift {diff} - {line.ToUpper()}";
            return "Crazy input!";
        }
        private int CalculateKey(char v1, char v2)
        {
            if (v1 >= v2) return v1 - v2;
            else
            {
                if(v1 + 123 - 97 - v2 <= 26) return v1 + 123 - 97 - v2;
                else return v2 - v1;
            }        
        }
    }
}
