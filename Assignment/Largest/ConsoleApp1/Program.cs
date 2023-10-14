using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_02;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "13 13 130 40 403 21 3";
            Assignment assignment = new Assignment();
            Console.WriteLine(assignment.Largest(input));
        }
    }
}