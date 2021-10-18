using System;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            while (input != 0)
            {
                input--;
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine(a + " is even");
                }
                else
                {
                    Console.WriteLine(a + " is odd");
                }
            }
        }
    }
}
