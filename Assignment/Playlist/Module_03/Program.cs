using System;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string[] sequenceOfOperations = Console.ReadLine().Split(" ");
            string currentSong = Console.ReadLine();

            if(currentSong == string.Empty)
            {
                Console.WriteLine("Crazy input!");
                Environment.Exit(0);
            }

            Playlist playlist = new Playlist();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                playlist.Add(input[i]);
            }

            output += (playlist.NowPlaying(currentSong) + " ");

            for (int i = 0; i < sequenceOfOperations.Length; i++)
            {
                if (sequenceOfOperations[i] == "next")
                {
                    output+=(playlist.Next() + " ");
                }
                else if (sequenceOfOperations[i] == "previous")
                {
                    output += (playlist.Previous() + " ");
                }
                else if (sequenceOfOperations[i].Contains("add:"))
                {
                    playlist.Add(sequenceOfOperations[i].Substring(4));
                }
                else if (sequenceOfOperations[i].Contains("remove:"))
                {
                    playlist.Remove(sequenceOfOperations[i].Substring(7));
                }
                else
                {
                    Console.WriteLine("Crazy input!");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine(output.Trim());
        }
    }
}
