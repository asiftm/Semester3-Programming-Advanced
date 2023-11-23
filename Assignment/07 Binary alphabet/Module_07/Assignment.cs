using System;
namespace Module_07
{
    class Assignment
    {
        public string Sequence(int input)
        {
            string output = string.Empty;
            for (int i = 1; i <= input; i++)
            {
                string binary = Convert.ToString(i, 2);
                //Console.WriteLine(binary);
                int start = 97; //ascii value of 'a'

                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1') output += Convert.ToChar(start);

                    start++;
                }
                output += " ";
            }
            return output;
        }
    }
}
