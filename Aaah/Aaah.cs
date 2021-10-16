using System;

namespace Kattis
{
    class Aaah
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (a.Length < b.Length)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("go");
            }
        }
    }
}