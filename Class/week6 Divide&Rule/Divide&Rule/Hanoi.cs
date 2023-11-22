using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Rule
{
    internal class Hanoi
    {
        public void SolveHanoi( int number, char from, char to, char other)
        {
            if (number == 1) Console.WriteLine($"{number}: {from} to {to}");
            else
            {
                SolveHanoi(number - 1, from, other, to);
                Console.WriteLine($"{number}: {from} to {to}");
                SolveHanoi(number - 1, other, to, from);
            }
        }
    }
}
