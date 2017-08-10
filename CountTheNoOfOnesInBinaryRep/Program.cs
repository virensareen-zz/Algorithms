using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System;

    public class BitCount
    {
        public static void Main(string[] args)
        {
            CountBits(3);
            //Enter your Integer value here
        }

        public static int CountBits(int n)
        {
            int answer = 0;
            var binary = ConvertToBinary(n);
            var chars = binary.ToCharArray();

            for (int count = 0; count < chars.Length; count++)
            {
                var stringchar = (chars[count]).ToString();
                    if (stringchar == "1")
                    {
                        answer++;
                    }

                }
           
            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }

        public static string ConvertToBinary(int x)
        {
            var result = string.Empty;

            while (x > 0)
            {
                var remainder = x % 2;
                x /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }
    }
}