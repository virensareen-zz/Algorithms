using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToTime
{
    class Program
    {
        static void Main(string[] args)
        {
            GetReadableTime(0);
            //Insert your integer value in the brackets above
        }
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 359999)
            {
                return null;
            }

            var timespan = TimeSpan.FromSeconds(seconds);

            var answer = string.Format("{0:D2}:{1:D2}:{2:D2}", timespan.Hours, timespan.Minutes, timespan.Seconds);

            if (seconds == 86400)
            {
                answer = "24:00:00";
            }

            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }

    }
}
