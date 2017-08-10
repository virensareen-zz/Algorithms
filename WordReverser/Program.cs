using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWords("The greatest victory");
            //Enter your string here
        }

        public static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                var reversedarray = word.ToCharArray();
                Array.Reverse(reversedarray);
                Console.Write("" + reversedarray);
                
            }
            Console.ReadLine();
            return null;
        }
    }
}
