using System;
using System.Collections.Generic;
using System.Linq;

namespace Costume_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCostume = Convert.ToInt32(Console.ReadLine());
            string temp = null;
            List<string> myChoice = new List<string>();
            Dictionary<string, int> costume = new Dictionary<string, int>();

            while (totalCostume > 0)
            {
                totalCostume--;
                temp = Console.ReadLine();
                if (costume.ContainsKey(temp))
                {
                    costume[temp]++;
                }
                else
                {
                    costume.Add(temp, 1);
                }
            }
            var minCount = costume.Aggregate((l, r) => l.Value < r.Value ? l : r).Value;
            foreach (var item in costume)
            {
                if (item.Value == minCount)
                {
                    myChoice.Add(item.Key);
                }
            }
            myChoice = myChoice.OrderBy(q => q).ToList();
            foreach (var item in myChoice)
            {
                Console.WriteLine(item);
            }
        }
    }
}
