using System;
namespace Module_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                CipherText cipherText = new CipherText();
                Console.WriteLine(cipherText.Decrypt(input.Trim().ToLower()));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}