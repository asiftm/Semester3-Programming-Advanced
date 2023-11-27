﻿namespace week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NQueens nQueens = new NQueens(4);
            //nQueens.PlaceQueens();
            //Console.WriteLine(nQueens);


            /*/
             * 
             * 
             * 
             * 
             * 
             * 
             */

            int[] array = new int[] { 1,0,1,0};

            List<List<int>> result = new List<List<int>>(); //main list
            List<int> subset = new List<int>(); //small combinations

            SubsetProblem subsetProblem = new SubsetProblem();
            subsetProblem.Solve(array, result, subset);

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(" ", item));
            }

            /*
            foreach (var item in subsetProblem.SolveBinary(array))
            {
                Console.WriteLine(string.Join(" ", item));
            }
            */
        }
    }
}
