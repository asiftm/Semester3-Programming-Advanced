using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    public class MagicSquare
    {
        public int[,] Square { get; set; } //must be public property so I can play with in the Unit-Test
        // Square is a 2D dictionary to show the blank spaces of a magic square
        private int size; //Square size
        
        public MagicSquare(int square_size) // constructor
        {
            Square = new int[square_size,square_size]; // initialize the 2D array with n numbers of row and columns

            for (int i = 0; i < square_size; i++)
            {
                for (int j = 0; j < square_size; j++) //fill the array with zeros. later it will be replaced with 1 to n^2
                {
                    Square[i,j] = 0;
                }
            }
            size = square_size;
        }
        public string Create(int row = 0, int col = 0, int placed = 0) //create magic square. we have to start filling the indexes from 00 index in the 2D matrix, that is why the default value for row and column is 0.
        {
            /*
             row and column starts at index 0. so if the size of the matrix is 3 then rows will be 0,1,2
            in this condition below i just checking if the number of rows become higher then the size.
            if it does then stop inserting numbers
             */

            if(row == size && col == 0) 
            {
                Console.WriteLine(ToString());
                if (IsMagic()) return "solution :\n" + ToString();
                return "";
            }

            // go to every index in the 2D array and see if int i is valid or not in that index
            
            for (int i = 1; i < (size*size)+1; i++)
            {
                if (IsValid(i))
                {
                    // if IsValid == True then -->

                    Square[row, col] = i; // fill the index with that number

                    Tuple<int, int> tuple = NextPosition(row, col);// find the nxt position to do the same
                    
                    string output = Create(tuple.Item1, tuple.Item2, placed + 1); // creating a variable to store the output string

                    if (output.StartsWith("solution")) return output; // if you find the solution then stop the loop
                    Square[row, col] = 0; // if it fail to find the solution then rewrite the index with 0
                }
            }
            return "";
        }
        public Tuple<int, int> NextPosition(int row, int col) //find next position to fill (next column, or next column and first column again)
        {
            // conditions to find the next row and column
            if (row > size-1) return Tuple.Create(size, size);
            if (col == size-1) return Tuple.Create(row + 1, 0);
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(i == row && j == col) return Tuple.Create(i, j+1);
                }
            }
            return Tuple.Create(0,0);
        }
        public bool IsValid(int number) //is it valid to place this number? Is this number already in the square?
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Square[i, j] == number) return false; // checking every index of the array if it alreday contains the number
                }
            }
            return true;
        }
        public bool IsMagic() //is it a magic square? Checks every row/column/diagonal for the right magic constant
        {
            int magicConstant = (int)(size * ((Math.Pow(size, 2) + 1)) / 2);
            int sum = 0;
            
            //check rows
            for (int i = 0; i < size; i++)
            {
                sum = 0;
                for (int j = 0; j < size; j++)
                {
                    sum += Square[i, j];
                }
                if (sum != magicConstant) return false;
            }

            //check column
            for (int i = 0; i < size; i++)
            {
                sum = 0;
                for (int j = 0; j < size; j++)
                {
                    sum += Square[j, i];
                }
                if (sum != magicConstant) return false;
            }

            //check diagonal left to right
            sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += Square[i, i];
                
            }
            if (sum != magicConstant) return false;

            //check diagonal right to left
            sum = 0;
            for (int i = 0 , j = size -1 ; i < size && j >= 0 ; i++ , j--)
            {
                sum += Square[i, j];
            }
            if (sum != magicConstant) return false;

            return true;
        }
        public override string ToString() //prints magic square
        {
            string displaySquare ="";

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    displaySquare += Square[i,j] + " ";
                }
                displaySquare += "\n";
            }
            return displaySquare;
        }
    }
}
