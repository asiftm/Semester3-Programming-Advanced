using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Character
{
    internal class FindText
    {
        public string FindCharacter(string fileName, int index)
        {
            try
            {
                StreamReader streamReader = File.OpenText(fileName);
                string[] textArray = streamReader.ReadToEnd().Split("\n");

                if ( index < 0 || index > textArray.Length * 10)
                {
                    return "wrong input! Index is out of range";
                }

                char[] targetLineOfString = textArray[index / 10].ToCharArray();

                return targetLineOfString[index % 10].ToString();
            }
            catch
            {
               return "Something wrong!";
            }
        }
            
    }
}
