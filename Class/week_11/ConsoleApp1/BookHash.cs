using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BookHash
    {
        private int V;
        private double[] Book;
        public BookHash(int items)
        {
            int size = GetNextPrime(items);
            Book = new double[size];

        }
        public int GetSize()
        {
            return Book.Length;
        }
        private int GetNextPrime(int items)
        {
            int temp = 0;
            for (int i = Convert.ToInt32(items*1.3); i > items; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < items; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime) temp++;
                if(temp == 2) return i;
            }
            return -1;
        }
        private int HashFunction(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += (int)key[i] + (int)Math.Pow(31,i);
            }
            return index % Book.Length;
        }
        public void AddItem(string product, double price)
        {
            int index = HashFunction(product);
            Book[index] = price;
        }
        public override string ToString()
        {
            return string.Join("\n", Book);
        }
        public double GetPrice(string product)
        {
            int price = HashFunction(product);
            return Book[price];
        }
    }
}


