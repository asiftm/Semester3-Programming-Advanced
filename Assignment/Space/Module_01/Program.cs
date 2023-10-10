using System.Drawing;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input.Trim() != string.Empty)
            {
                string messageArray = input.Replace("TS: ", "").Replace(", fragment: ", " ").Replace("\"", "");
                Console.WriteLine(input);
            }

            //string input = Console.ReadLine();
            //Assignment assignment = new Assignment();
            //Console.WriteLine(assignment.Space(input));
        }
    }
    public class Assignment
    {
        public string Space(string input)
        {
            string[] messageArray = input.Replace("TS: ", "").Replace(", fragment: ", " ").Replace("\"", " ").Split(' ');
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (string line in messageArray)
            {
                dict[int.Parse(line.Split(" ")[0])] = line.Split(" ")[1];
            }
            string output = string.Empty;
            for (int i = 1; i <= dict.Count; i++)
            {
                output += dict[i].Trim() + " ";
            }
            return output;
        }
    }
}