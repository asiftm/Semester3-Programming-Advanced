using System;
namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MagicSquare magicSquare = new MagicSquare(4);
            string output = magicSquare.Create();
            Console.WriteLine(output);
        }
    }
}