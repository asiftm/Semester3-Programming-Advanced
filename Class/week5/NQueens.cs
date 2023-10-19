using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class NQueens
    {
        char[,] board;
        int n;

        public NQueens(int size)
        {
            board = new char[size,size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    board[i,j] = '_';
                }
            }
            n = size;
        }
        public bool PlaceQueens(int col = 0)
        {
            if (col == n) return true; //base case

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ToString());
                if (IsSafe(i, col))
                {
                    board[i, col] = 'Q';
                    if (PlaceQueens(col+1)) return true;
                    board[i, col] = '_';
                }
            }
            return false;
        }
        private bool IsSafe(int row, int col)
        {
            //check row left side
            for (int i = 0; i < col; i++)
                if (board[row, i] == 'Q') return false;

            //check upper diagonal
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 'Q') return false;
            
            //check lower diagonal
            for (int i = row, j = col; i < n  && j >= 0; i++, j--)
                if (board[i, j] == 'Q') return false;

            return true;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    s += board[i,j] + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
