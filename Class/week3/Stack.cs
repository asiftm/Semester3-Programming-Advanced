using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Stack
    {
        private string[] Elements { get; set; }
        private int Top { get; set; }
        public Stack(int size)
        {
            Elements = new string[size];
            Top = 0;
        }
        public void Push(string element)
        {
            if(Top == Elements.Length)
            {
                throw new Exception("Stack overflow!");
            }
            Elements[Top] = element;
            Top++;
        }
        public string Pop()
        {
            if(Top == 0)
            {
                throw new Exception("Stack underflow!");
            }
            string temp = Elements[Top-1];
            Elements[Top - 1] = null;
            Top--;
            return temp;
        }
        public override string ToString()
        {
            return string.Join(",", Elements);
        }
    }
}
