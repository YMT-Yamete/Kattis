using System;
using System.Collections.Generic;
using System.Linq;

namespace Above_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            while (cases != 0)
            {
                cases--;
                List<int> grades = new List<int>();
                string[] input = Console.ReadLine().Split(" ");
                int i = input.Count() - 1;
                while (i != 0)
                {
                    i--;
                    grades.Add(int.Parse(input[i + 1]));
                }
                double average = grades.Average();
                int count = 0;
                for (int j = 0; j < grades.Count(); j++)
                {
                    if (grades[j] > average)
                    {
                        count++;
                    }
                }
                double percentage = (count * 100.000) / grades.Count();
                Console.WriteLine((Math.Round(percentage, 3)).ToString("0.000") + "%");
            }
        }
    }
}
