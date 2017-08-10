using System;
using System.Numerics;

namespace SummingStrings
{
    class Kata
    {
        static void Main(string[] args)
        {
            Add("123", "321");
            //Insert your 2 strings in the brackets above
        }
        public static string Add(string a, string b)
        {
            BigInteger iOne = 0;
            BigInteger iTwo = 0;
            BigInteger.TryParse(a, out iOne);
            BigInteger.TryParse(b, out iTwo);
            var answer = iOne + iTwo;

            Console.WriteLine(a + " + " + b + " = " + (answer).ToString());
            Console.ReadLine();
            
            return (answer).ToString();
        }
    }
}
