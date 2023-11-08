using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    class Assignment
    {
        public string Balance ( string input)
        {
            Stack<char> openStack = new Stack<char>();
            Stack<char> closeStack = new Stack<char>();

            foreach (var bracket in input)
            {
                if(bracket == '(' || bracket == '{' || bracket == '[')
                {
                    openStack.Push(bracket);
                }
            }
            for (int i = input.Length-1; i >= 0; i--)
            {
                if(input[i] == ')' || input[i] == '}' || input[i] == ']')
                {
                    closeStack.Push(input[i]);
                }
            }

            int tempCount = openStack.Count;
            string output = string.Empty;
            for (int i = 0; i <= tempCount; i++)
            {
                if (openStack.Count == 0 && closeStack.Count != 0) return "Too many close symbols";
                else if (openStack.Count != 0 && closeStack.Count == 0) return "Too many open symbols";
                else if(openStack.Count != 0 && closeStack.Count != 0)
                {
                    char a = openStack.Pop();
                    char b = closeStack.Pop();
                    if (!(a == '(' && b == ')'))
                    {
                        if (!(a == '{' && b == '}'))
                        {
                            if (!(a == '[' && b == ']'))
                            {
                                return "Not balanced expression";
                            }
                        }
                    }
                }
            }

            return "Balanced expression";
        }
    }
}
