using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new[] {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5};
            //Replace values into the list above
            find_it(values);
        }

        public static int find_it(int[] seq)
        {
            var result = 0;

            foreach (var i in seq)
            {
                result ^= i;
            }
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }
    }
}
