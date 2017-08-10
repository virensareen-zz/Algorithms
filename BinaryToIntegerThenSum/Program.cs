using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate("10", "10");
            //Insert your 2 binary values in the brackets above
        }

        public static int Calculate(string num1, string num2)
        {
            var number1 = ConvertToInteger(num1);
            var number2 = ConvertToInteger(num2);
            var answer = number1 + number2;

            return answer;
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

    }
}
