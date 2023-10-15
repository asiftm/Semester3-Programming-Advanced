using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {
            Head = null;
        }
        public LinkedList(Node head)
        {
            Head = head;
        }
        public void Insert(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Last().Next = node;
            }
        }
        private Node Last()
        {
            Node iterator = Head;
            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }
            return iterator;
        }
        public void Delete(int data)
        {
            if(Head.Data == data)
            {
                Head = Head.Next;
                return;
            }
            Node iterator = Head;
            while(iterator.Next != null)
            {
                if(iterator.Next.Data == data)
                {
                    iterator.Next = iterator.Next.Next;
                    return;
                }
                iterator = iterator.Next;
            }
        }
        public bool Search(int data)
        {
            Node iterator = Head;
            while (iterator.Next != null)
            {
                if(iterator.Data == data)
                {
                    return true;
                }
                iterator = iterator.Next;
            }
            if(iterator.Data == data)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            if( Head == null)
            {
                return "Empty list";
            }
            string list = string.Empty;
            Node iterator = Head;
            while (iterator.Next != null)
            {
                list += iterator.Data + "-->>";
                iterator = iterator.Next;
            }
            list += iterator.Data;
            return list;
        }
    }
}
