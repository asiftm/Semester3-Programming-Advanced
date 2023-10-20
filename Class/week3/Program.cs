using System;

namespace week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linkedlist();
            void Linkedlist()
            {
                LinkedList linkedList = new LinkedList();

                linkedList.Insert(new Node(5));
                linkedList.Insert(new Node(7));
                linkedList.Insert(new Node(1));
                linkedList.Insert(new Node(6));
                linkedList.Insert(new Node(3));

                linkedList.Delete(5);
                linkedList.Delete(1);
                linkedList.Delete(3);

                Console.WriteLine(linkedList.Search(3));
                Console.WriteLine(linkedList.Search(5));
                Console.WriteLine(linkedList.Search(1));
                Console.WriteLine(linkedList.Search(2));

                Console.WriteLine(linkedList);

                linkedList.Insert(new Node(2));
                Console.WriteLine(linkedList.Search(2));
                Console.WriteLine(linkedList);
            }

            Stack();
            void Stack()
            {
                Stack stack = new Stack(5);

                stack.Push("apple");
                stack.Push("orange");
                stack.Push("pineapple");
                stack.Push("mango");
                stack.Push("coconut");

                Console.WriteLine(stack.ToString());

                stack.Pop();
                stack.Pop();
                stack.Pop();

                Console.WriteLine(stack.ToString());
            }
        }
    }
}