using System;
using System.Collections.Generic;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            List<int> numberList = new List<int>();
            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                numberList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int j = count; j > 0; j--)
            {
                Console.WriteLine(numberList[j - 1]);
            }
        }
    }
}
