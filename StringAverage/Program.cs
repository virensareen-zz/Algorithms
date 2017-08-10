using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    class Program
    {
        //**calculates the average of a string of numbers
        static void Main(string[] args)
        {
            AverageString("zero nine five two");

        }
        public static string AverageString(string str)
        {
            
            var words = str.Split(' ');            
            var integervalues = new List<int>();
            var mapper = new Dictionary<string, int>();
            var inttostring = new Dictionary<int, string>();

            mapper.Add("zero", 0);
            mapper.Add("one", 1);
            mapper.Add("two", 2);
            mapper.Add("three", 3);
            mapper.Add("four", 4);
            mapper.Add("five", 5);
            mapper.Add("six", 6);
            mapper.Add("seven", 7);
            mapper.Add("eight", 8);
            mapper.Add("nine", 9);

            for (var i = 0; i < words.Length; i++)
            {
                var keychecker = mapper.ContainsKey(words[i]);
                if (keychecker == false)
                {
                    return "n/a";
                }

                else
                {
                    var temp = 0;
                    mapper.TryGetValue(words[i], out temp);
                    integervalues.Add(temp);
                }
            }

            inttostring.Add(0, "zero");
            inttostring.Add(1, "one");
            inttostring.Add(2, "two");
            inttostring.Add(3, "three");
            inttostring.Add(4, "four");
            inttostring.Add(5, "five");
            inttostring.Add(6, "six");
            inttostring.Add(7, "seven");
            inttostring.Add(8, "eight");
            inttostring.Add(9, "nine");

            var decimalaverage = integervalues.Average();
            var average = Int32.Parse((Math.Floor(decimalaverage)).ToString());
            var stringaverage = "";
            
            inttostring.TryGetValue(average, out stringaverage);

            Console.WriteLine(stringaverage);
            Console.ReadLine();
            return "";
        }
    }
}
