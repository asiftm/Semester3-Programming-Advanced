using System;
namespace Module_07
{
    class Assignment
    {
        private int Largest = 0;
        private string BinaryInput;
        public Assignment(string input)
        {
            BinaryInput = input;
        }
        public int LargestBits(string binary)
        {
            if(binary.Length<=0) return Largest;

            string temp = string.Empty;

            for(int i = 0; i < binary.Length; i++)
            {
                temp += binary[i];
                if(Convert.ToInt64(temp) > Largest && Convert.ToInt64(temp) != Convert.ToInt64(BinaryInput) && isPalindrome(temp)) Largest = (int)Convert.ToInt64(temp);
            }
            //Console.WriteLine(binary);
            return LargestBits(binary.Substring(1));
        }

        private bool isPalindrome(string temp)
        {
            if (temp.Length == 1) return true;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != temp[temp.Length-1-i]) return false;
            }
            return true;
        }
    }
}