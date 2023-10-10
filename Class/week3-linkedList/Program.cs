namespace week3_linkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();

            //Console.WriteLine(list);
            //list.Insert(new Node(10));
            //list.Insert(new Node(11));
            //list.Insert(new Node(12));
            //list.Insert(new Node(13));
            //list.Insert(new Node(14));
            //Console.WriteLine(list);
            //Console.WriteLine(list.Search(10));
            //Console.WriteLine(list.Search(12));
            //Console.WriteLine(list.Search(14));
            //Console.WriteLine(list.Search(8));
            //Console.WriteLine(list.Search(20));
            //list.Delete(10);
            //Console.WriteLine(list);
            //list.Delete(14);
            //Console.WriteLine(list);
            //list.Delete(11);
            //Console.WriteLine(list);
            //list.Delete(12);
            //Console.WriteLine(list);



            
            Stack stack = new Stack(5);
            stack.Push("9");
            stack.Push("10");
            stack.Push("hello");
            stack.Push("hello");
            stack.Push("hello");
            stack.Push("hello");

            Console.WriteLine(stack.ToString());

        }
    }
}


