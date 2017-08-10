using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            GetVowelCount("Enter your string here");
        }
        public static int GetVowelCount(string str)
        {
            var vowelCount = 0;
            var chars = str.ToCharArray();
            for (int count = 0; count < chars.Length; count++)
                {
                    if ((chars[count]).ToString() == "a" || (chars[count]).ToString() == "e" || (chars[count]).ToString() == "i" || (chars[count]).ToString() == "o" || (chars[count]).ToString() == "u")
                    {
                        vowelCount++;
                    }
                }

            return vowelCount;
        }

    }
}
