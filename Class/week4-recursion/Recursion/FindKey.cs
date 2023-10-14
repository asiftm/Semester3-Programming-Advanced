using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class FindKey
    {
        public int Counter { get; set; }
        public string Algorithm1(string folder)
        {
            Queue<string> folders = new Queue<string>();
            folders.Enqueue(folder);
            while (folders.Count > 0)
            {
                folder = folders.Dequeue();

                if (Directory.Exists(folder))
                {
                    if (Directory.GetFiles(folder).Length > 0) return folder;

                    foreach (string item in Directory.GetDirectories(folder))
                    {
                        folders.Enqueue(item);
                    }
                }
            }
            return "not found";
        }
        public string Algorithm2(string folder)
        {
            foreach(string item in Directory.EnumerateFileSystemEntries(folder))
            {
                if(Directory.Exists (item))
                {
                    string result = Algorithm2(item);
                    if (result != "not found") return result;
                }
                if(File.Exists(item))
                {
                    return item;
                }
            }
            return "not found";
        }
    }
}







