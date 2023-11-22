using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
namespace Module_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();

                Console.WriteLine(assignment.Sequence(Convert.ToInt16(Console.ReadLine())));
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy input");
            }
            
        }
    }
}