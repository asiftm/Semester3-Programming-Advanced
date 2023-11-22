using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Module_06
{
    class Missing_Link
    {
        public string GetMissingLink(int[] ints, int posNum = 1)
        {
            if (posNum >= ints.Length) return "No missing link";
            if (!ints.Contains(posNum)) return posNum.ToString();
            return GetMissingLink(ints, ++posNum);
        }
    }
}