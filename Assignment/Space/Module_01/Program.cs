using System;
using System.Collections.Generic;
using Module_02;
namespace Space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string read;
            string input = string.Empty;
            
            while ((read = Console.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(read))
                {
                    break;
                }
                input += read;
            }
            Assignment assignment = new Assignment();
            Console.WriteLine(assignment.Space(input.Trim()).Trim());
        }
    }
}
