using System;
namespace TrialExam
{
    internal class Recursion
    {
        public int GetGreatest(int[] ints, int index = -1, int greatest = 0)
        {
            if (index == ints.Length-2) return greatest;
            
            greatest = GetGreatest(ints, ++index, greatest);

            for (int i = index + 1; i < ints.Length; i++)
            {
                int num1 = Convert.ToInt32(ints[index].ToString() + ints[i].ToString());
                int num2 = Convert.ToInt32(ints[i].ToString() + ints[index].ToString());

                if (num1 == num2 && num1 > greatest) greatest = num1;
                else if(num1 > greatest && num1 > num2) greatest = num1;
                else if(num2 > greatest && num2 > num1) greatest = num2;
                
            }
            return greatest;
        }
    }
}
