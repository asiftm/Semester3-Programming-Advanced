using System;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string a = "([{{[()]}}]))";
                //string b = "This {is} a balanced [string]!";
                //string c = "§{{[(])}";
                string a = Console.ReadLine();

                string input = string.Empty;
                foreach (var s in a)
                {
                    if (s == '(' || s == ')' || s == '{' || s == '}' || s == '[' || s == ']')
                    {
                        input += s;
                    }
                }

                Assignment assignment = new Assignment();

                Console.WriteLine(assignment.Balance(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
            
        }
    }
}