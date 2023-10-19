using System.Threading.Channels;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();

            string[] input = "song1 song2 song3 song4 song5".Split(" "); //Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                playlist.Add(input[i]);
            }
            playlist.Remove("song2");
            //Console.WriteLine(playlist.Next());
            //Console.WriteLine(playlist.Next());
            //Console.WriteLine(playlist.Next());
            //Console.WriteLine(playlist.Next());
            //Console.WriteLine(playlist.Next());
            //Console.WriteLine(playlist.Next());
        }
    }
}