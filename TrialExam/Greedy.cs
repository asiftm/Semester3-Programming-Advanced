using System;
namespace TrialExam
{
    internal class Greedy
    {
        public int GetGreatest(int[] ints)
        {
            Array.Sort(ints);
            int num1 = Convert.ToInt32(ints[ints.Length-1].ToString() + ints[ints.Length-2].ToString());
            int num2 = Convert.ToInt32(ints[ints.Length-2].ToString() + ints[ints.Length-1].ToString());

            if (num1 >= num2 ) return num1;
            else return num2;
        }
    }
}
