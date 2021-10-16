using System;
using System.Collections.Generic;

namespace Akcija
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bookPrices = new List<int>();
            int bookCount = Convert.ToInt32(Console.ReadLine());
            int discountIndex = 2;
            int totalBookPrice = 0;

            while (bookCount > 0)
            {
                bookCount--;
                bookPrices.Add(Convert.ToInt32(Console.ReadLine()));
            }
            bookPrices.Sort();
            bookPrices.Reverse();
            for (int i = 0; i < bookPrices.Count; i++)
            {
                if (i == discountIndex)
                {
                    discountIndex = discountIndex + 3;
                }
                else
                {
                    totalBookPrice = totalBookPrice + bookPrices[i];
                }
            }
            Console.WriteLine(totalBookPrice);
        }
    }
}
