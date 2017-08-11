using System;
using System.Runtime.ExceptionServices;

namespace BubbleSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var yourarray = new int[] {1, 4, 0, 2};
            //Insert your values in the array above
            BubbleSort(yourarray);
        }

        public static int[] BubbleSort(int[] input)
        {
            var temp = 0;

            for (var write = 0; write < input.Length; write++)
                {
                    for (var sorter = 0; sorter < input.Length - 1; sorter++)
                        {
                            if (input[sorter] > input[sorter + 1])
                            {
                                temp = input[sorter + 1];
                                input[sorter + 1] = input[sorter];
                                input[sorter] = temp;
                            }
                        }
                }

            for (var i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + ", ");
            }

            Console.ReadLine();
            return input;
        }

    }
}
