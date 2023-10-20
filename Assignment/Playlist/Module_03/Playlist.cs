using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    class Node
    {
        public string Data { get; set; }
        public Node PreviousNode { get; set; }
        public Node NextNode { get; set; }
        public Node(string nodeData)
        {
            Data = nodeData;
            PreviousNode = null;
            NextNode = null;
        }
    }
    class Playlist
    {
        public Node CurrentNode { get; set; }
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Playlist()
        {
            CurrentNode = null;
            Head = null;
            Tail = null;
        }
        public void Add(string song)
        {
            Node node = new Node(song);

            if (CurrentNode == null)
            {
                CurrentNode = node;
                CurrentNode.NextNode = node;
                CurrentNode.PreviousNode= node;
                Head = node;
                Tail = node;
            }
            else
            {
                Node temp = Tail;
                temp.NextNode = node;
                Tail = node;
                node.NextNode = Head;
                node.PreviousNode = temp;
                temp = node;
            }
            Head.PreviousNode = Tail;
            Tail.NextNode = Head;
        }
        public void Remove(string song)
        {
            Node temp = CurrentNode;

            if(Head.Data == song && Tail.Data == song && CurrentNode.Data == song)
            {
                CurrentNode = null;
                Head = null;
                Tail = null;
                return;
            }

            while (temp.NextNode != null)
            {
                if(temp.NextNode.Data == song)
                {
                    if(temp.NextNode == Head)
                    {
                        Head = temp.NextNode.NextNode;
                    }
                    else if(temp.NextNode == Tail)
                    {
                        Tail = temp;
                        CurrentNode = CurrentNode.PreviousNode;
                    }
                    temp.NextNode = temp.NextNode.NextNode;
                    temp.NextNode.PreviousNode = temp;
                    return;
                }
                temp = temp.NextNode;
            }
        }
        public string NowPlaying(string song)
        {
            if (Head.Data == song) return CurrentNode.Data;
            else if (Tail.Data == song)
            {
                CurrentNode = Tail;
                return CurrentNode.Data;
            }

            Node temp = CurrentNode;
            for (Node i = Head; i != Tail; i = i.NextNode)
            {
                if (temp.NextNode.Data == song)
                {
                    CurrentNode = temp.NextNode;
                    return CurrentNode.Data;
                }
                temp = temp.NextNode;
            }
            CurrentNode = Tail;
            return "Not found";
        }
        public string Next()
        {
            if(CurrentNode == null) return "empty";

            CurrentNode = CurrentNode.NextNode;
            return CurrentNode.Data;
        }
        public string Previous()
        {
            if (CurrentNode == null) return "empty";

            CurrentNode = CurrentNode.PreviousNode;
            return CurrentNode.Data;
        }
    }
}
