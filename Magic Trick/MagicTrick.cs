using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> deck = new Dictionary<string, int>();
            char[] input = Console.ReadLine().ToCharArray();

            foreach (char i in input)
            {
                if (!deck.ContainsKey(i.ToString()))
                {
                    deck.Add(i.ToString(), 1);
                }
            }
            if (deck.Count() == input.Count())
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
