using System;
using System.Collections.Generic;
using System.Linq;

namespace Batter_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            string[] batsString = Console.ReadLine().Split(" ");
            List<int> bats = new List<int>();
            for (int i = 0; i < batsString.Length; i++)
            {
                if (int.Parse(batsString[i]) >= 0)
                {
                    bats.Add(int.Parse(batsString[i]));
                }
            }
            Console.WriteLine(bats.Average());
        }
    }
}
