using System;
namespace Module_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tree tree = new Tree();

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == null || input.Length == 0) break;
                    input = input.Trim();

                    if (input[0] != 'A' && input[0] != 'D') break;
                    else if (input[1] != ' ')
                    {
                        Console.WriteLine("Crazy input!");
                        break;
                    }

                    int[] ints = Array.ConvertAll(input.Substring(2).Split(" "), int.Parse);

                    foreach (int i in ints)
                    {
                        if (input[0] == 'A') tree.AddNode(i);
                        else if (input[0] == 'D') tree.DeleteNode(i);
                    }
                    tree.InOrderTraversal();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
