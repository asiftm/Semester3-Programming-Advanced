using System;
namespace TrialExam
{
    internal class BruteForce
    {
        private int Greatest = 0;
        public int GetGreatest(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    if (i != j)
                    {
                        int num = Convert.ToInt32(ints[i].ToString() + ints[j].ToString());
                        if (num > Greatest) Greatest = num;
                    }
                }
            }
            return Greatest;
        }
    }
}