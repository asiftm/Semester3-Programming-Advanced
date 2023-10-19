using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    class Playlist
    {
        public Node CurrentNode { get; set; }
        public Playlist()
        {
            CurrentNode = null;
        }
        public Playlist(Node node)
        {
            CurrentNode = node;
        }
        //public string Next()
        //{
        //    if (CurrentNode.NextNode == null)
        //    {
        //        return "empty";
        //    }
        //    else if(CurrentNode.Data == null)
        //    {
        //        CurrentNode = 
        //    }
        //    else
        //    {
        //        CurrentNode = CurrentNode.NextNode;
        //        return CurrentNode.Data;
        //    }
        //}
        public void Add(string song)
        {
            Node node = new Node(song);

            if (CurrentNode == null)
            {
                CurrentNode = node;
            }
            else
            {
                Node temp = CurrentNode;
                while (temp.NextNode != null)
                {
                    temp = temp.NextNode;
                }
                temp.NextNode = node;
            }
        }
        public void Remove(string song)
        {
            if(CurrentNode.Data == song)
            {
                CurrentNode = CurrentNode.NextNode;
                return;
            }
            
            Node temp = CurrentNode;

            while (temp.NextNode != null)
            {
                if(temp.NextNode.Data == song)
                {
                    temp.NextNode = temp.NextNode.NextNode;
                    return;
                }
                temp = temp.NextNode;
            }

        }
    }
}
