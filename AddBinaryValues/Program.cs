using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAdder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Add("00", "0");
            //Add your 2 binary values here
			// LOL
        }

        public static string Add(string a, string b)
        {
            int number_one = ConvertToInteger(a);
            int number_two = ConvertToInteger(b);

            if (number_one == 0)
            {
                if (number_two == 0)
                {
                    return "0";
                }
            }

            Console.WriteLine(ConvertToBinary(number_one + number_two));
            Console.ReadLine();
            return "";
        }

        public static int ConvertToInteger(string b)
        {
            var num = new int[100];
            var p = 1;
            var result = 0;
            var c = b.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                var ci = (c[i]).ToString();
                if (ci == "0")
                {
                    num[i] = 0;
                }
                else if (ci == "1")
                {
                    num[i] = 1;
                }

            }

            for (int i = c.Length - 1; i >= 0; --i)
            {
                result = result + num[i] * p;
                p = p * 2;
            }
      
            return result;
        }

        public static string ConvertToBinary(int number)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                binary = (number & mask) + binary;
                number = number >> 1;
            }

            return binary;
        }

    }
}
