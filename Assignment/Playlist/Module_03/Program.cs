using System.Threading.Channels;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();

            string[] input = Console.ReadLine().Split(" ");
            string[] sequenceOfOperations = Console.ReadLine().Split(" ");
            string currentSong = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                playlist.Add(input[i]);
            }
            Console.Write(playlist.NowPlaying(currentSong) + " ");
            for (int i = 0; i < sequenceOfOperations.Length; i++)
            {
                if (sequenceOfOperations[i] == "next")
                {
                    Console.Write(playlist.Next() + " ");
                }
                else if (sequenceOfOperations[i] == "previous")
                {
                    Console.Write(playlist.Previous() + " ");
                }
                else if (sequenceOfOperations[i].Contains("add:"))
                {
                    playlist.Add(sequenceOfOperations[i].Substring(4));
                }
                else if (sequenceOfOperations[i].Contains("remove:"))
                {
                    playlist.Remove(sequenceOfOperations[i].Substring(7));
                }
            }
        }
    }
}
