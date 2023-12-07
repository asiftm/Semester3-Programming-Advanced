namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookHash book = new BookHash(20);

            Console.WriteLine(book.GetSize());

            book.AddItem("apple", 0.67);
            book.AddItem("pear", 0.79);
            book.AddItem("eggs", 2.49);
            book.AddItem("milk", 1.49);
            book.AddItem("avocado", 1.79);
            book.AddItem("cream", 5.49);
            book.AddItem("bread", 1.99);
            book.AddItem("potato", 4.49);

            Console.WriteLine(book.ToString());

            Console.WriteLine("Price of eggs: " + book.GetPrice("eggs"));
            //Console.WriteLine(book.ToString());

        }
    }
}