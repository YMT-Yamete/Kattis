using System;
using System.Collections.Generic;

namespace Sort_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            List<int> intList = new List<int>();
            intList.Add(int.Parse(input[0]));
            intList.Add(int.Parse(input[1]));
            intList.Sort();

            for (int i = 0; i < 2; i++)
            {
                Console.Write(intList[i] + " ");
            }
        }
    }
}
