using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumConsecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new List<int>{1, 4, 4, 4, 0, 4, 3, 3, 1};
            //Replace your values in the curly brackets above
            SumConsecutives(test);
        }
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> ret = new List<int>();
            int last = s[0], sum = 0;
            foreach (int i in s)
            {
                if (i == last) sum += last;
                else
                {
                    ret.Add(sum);
                    sum = last = i;
                }
            }

            ret.Add(sum);
            Console.WriteLine(ret);
            Console.ReadLine();
            return ret;
        }
    }
}
